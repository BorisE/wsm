using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    /// <summary>
    /// Custom data types
    /// </summary>
    #region Custom data types for Sensors, Boltwood and so on

    /// <summary>
    /// Sensor type
    /// </summary>
    public enum SensorTypeEnum { Temp, Press, Hum, Illum, Wet, RGC, Relay, WSp };

    /// <summary>
    /// Boltwood Data Types
    /// </summary>
    public enum CloudCond { cloudUnknown = 0, cloudClear = 1, cloudCloudy = 2, cloudVeryCloudy = 3 }
    public enum WindCond { windUnknown = 0, windCalm = 1, windWindy = 2, windVeryWindy = 3 }
    public enum RainCond { rainUnknown = 0, rainDry = 1, rainWet = 2, rainRain = 3 }
    public enum DayCond { dayUnknown = 0, dayDark = 1, dayLight = 2, dayVeryLight = 3 }
    public enum RainFlag { rainFlagDry = 0, rainFlagLastminute = 1, rainFlagRightnow = 2 }
    public enum WetFlag { wetFlagDry = 0, wetFlagLastminute = 1, wetFlagRightnow = 2 }
    public enum WetSensorsMode { wetSensBoth = 0, wetSensWetOnly = 1, wetSensRGCOnly = 2 }

    /// <summary>
    /// Sensor element class
    /// </summary>
    public class SensorElement
    {
        public string SensorName = "";        //Sensor Name
        public SensorTypeEnum SensorType;   //Sensor Type
        public bool Enabled = true;         //Sensor Enabled flag
        public bool SendToWebFlag = true;
        public bool SendToNarodMon = false;
        public string SensorArduinoField = "";
        public string WebCustomName = "";
        public string NarodMonID = "";
        public string SensorFormField = "";

        public double LastValue = -100.0;
        public DateTime LastValueReadTime = DateTime.MinValue;

        public double MinValue = Int32.MaxValue;
        public DateTime MinValueSetTime = DateTime.MinValue;
        public double MaxValue = Int32.MinValue;
        public DateTime MaxValueSetTime = DateTime.MinValue;

        private const byte SENSOR_HISTORY_LENGTH = 25; //approx 5 min (25 * 14.3 sec)
        public List<double> ValuesLastFiveMin = new List<double>();
        public double AverageHistoryValues = -100.0;
        public int ValuesCount = 0;

        public double AverageBetweenDataSend_Narodmon_SUM = 0.0;
        public int AverageBetweenDataSend_Narodmon_COUNT = 0;

        public double AverageBetweenDataSend_Web_SUM = 0.0;
        public int AverageBetweenDataSend_Web_COUNT = 0;

        //Method for adding values
        public void AddValue(double NewValue)
        {
            //LastValue
            LastValue = NewValue;
            LastValueReadTime = DateTime.Now;
            ValuesCount++;

            //Add to LastValuesArray
            int startIdx;
            if (ValuesLastFiveMin.Count < SENSOR_HISTORY_LENGTH)
            {
                startIdx = ValuesLastFiveMin.Count() - 1;
                ValuesLastFiveMin.Add(-100.0);
            }
            else
            {
                startIdx = ValuesLastFiveMin.Count() - 2;
            }
            for (int i = startIdx; i >= 0; i--)
            {
                ValuesLastFiveMin[i + 1] = ValuesLastFiveMin[i];
            }
            ValuesLastFiveMin[0] = NewValue;

            //check if extreme values?
            if (NewValue < MinValue)
            {
                MinValue = NewValue;
                MinValueSetTime = DateTime.Now;
            }
            if (NewValue > MaxValue)
            {
                MaxValue = NewValue;
                MaxValueSetTime = DateTime.Now;
            }

            //Average in last stored values
            AverageHistoryValues = ValuesLastFiveMin.Average();

            //Average between sendings Web
            AverageBetweenDataSend_Web_SUM += NewValue;
            AverageBetweenDataSend_Web_COUNT++;

            //Average between sendings Narodmon
            AverageBetweenDataSend_Narodmon_SUM += NewValue;
            AverageBetweenDataSend_Narodmon_COUNT++;
        }

        //Method for clearing data between sendings WEB
        public void ClearValuesWeb()
        {
            AverageBetweenDataSend_Web_SUM = 0;
            AverageBetweenDataSend_Web_COUNT = 0;
        }

        //Method for clearing data between sendings NARODMON
        public void ClearValuesNarodmon()
        {
            AverageBetweenDataSend_Narodmon_SUM = 0;
            AverageBetweenDataSend_Narodmon_COUNT = 0;
        }
        //Note, that Last Five Min - approximate value, it can be changed
        public double AverageLastFiveMin()
        {
            //return ValuesLastFiveMin.Average();
            return 0;
        }
    }


    /// <summary>
    /// Settings element (TD, WT, RT)
    /// </summary>
    public class ArduinoSettingsClass
    {
        public string Value = "";
        public DateTime ReadTime = new DateTime();
    }

    public enum CloudSensorModel { Classic = 1, AAG = 2 }

    #endregion


    public partial class Hardware
    {

        public void initSensorList()
        {
            Logging.Log("initSensorList enter", 3);

            //Clear current values
            SensorsList.Clear();

            SensorElement SensorEl = new SensorElement();

            //MLX
            SensorEl.SensorName = "ObjTemp";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = false;
            SensorEl.SensorFormField = "txtFldObj";
            SensorEl.SensorArduinoField = "Obj";
            SensorEl.WebCustomName = "ot";
            SensorsList.Add(SensorEl.SensorName,SensorEl);


            //Amb
            SensorEl = new SensorElement();
            SensorEl.SensorName = "ATemp";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldATemp";
            SensorEl.SensorArduinoField = "Amb";
            SensorEl.WebCustomName = "at";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //BMP085
            SensorEl = new SensorElement();
            SensorEl.SensorName = "BTemp";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = false;
            SensorEl.SensorFormField = "txtFldBTemp";
            SensorEl.SensorArduinoField = "BTe";
            SensorEl.WebCustomName = "bt";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            SensorEl = new SensorElement();
            SensorEl.SensorName = "Press";
            SensorEl.SensorType = SensorTypeEnum.Press;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldPress";
            SensorEl.SensorArduinoField = "Pre";
            SensorEl.WebCustomName = "bp";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //DHT22_1
            SensorEl = new SensorElement();
            SensorEl.SensorName = "Hum1";
            SensorEl.SensorType = SensorTypeEnum.Hum;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldHum1";
            SensorEl.SensorArduinoField = "DH1";
            SensorEl.WebCustomName = "dh";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            SensorEl = new SensorElement();
            SensorEl.SensorName = "DTemp1";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = false;
            SensorEl.SensorFormField = "txtFldDTemp1";
            SensorEl.SensorArduinoField = "DT1";
            SensorEl.WebCustomName = "dt";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //DHT22_2
            SensorEl = new SensorElement();
            SensorEl.SensorName = "Hum2";
            SensorEl.SensorType = SensorTypeEnum.Hum;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = false;
            SensorEl.SensorFormField = "txtFldHum2";
            SensorEl.SensorArduinoField = "DH2";
            SensorEl.WebCustomName = "dh2";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            SensorEl = new SensorElement();
            SensorEl.SensorName = "DTemp2";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = false;
            SensorEl.SensorFormField = "txtFldDTemp2";
            SensorEl.SensorArduinoField = "DT2";
            SensorEl.WebCustomName = "dt2";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //Illuminance
            SensorEl = new SensorElement();
            SensorEl.SensorName = "Illum";
            SensorEl.SensorType = SensorTypeEnum.Illum;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldIllum";
            SensorEl.SensorArduinoField = "Lum";
            SensorEl.WebCustomName = "bhv";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //OneWire temp
            SensorEl = new SensorElement();
            SensorEl.SensorName = "Temp1";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldTemp1";
            SensorEl.SensorArduinoField = "Te1";
            SensorEl.WebCustomName = "owt1";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            SensorEl = new SensorElement();
            SensorEl.SensorName = "Temp2";
            SensorEl.SensorType = SensorTypeEnum.Temp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldTemp2";
            SensorEl.SensorArduinoField = "Te2";
            SensorEl.WebCustomName = "owt2";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //Wet sensor
            SensorEl = new SensorElement();
            SensorEl.SensorName = "Wet";
            SensorEl.SensorType = SensorTypeEnum.Wet;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldWet";
            SensorEl.SensorArduinoField = "Wet";
            SensorEl.WebCustomName = "wsv";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //RGC sensor
            SensorEl = new SensorElement();
            SensorEl.SensorName = "RGC";
            SensorEl.SensorType = SensorTypeEnum.RGC;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "txtFldRGC";
            SensorEl.SensorArduinoField = "RGC";
            SensorEl.WebCustomName = "rgc";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //Relay1
            SensorEl = new SensorElement();
            SensorEl.SensorName = "RL1";
            SensorEl.SensorType = SensorTypeEnum.Relay;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "";
            SensorEl.SensorArduinoField = "RL1";
            SensorEl.WebCustomName = "rl1";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //Relay2
            SensorEl = new SensorElement();
            SensorEl.SensorName = "RL2";
            SensorEl.SensorType = SensorTypeEnum.Relay;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = "";
            SensorEl.SensorArduinoField = "RL2";
            SensorEl.WebCustomName = "rl2";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //Wind Speed
            SensorEl = new SensorElement();
            SensorEl.SensorName = "WSp";
            SensorEl.SensorType = SensorTypeEnum.WSp;
            SensorEl.Enabled = true;
            SensorEl.SendToWebFlag = true;
            SensorEl.SendToNarodMon = true;
            SensorEl.SensorFormField = ""; 
            SensorEl.SensorArduinoField = "WnV";
            SensorEl.WebCustomName = "wns";
            SensorsList.Add(SensorEl.SensorName, SensorEl);

            //Make hash tables
            int SensIdx = -1;
            SensorsArrayHashArduino.Clear();
            foreach (SensorElement DataSensor in SensorsList.Values)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    SensorsArrayHashArduino.Add(DataSensor.SensorArduinoField, SensIdx);
                }
            }

            //set base temp
            BaseTempVal = SensorsList[BaseTempName].LastValue;

            Logging.Log("initSensorList exit", 3);

        }

        /// <summary>
        /// Autosearch sensors. Not implemented
        /// </summary>        
        public void searchSensors()
        {
            Logging.Log("searchSensors enter", 3);

            foreach (SensorElement DataSensor in SensorsList.Values)
            {
                if (DataSensor != null)
                {
                }
            }
            Logging.Log("searchSensors exit", 3);
        }

        /// <summary>
        /// Init command interpretator
        /// </summary>
        public void InitComandInterpretator()
        {
            CommandParser.Commands.Add("GET_BASETEMP", () => this.getBaseTemp());
            CommandParser.Commands.Add("GET_SENSOR_VALUES", () => this.getSensorsString());
            CommandParser.Commands.Add("HELP", () => CommandParser.ListCommands());
            CommandParser.Commands.Add("VERSION", () => VersionData.getVersionString());
        }

    }
}
