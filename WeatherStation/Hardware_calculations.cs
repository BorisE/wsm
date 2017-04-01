using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace WeatherStation
{
    public partial class Hardware
    {
        /// <summary>
        /// Calculate sensors values after parsing incoming data
        /// </summary>
        private void MakeSensorsCalculations()
        {
            Logging.Log("MakeSensorsCalculations enter", 3);

            //1. FIX THE MOMENT OF MEASURE FOR BOLWOOD CS DATA SINCE LAST MEASURE
            LastMeasure = DateTime.Now;

            //2. BASE TEMP SENSOR SETTING
            try
            {
                if (SensorsList.ContainsKey(BaseTempName))
                {
                    if (SensorsList[BaseTempName].CheckLastValue())
                    {
                        BaseTempVal = SensorsList[BaseTempName].LastValue;
                    }
                }
            }
            catch { Logging.Log("Base temp calculation exception", 2); }

            //3. AUXILIARY SENSOR FIELDS
            try
            {
                IllumVal = SensorsList["Illum"].LastValue;
                ObjTempVal = SensorsList["ObjTemp"].LastValue;
                SensorCaseTempVal = SensorsList["ATemp"].LastValue;
                HumidityVal = SensorsList["Hum1"].LastValue;
                WetVal = (int)SensorsList["Wet"].LastValue;
                RGCVal = (int)SensorsList["RGC"].LastValue;
                RainIntensityVal = (RGCVal >= 0 ? RGCVal : 0) / (MeasureCycleLen / 1000.0) * 60 * RGC_ONETICK_VALUE; //mm per min
                RGC_Cumulative += (double)(RGCVal >= 0 ? RGCVal : 0);
                RGC_Cumulative_mm = RGC_Cumulative * RGC_ONETICK_VALUE;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);
                StackFrame[] frames = st.GetFrames();
                string messstr = "";

                // Iterate over the frames extracting the information you need
                foreach (StackFrame frame in frames)
                {
                    messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                }

                string FullMessage = "Error loading settings. ";
                FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                Logging.Log(FullMessage);
                Logging.Log("Exception in MakeSensorCalculations! " + Environment.NewLine + ex.ToString());
            }

            //4. CALCULATED SENSOR FIELDS
            //4.1. CLOUD INDEX CALCULATIONS
            if (CheckData(ObjTempVal, SensorTypeEnum.Temp) && CheckData(BaseTempVal, SensorTypeEnum.Temp))
            {
                if (Relay1 == 0 && (SensorCaseTempVal < (BaseTempVal + HEATER_MAX_TEMPERATURE_DELTA * 0.7))) //0.7 - need to try
                {
                    CloudIdx = calcCloudIndex(ObjTempVal, BaseTempVal);
                    CloudIdxAAG = calcCloudIndexCorr(ObjTempVal, BaseTempVal);
                }
                else if (CloudIdx==-100)
                {
                    CloudIdx = calcCloudIndex(ObjTempVal, BaseTempVal); //если было -100, то оно и останется. Так хоть что-то будет
                    CloudIdxAAG = calcCloudIndexCorr(ObjTempVal, BaseTempVal); //если было -100, то оно и останется. Так хоть что-то будет
                }
            }

            //4.2. Calc if needed average of last 5 min (more precisely - 25 by default) values
            if (LastMeasure.Minute % 5 == 0 && LastMeasure.Minute != SkyIndexAlreadyAddedMinute)
            {
                SkyIndexAlreadyAddedMinute = LastMeasure.Minute;
                //Add to SkyIndex5min and shift previous values
                int startIdx;
                if (SkyIndex5min.Count() < SKYSENSOR_HISTORY_LENGTH)
                {
                    startIdx = SkyIndex5min.Count() - 1;
                    SkyIndex5min.Add(-100.0);
                }
                else
                {
                    startIdx = SkyIndex5min.Count() - 2;
                }
                for (int i = startIdx; i >= 0; i--)
                {
                    SkyIndex5min[i + 1] = SkyIndex5min[i];
                }
                SkyIndex5min[0] = calcCloudIndex(SensorsList["ObjTemp"].AverageHistoryValues, SensorsList[BaseTempName].AverageHistoryValues);
            }

            //4.3. CALC RAIN STATUS
            calcRainingCondition();

            Logging.Log("MakeSensorsCalculations exit", 3);

        }


        internal bool CSNeedsHeating_CSIntervalMet = false;
        internal bool CSNeedsHeating_CSDecreasingTempMet = false;
        internal bool CSNeedsHeating_SinceLastHeatingMet = false;
        internal bool CSNeedsHeating_RelayOffNow = false;
        internal bool CSNeedsHeating_HumidityMet = false;
        internal bool CSNeedsHeating_NotRainingMet = false;
        internal bool CSNeedsHeating_DarknessMet = false;


        /// <summary>
        /// Check if sensor heating needed
        /// </summary>
        public void CheckIfSkySensorHeatingNeeded()
        {
            Logging.Log("CheckIfSkySensorHeatingNeeded enter", 3);

            CloudSensorNeedHeatingFlag = false;

            // Check - if cloud sensor values are in given interval?
            CSNeedsHeating_CSIntervalMet = (CloudIdx > HEATER_CLOUDINDEX_MIN && CloudIdx < HEATER_CLOUDINDEX_MAX);

            // Ckeck - if CS temp monotonous decreasing
            double deltaCur = -100.0;
            CSNeedsHeating_CSDecreasingTempMet = false;
            for (int i = 1; i < Math.Min(SkyIndex5min.Count, CS_NEEDHEATING_LOOKBACK_CYCLES); i++)
            {
                deltaCur = SkyIndex5min[i] - SkyIndex5min[i - 1];
                if (deltaCur >= CS_NEEDHEATING_MINDELTA && deltaCur <= CS_NEEDHEATING_MAXDELTA)
                {
                    //condition is met on this interval
                    CSNeedsHeating_CSDecreasingTempMet = true;
                }
                else
                {
                    //condition is broken on this interval. No need to heat, exit
                    CSNeedsHeating_CSDecreasingTempMet = false;
                    break;
                }
            }
            //for auxiliary calculations
            CloudSensorNeedHeatingFlag = (CSNeedsHeating_CSIntervalMet && CSNeedsHeating_CSDecreasingTempMet);
            if (CloudSensorNeedHeatingFlag) Logging.Log("Cloud sensor heating narrow condition is met, but need to test other", 2);

            // Check - how long has been passed since last switch on
            TimeSpan SinceLastHeatingMF = DateTime.Now.Subtract(LastHeating1SwitchOff);
            Heating1Off_SecondsPassed = (int)Math.Round(SinceLastHeatingMF.TotalSeconds, 0);
            SinceLastHeatingMF = DateTime.Now.Subtract(LastHeating1SwitchOn);
            Heating1On_SecondsPassed = (int)Math.Round(SinceLastHeatingMF.TotalSeconds, 0);
            SinceLastHeating1 = Math.Min(Heating1Off_SecondsPassed, Heating1On_SecondsPassed);
            CSNeedsHeating_SinceLastHeatingMet = (SinceLastHeating1 > HEATER_CS_PAUSE); //since last heating session passed enough time
            //Relay off now?
            CSNeedsHeating_RelayOffNow = (SensorsList["RL1"].LastValue == 0); //heating not engaged already

            //Check - humidity is high?
            CSNeedsHeating_HumidityMet = (SensorsList["Hum1"].LastValue >= 99.9); //high humidity

            //Check - is it raining now?
            CSNeedsHeating_NotRainingMet = (!RainLastMinute_Flag); //no rain in last minute

            //Check - is it dark?
            CSNeedsHeating_DarknessMet = (IllumVal <= DAYLIGHT_DARK_LIMIT && IllumVal >= 0); //is it dark now?


            //GENERAL CHECK
            if (CloudSensorNeedHeatingFlag && CSNeedsHeating_SinceLastHeatingMet && CSNeedsHeating_RelayOffNow && CSNeedsHeating_HumidityMet
                && CSNeedsHeating_NotRainingMet && CSNeedsHeating_DarknessMet)
            {
                //Switch on
                HeatingOn();
            }

            Logging.Log("CheckIfSkySensorHeatingNeeded exit", 3);
        }


        /// <summary>
        /// Calculates Cloud Index by classic methodology
        /// </summary>
        /// <param name="Tsky">Measured sky temperature</param>
        /// <param name="Tamb">Ambient temperature</param>
        /// <returns>Corrected sky temperature which is used as index</returns>
        public double calcCloudIndex(double Tsky, double Tamb, double Tcase = -100.0)
        {
            double Tclidx = -100.0;
            if (CheckData(Tcase, SensorTypeEnum.Temp))
            {
                Tclidx = Tamb - Tsky;
            }
            else
            {
                Tclidx = Tamb - Tsky;
            }

            return Tclidx;
        }


        /// <summary>
        /// Calculates Cloud Index by AAG_CloudWatcher methodology
        /// </summary>
        /// <param name="Tsky">Measured sky temperature</param>
        /// <param name="Tamb">Ambient temperature</param>
        /// <returns>Corrected sky temperature which is used as index</returns>
        public double calcCloudIndexCorr(double Tsky, double Tamb)
        {
            double T67 = 0.0;

            if (Math.Abs((K2 / 10 - Tamb)) < 1)
            {
                T67 = Math.Sign(K6) * Math.Sign(Tamb - K2 / 10) * Math.Abs((K2 / 10 - Tamb));
            }
            else
            {
                T67 = K6 / 10 * Math.Sign(Tamb - K2 / 10) * (Math.Log(Math.Abs((K2 / 10 - Tamb))) / Math.Log(10) + K7 / 100);
            }

            double Td = (K1 / 100) * (Tamb - K2 / 10) + (K3 / 100) * Math.Pow(Math.Exp(K4 / 1000 * Tamb), (K5 / 100)) + T67;

            double Tcorr = Td - Tsky;

            return Tcorr;
        }

        /// <summary>
        /// Check all rain conditions based on 2 sensors: RG-11 and Wet sensor
        /// Set rain flags for both sensors:
        /// - Wet sensor - rain/wet condition now / last minute
        /// - RG-11 - rain now/last minute
        /// United rain flag is set based on both sensors values and parameter RainConditionMode (see below)
        /// </summary>
        /// <returns>true - if rains now</returns>
        public bool calcRainingCondition()
        {
            Logging.Log("GetRainingCondition enter", 3);

            /**********  Calculate RAIN RIGHT NOW CONDITION ***************/

            try
            {
                /***** Calculate Wet Sensor value ****/
                if (WetVal > RAININDEX_WET_LIMIT)
                {
                    //DRY
                    RainNow_WetS_FlagC = RainCond.rainDry;
                }
                else if (WetVal > RAININDEX_RAIN_LIMIT)
                {
                    if (Bolt_CloudCond == CloudCond.cloudCloudy || Bolt_CloudCond == CloudCond.cloudVeryCloudy)
                    {
                        //WET
                        RainNow_WetS_FlagC = RainCond.rainWet;
                        Logging.Log("Wet sensor is wet now", 3);
                    }
                    else
                    {
                        //DRY: if not cloudy - don't set as wet
                        RainNow_WetS_FlagC = RainCond.rainDry;
                    }
                }
                else if (WetVal >= RAININDEX_BAD_LIMIT)
                {
                    //RAIN
                    RainNow_WetS_FlagC = RainCond.rainRain;
                    Logging.Log("Wet sensor detects rain now", 3);
                }
                if (!SensorsList["Wet"].Enabled)
                    RainNow_WetS_FlagC = RainCond.rainUnknown;


                /********* Calculate RGC Sensor value ********/
                if (RGCVal > 0)
                {
                    RainNow_RGC_Flag = true;
                    Logging.Log("RGC sensed rain now", 3);
                }
                else
                {
                    RainNow_RGC_Flag = false;
                }

            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);
                StackFrame[] frames = st.GetFrames();
                string messstr = "";

                // Iterate over the frames extracting the information you need
                foreach (StackFrame frame in frames)
                {
                    messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                }

                string FullMessage = "Error loading settings. ";
                FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                Logging.Log(FullMessage);
                Logging.Log("Exception in Calculation rain values: " + ex.ToString());
            }


            /*******************  Calculate RAIN IN LAST MINUTE CONDITION ******************/
            /*
             * 
             * Last minute =    if rain now true - rain during previous cycles (5 min approx)
             *                  if rain now flase - rain during previous cycles (5 min approx)
             */
            int NumValuesInMinute = (int)Math.Round(60.0 / MeasureCycleLen * 1000);
            int countRRainCylcles = 0;
            try
            {
                // Calculate rain last minute for RGC sensor 

                for (int i = 1; i < Math.Min(NumValuesInMinute, SensorsList["RGC"].ValuesLastFiveMin.Count); i++)
                {
                    if (SensorsList["RGC"].ValuesLastFiveMin[i] > 0) countRRainCylcles++;
                }
                if (countRRainCylcles > 0 && SensorsList["RGC"].Enabled) //
                {
                    RainLastMinute_RGC_Flag = true;
                    Logging.Log("RGC sensed rain last minute", 1);
                }
                else
                {
                    RainLastMinute_RGC_Flag = false;
                }


                // Calculate rain last minute for WET sensor 

                int countWRainCylcles = 0, countWWetCylcles = 0;

                for (int i = 1; i < Math.Min(NumValuesInMinute, SensorsList["Wet"].ValuesLastFiveMin.Count); i++)
                {
                    if (SensorsList["Wet"].ValuesLastFiveMin[i] <= RAININDEX_RAIN_LIMIT) { countWRainCylcles++; }
                    else if (SensorsList["Wet"].ValuesLastFiveMin[i] <= RAININDEX_WET_LIMIT) { countWWetCylcles++; }
                }
                if (countWRainCylcles > 0 && SensorsList["Wet"].Enabled) //
                {
                    RainLastMinute_WetS_FlagC = RainCond.rainRain;
                    Logging.Log("Wet sensed rain last minute", 3);
                }
                else if (countWWetCylcles > 0 && SensorsList["Wet"].Enabled) //
                {
                    RainLastMinute_WetS_FlagC = RainCond.rainWet;
                    Logging.Log("Wet sensed wet last minute", 3);
                }
                else if (SensorsList["Wet"].Enabled) //
                {
                    RainLastMinute_WetS_FlagC = RainCond.rainDry;
                }
                else
                {
                    RainLastMinute_WetS_FlagC = RainCond.rainUnknown;
                }

            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);
                StackFrame[] frames = st.GetFrames();
                string messstr = "";

                // Iterate over the frames extracting the information you need
                foreach (StackFrame frame in frames)
                {
                    messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                }

                string FullMessage = "Error loading settings. ";
                FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                Logging.Log(FullMessage);
                Logging.Log("Exception in Calculate rain last minute: " + ex.ToString());
            }

            /************************  Rain now conditions when using both sensors   *****************************
             *****************************************************************************************************
             *  Wet            | rainUnknown   | rainWet   | rainRain  | rainDry   |
             *  --------------------------------------------------------------------
             *  RGC>0 & RGCLM- |       X       |     X     |     X     |           |
             *  RGC>0 & RGCLM+ |       X       |     X     |     X     |     X     |
             *  RGC=0 & RGCLM- |               |           |           |           |
             *  RGC=0 & RGCLM+ |               |           |     X     |           |
             *  --------------------------------------------------------------------
             *****************************************************************************************************/
            try
            {
                switch (RainConditionMode)
                {
                    case WetSensorsMode.wetSensBoth:
                        if ((RainNow_RGC_Flag && (RainNow_WetS_FlagC == RainCond.rainUnknown || RainNow_WetS_FlagC == RainCond.rainWet || RainNow_WetS_FlagC == RainCond.rainRain))
                            || (RainNow_RGC_Flag && RainLastMinute_RGC_Flag)
                            || (!RainNow_RGC_Flag && RainLastMinute_RGC_Flag && (RainNow_WetS_FlagC == RainCond.rainRain)))
                        {
                            RainNow_Flag = true;
                        }
                        else
                        {
                            RainNow_Flag = false;
                        }

                        /*  Rain last minute conditions when using both sensors
                         *  Wet            | rainUnknown   | rainWet   | rainRain  | rainDry   |
                         *  --------------------------------------------------------------------
                         *  RGCLM+         |       X       |     X     |     X     |           |
                         *  RGCLMcnt>=2    |       X       |     X     |     X     |     X     |
                         *  RGCLM-         |               |           |           |           |
                         *  --------------------------------------------------------------------
                         */
                        if ((RainLastMinute_RGC_Flag && (RainLastMinute_WetS_FlagC == RainCond.rainUnknown || RainLastMinute_WetS_FlagC == RainCond.rainWet || RainLastMinute_WetS_FlagC == RainCond.rainRain))
                            || (countRRainCylcles >= 2 && (RainLastMinute_WetS_FlagC == RainCond.rainDry)))
                        {
                            RainLastMinute_Flag = true;
                        }
                        else
                        {
                            RainLastMinute_Flag = false;
                        }
                        break;
                    case WetSensorsMode.wetSensRGCOnly:
                        if (RainLastMinute_RGC_Flag) { RainLastMinute_Flag = true; }
                        else { RainLastMinute_Flag = false; }

                        if (RainNow_RGC_Flag) { RainNow_Flag = true; }
                        else { RainNow_Flag = false; }

                        break;
                    case WetSensorsMode.wetSensWetOnly:
                        if (RainLastMinute_WetS_FlagC == RainCond.rainRain) { RainLastMinute_Flag = true; }
                        else { RainLastMinute_Flag = false; }

                        if (RainNow_WetS_FlagC == RainCond.rainRain) { RainNow_Flag = true; }
                        else { RainNow_Flag = false; }

                        break;
                }
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);
                StackFrame[] frames = st.GetFrames();
                string messstr = "";

                // Iterate over the frames extracting the information you need
                foreach (StackFrame frame in frames)
                {
                    messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                }

                string FullMessage = "Error loading settings. ";
                FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                Logging.Log(FullMessage);
                Logging.Log("Exception in switch (RainConditionMode): " + ex.ToString());
            }

            Logging.Log("GetRainingCondition exit", 3);

            return RainNow_Flag;
        }



        /// <summary>
        /// Calculates dew point temperature (very good approximation)
        /// </summary>
        /// <param name="Temp">Ambient temperature</param>
        /// <param name="Hum">Current humidity</param>
        /// <returns></returns>
        public double calcDewPoint(double Temp, double Hum)
        {
            double a = 17.271;
            double b = 237.7;
            double te = (a * Temp) / (b + Temp) + Math.Log(Hum / 100);
            double Td = (b * te) / (a - te);

            return Td;

        }


        /// <summary>
        /// Calculates wind speed in m/s for a given windspeed sensor value
        /// </summary>
        /// <param name="WSVal">Wind speed sensor value</param>
        /// <returns>Wind speed in m/s</returns>
        public double calcWindSpeed(double WSVal)
        {
            double calibration_maxspeed__ = 32.4;
            double calibration_multiplier__ = 1.6;

            //1. Cacluate voltage (from arduino analogread value
            //Analog sensor value (which will be between 0 and 1023, perfect for an int datatype) coming in from your potentiometer:
            //int sensorValue = analogRead(A0);
            //To change the values from 0-1023 to a range that corresponds to the voltage the pin is reading, you'll need to create another variable, a float, and do a little math. To scale the numbers between 0.0 and 5.0, divide 5.0 by 1023.0 and multiply that by sensorValue :
            //float voltage= sensorValue * (5.0 / 1023.0); 
            double WindSensorVoltage = WSVal * (5.0 / 1023.0); //

            //2. Calculate corresponding zero voltage value based on Calibration ZeroSpeed analogread count value
            double calibraion_ZeroSpeedVoltage = WS_Calibraion_ZeroSpeedAnalogValue * 5.0 / 1023.0;

            //3. Calculate wind speed
            // Range: 0 ~ 32.4m/s
            // Wind speed values = output voltage - 0.4) /1.6*32.4
            double windspeed_raw = (WindSensorVoltage - calibraion_ZeroSpeedVoltage) / WS_Calibraion_PartialMultiplier * WS_Calibraion_MaxspeedMultiplier;


            if (windspeed_raw > -1) { windspeed_raw = Math.Max(windspeed_raw, 0.0); } //deal with negative values
            //if too negative (-7.8) then there is no input voltage on sensor and leave the value as is

            double RVal = Math.Round(windspeed_raw, 2); //round value to 0.01 

            return RVal;
        }


        internal double curVal;
        internal double minVal;
        internal TimeSpan PassedFromMinSet;
        internal TimeSpan PassedFromMinHit;
        /// <summary>
        /// Procedure to autocalibrate zero wind speed value
        /// Note. The process can be explored in Debug Window, autocalibrate section
        /// </summary>
        private void AutoCalibrateWindSpeed()
        {

            curVal = SensorsList["WSp"].LastValue;
            minVal = SensorsList["WSp"].MinValue;
            PassedFromMinSet = DateTime.Now - SensorsList["WSp"].MinValueSetTime;

            //check - if minVal changed?
            if (minVal != LastMinValue)
            {
                LastMinValue = minVal;
                WS_MinValue_HitCount = 0;
                WS_MinValue_LastHit = new DateTime(2010, 01, 01);
            }

            //record it if hit
            if (curVal == minVal)
            {
                WS_MinValue_LastHit = DateTime.Now;
                WS_MinValue_HitCount++;

                //if was enough hits - ser zerospeed calibration value
                if (WS_MinValue_HitCount > WS_HitCount_Threshold)
                {
                    WS_Calibraion_ZeroSpeedAnalogValue = Convert.ToInt32(minVal);
                }
            }

            //calc time from last hit
            PassedFromMinHit = DateTime.Now - WS_MinValue_LastHit;
            //reset min value
            if (PassedFromMinHit.TotalSeconds > autoCalWS_maxPassedFromHit)
            {
                SensorsList["WSp"].MinValue = curVal;
                WS_MinValue_HitCount = 0;
                WS_MinValue_LastHit = new DateTime(2010, 01, 01);
            }

        }


        /// <summary>
        /// Recalculate equavalent pressure on height above sea level
        /// </summary>
        /// <param name="PressBase">Pressure needed to be recalculated</param>
        /// <param name="dHeight">Height in meter</param>
        /// <param name="dTemp">Temperature, Celcius</param>
        public double CalcPressureOnHeight(double PressBase, double dHeight, double dTemp)
        {
            const double MollMass = 0.029; //молярная масса сухого воздуха, M = 0,029 кг/моль;
            const double g = 9.81; //ускорение свободного падения, g = 9,81 м/с²;
            const double R = 8.31; // универсальная газовая постоянная, R = 8,31 Дж/моль·К;

            double Tabs = dTemp + 273; // абсолютная температура воздуха, К, T = t + 273, где t — температура в °C;

            double Press = PressBase * Math.Exp(-MollMass * g * dHeight / (R * Tabs));

            return Press;
        }

        /// <summary>
        /// Calculate normal pressure for a given height
        /// </summary>
        /// <returns></returns>
        private double CalcNormalPressure()
        {
            //temp calc not used
            double Temp = -100.0;
            if (CheckData(BaseTempVal, SensorTypeEnum.Temp))
            {
                Temp = BaseTempVal;
            }
            else
            {
                Temp = 0.0;
            }

            Temp = 0.0;
            double Press = CalcPressureOnHeight(760.0, HeightAboveSea, Temp);
            return Press;
        }


    }
}
