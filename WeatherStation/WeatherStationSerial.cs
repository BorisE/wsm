using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

public enum SensorTypeEnum { Temp, Press, Hum, Illum, Wet, RGC };

/// <summary>
/// Boltwood Data Types
/// </summary>
public enum CloudCond { cloudUnknown = 0, cloudClear = 1, cloudCloudy = 2, cloudVeryCloudy = 3 }
public enum WindCond { windUnknown = 0, windCalm=1, windWindy=2, windVeryWindy=3 }
public enum RainCond { rainUnknown = 0, rainDry = 1, rainWet = 2, rainRain = 3 }
public enum DayCond { dayUnknown = 0, dayDark = 1, dayLight = 2, dayVeryLight = 3 }

public enum RainFlag { rainFlagDry = 0, rainFlagLastminute = 1, rainFlagRightnow = 2 }
public enum WetFlag { wetFlagDry = 0, wetFlagLastminute = 1, wetFlagRightnow = 2 }


public class SensorElement
{
    public string SensorName="";
    public SensorTypeEnum SensorType;
    public bool Enabled = true;
    public bool SendToWebFlag=true;
    public bool SendToNarodMon=false;
    public string SensorArduinoField = "";
    public string SensorFormField = "";
    public double LastValue = -100.0;
    public DateTime LastValueReadTime = DateTime.MinValue;
    public int ValuesCount = 0;
}

namespace WeatherStation
{
    public class WeatherStationSerial
    {
        /// <summary>
        /// Serial Port name
        /// </summary>        
        public string PortName = "COM5";

        /// <summary>
        /// The SerialPort object, which is used for communicating through the RS-232 port
        /// </summary>        
        public SerialPort comport = new SerialPort();

        /// <summary>
        /// Buffer with data
        /// </summary>        
        public string SerialBuffer = "";
        public UInt32 MAX_BUFFER_LEN = 10000;

        //Protocol delimeters
        #region Protocol delimeters
        const string DATAPROTOCOL_START = "[!";
        const string DATAPROTOCOL_END = "]";
        const string DATAPROTOCOL_SEPARATOR = ":";
        #endregion

        /// <summary>
        /// Fields for sensor data
        /// </summary>        
        #region SensorData Fields 
        public double ObjTemp = -100.0;
        public double ATemp = -100.0; 
       
        public double CloudIdx = -100.0;
        public double CloudIdxCorr = -100.0;

        public double BTemp = -100.0;
        public double Press = 0.0;

        public double Hum1 = -1.0;
        public double DTemp1 = -100.0;

        public double Hum2 = -1.0;
        public double DTemp2 = -100.0;

        public double Illum = -1.0;
        public int LumRes = 0;
        public int LumSens = 0;
        public int LumWTime = 0;

        public double Temp1 = -100.0;
        public double Temp2 = -100.0;

        public int Wet = 1024;
        public int RGC = 0;

        public double WindSpeed = 0.0;
        #endregion

        /// <summary>
        /// Sensor arrays
        /// </summary>        
        #region Sensor arrays
        public SensorElement[] SensorsArray = new SensorElement[20];
        public Dictionary<string, int> SensorsArrayHash = new Dictionary<string, int>();
        public Dictionary<string, int> SensorsArrayHashArduino = new Dictionary<string, int>();

        public string BaseTempName = "Temp1";
        public int BaseTempIdx = -1;
        public double BaseTempVal = -100;

        public Dictionary<string, SensorTypeEnum> SensorTypeEnum_Dict = new Dictionary<string, SensorTypeEnum> {
            { "Temp", SensorTypeEnum.Temp },
            { "Press", SensorTypeEnum.Press },
            { "Hum", SensorTypeEnum.Hum },
            { "Illum", SensorTypeEnum.Illum },
            { "Wet", SensorTypeEnum.Wet },
            { "RGC", SensorTypeEnum.RGC }
        };
        #endregion

        /// <summary>
        /// Boltwood data fields
        /// </summary>        
        #region Boltwood Data Fields 
        public UInt16 Bolt_Heater = 0;
        public double Bolt_DewPoint = 0.0;
        public RainFlag Bolt_RainFlag = RainFlag.rainFlagDry;
        public DateTime Bolt_RainFlag_LastDetected;
        public UInt16 Bolt_RainFlag_sinceLastDetected = 65535;
        public WetFlag Bolt_WetFlag = WetFlag.wetFlagDry;
        public DateTime Bolt_WetFlag_LastDetected;
        public UInt16 Bolt_WetFlag_sinceLastDetected = 65535;
        public UInt16 Bolt_SinceLastMeasure = 0;
        public CloudCond Bolt_CloudCond = CloudCond.cloudUnknown;
        public WindCond Bolt_WindCond = WindCond.windUnknown;
        public RainCond Bolt_RainCond = RainCond.rainUnknown;
        public DayCond Bolt_DaylighCond = DayCond.dayUnknown;
        public UInt16 Bolt_RoofCloseFlag= 0;
        public UInt16 Bolt_AlertFlag = 0;
        public string Bolt_date = "";
        public string Bolt_time = "";
        public double Bolt_now = 0;
        public DateTime LastMeasure;
        public string Web_date = "";

        /// <summary>
        /// Limits for classic cloud index values
        /// </summary>        
        public double CLOUDINDEX_CLEAR= 10;
        public double CLOUDINDEX_CLOUDY = 5;
        public double CLOUDINDEX_CLOUDY_BAD = -10;

        /// <summary>
        /// Limits for rain
        /// </summary>        
        public double RAININDEX_WET_LIMIT = 1010;
        public double RAININDEX_RAIN_LIMIT = 1000;
        public double RAININDEX_BAD_LIMIT = 1;

        /// <summary>
        /// Limits for daylight
        /// </summary>        
        public double DAYLIGHT_DARK_LIMIT = 0;
        public double DAYLIGHT_LIGHT_LIMIT = 50;

        /// <summary>
        /// Coefficients for AAG cloud index model
        /// </summary>        

        // Model for "This type of curve appears to work better during the cold season in cold climate regions where the sky temperature is lower than in mild climate regions."
        public double K1 = -7.0;
        public double K2 = 110.0;
        public double K3 = 46.0;
        public double K4 = 88.0;
        public double K5 = 88.0;
        public double K6 = 42.0;
        public double K7 = 25.0;

        // Usual coefficients
        //public double K1 = 33.0;
        //public double K2 = 0.0;
        //public double K3 = 4.0;
        //public double K4 = 100.0;
        //public double K5 = 100.0;
        //public double K6 = 0.0;
        //public double K7 = 0.0;

        //Last time data was read (WATCHDOG)
        public bool WatchDog = true;
        public UInt32 MAX_WAIT_DATA_INTERVAL = 100; //how long to wait before restart
        public DateTime LastTimeDataRead;
        #endregion

        /// <summary>
        /// Constructor ********************************************************************************
        /// </summary>        
        public WeatherStationSerial()
        {
            initSensorArray();
        }

        /// <summary>
        /// Set default values for sensor array
        /// </summary>     
        public void initSensorArray()
        {
            Int16 nI=-1;
            //MLX
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "ObjTemp";
            SensorsArray[nI].SensorType=SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled=true;
            SensorsArray[nI].SendToWebFlag=true;
            SensorsArray[nI].SendToNarodMon=false;
            SensorsArray[nI].SensorFormField = "txtObj";
            SensorsArray[nI].SensorArduinoField = "Obj";
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "ATemp";
            SensorsArray[nI].SensorType = SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = false;
            SensorsArray[nI].SensorFormField = "txtATemp";
            SensorsArray[nI].SensorArduinoField = "Amb";

            //BMP085
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "BTemp";
            SensorsArray[nI].SensorType = SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = false;
            SensorsArray[nI].SensorFormField = "txtBTemp";
            SensorsArray[nI].SensorArduinoField = "BTe";
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Press";
            SensorsArray[nI].SensorType = SensorTypeEnum.Press;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = true;
            SensorsArray[nI].SensorFormField = "txtPress";
            SensorsArray[nI].SensorArduinoField = "Pre";

            //DHT22_1
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Hum1";
            SensorsArray[nI].SensorType = SensorTypeEnum.Hum;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = false;
            SensorsArray[nI].SensorFormField = "txtHum1";
            SensorsArray[nI].SensorArduinoField = "DH1";
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "DTemp1";
            SensorsArray[nI].SensorType = SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = false;
            SensorsArray[nI].SensorFormField = "txtDTemp1";
            SensorsArray[nI].SensorArduinoField = "DT1";

            //DHT22_2
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Hum2";
            SensorsArray[nI].SensorType = SensorTypeEnum.Hum;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = false;
            SensorsArray[nI].SensorFormField = "txtHum2";
            SensorsArray[nI].SensorArduinoField = "DH2";
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "DTemp2";
            SensorsArray[nI].SensorType = SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = false;
            SensorsArray[nI].SensorFormField = "txtDTemp2";
            SensorsArray[nI].SensorArduinoField = "DT2";

            //Illuminance
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Illum";
            SensorsArray[nI].SensorType = SensorTypeEnum.Illum;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = true;
            SensorsArray[nI].SensorFormField = "txtIllum";
            SensorsArray[nI].SensorArduinoField = "Lum";

            //OneWire temp
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Temp1";
            SensorsArray[nI].SensorType = SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = true;
            SensorsArray[nI].SensorFormField = "txtTemp1";
            SensorsArray[nI].SensorArduinoField = "Te1";
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Temp2";
            SensorsArray[nI].SensorType = SensorTypeEnum.Temp;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = true;
            SensorsArray[nI].SensorFormField = "txtTemp2";
            SensorsArray[nI].SensorArduinoField = "Te2";

            //Wet sensor
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "Wet";
            SensorsArray[nI].SensorType = SensorTypeEnum.Wet;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = true;
            SensorsArray[nI].SensorFormField = "txtWet";
            SensorsArray[nI].SensorArduinoField = "Wet";

            //RGC sensor
            nI++;
            SensorsArray[nI] = new SensorElement();
            SensorsArray[nI].SensorName = "RGC";
            SensorsArray[nI].SensorType = SensorTypeEnum.RGC;
            SensorsArray[nI].Enabled = true;
            SensorsArray[nI].SendToWebFlag = true;
            SensorsArray[nI].SendToNarodMon = true;
            SensorsArray[nI].SensorFormField = "txtRGC";
            SensorsArray[nI].SensorArduinoField = "RGC";

            
            //Make hash tables
            int SensIdx=-1;
            SensorsArrayHash.Clear();
            SensorsArrayHashArduino.Clear();
            foreach (SensorElement DataSensor in SensorsArray)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    SensorsArrayHash.Add(DataSensor.SensorName, SensIdx);
                    SensorsArrayHashArduino.Add(DataSensor.SensorArduinoField, SensIdx);
                }
            }
/*
            public double WindSpeed = 0.0;
*/
        }

        /// <summary>
        /// Autosearch sensors 
        /// </summary>        
        public void searchSensors()
        {
            foreach (SensorElement DataSensor in SensorsArray)
            {
                if (DataSensor != null)
                {
                }
            }
        }

        /// <summary>
        /// Attach event handler to serial port object
        /// </summary>        
        public void eventHandler()
        {
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);
        }

        /// <summary>
        /// Setting port settings
        /// </summary>        
        private void setPortSettings()
        {
            // Set the port's settings
            comport.BaudRate = int.Parse("9600");
            comport.DataBits = int.Parse("8");
            comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            comport.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            comport.Handshake = Handshake.None;
            comport.PortName = PortName;
            comport.DtrEnable = true; //to reset Arduino on connect

            LastTimeDataRead = DateTime.Now;
        }

        /// <summary>
        /// This method is called to start reading data
        /// </summary>        
        public bool startReadData()
        {
            bool error = false;

            // If the port is not open
            if (!comport.IsOpen)
            {
                try
                {
                    setPortSettings();
                    eventHandler();

                    // Open the port
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

            }
            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// This method is called to stop reading data
        /// </summary>  
        public bool stopReadData()
        {
            bool error=false;
            
            // If the port is open, close it.
            if (comport.IsOpen)
            {
                try
                {
                    // Close the port
                    comport.Close();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

            }
            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Event handler for DataReceived event
        /// </summary>        
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!comport.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Read all the data waiting in the buffer
            string data = comport.ReadExisting();

            SerialBuffer += data;
            if (SerialBuffer.Length > MAX_BUFFER_LEN) 
            {
                SerialBuffer = SerialBuffer.Substring((Int16)(SerialBuffer.Length - MAX_BUFFER_LEN));
            }

            LastTimeDataRead = DateTime.Now;
        }
            
        /// <summary>
        /// External method to check when was the last communication
        /// </summary>        
        public UInt32 SinceLastDataReceived()
        {
            TimeSpan SinceLastRead = DateTime.Now.Subtract(LastTimeDataRead);
            UInt32 SinceLastRead_sec = (UInt32)Math.Round(SinceLastRead.TotalSeconds, 0);

            return SinceLastRead_sec;
        }

        /// <summary>
        /// External method to check when was last data received and restart communication (a la watchdog)
        /// </summary>        
        public void CheckIfDataReceiving()
        {
            if (SinceLastDataReceived() > MAX_WAIT_DATA_INTERVAL)
            {
                //restart connection
                Logging.Log("Waiting too long for data (" + MAX_WAIT_DATA_INTERVAL+"). Restarting connection to COM port...");
                stopReadData();
                System.Threading.Thread.Sleep(2000);
                startReadData();
            }
        }

        /// <summary>
        /// External interface to check if communication was started
        /// </summary>        
        public bool IsOpen()
        {
            return comport.IsOpen;
        }

        /// <summary>
        /// Method to stop communications
        /// </summary>        
        public void Close()
        {
            comport.Close();
        }

        /// <summary>
        /// Main method to parse received data
        /// </summary>        
        public void ParseData(string txtBuffer)
        {
            string aLine = null;
            StringReader strReader = new StringReader(txtBuffer);
            while (true)
            {
                aLine = strReader.ReadLine();
                if (aLine != null)
                {
                    //IS THIS DATA PROTOCOL LINE?
                    if (aLine.Trim().StartsWith(DATAPROTOCOL_START))
                    {

                        int tagStartPosition=DATAPROTOCOL_START.Length;
                        int tagEndPosition = aLine.IndexOf(DATAPROTOCOL_SEPARATOR); 
                        int valEndPosition = aLine.IndexOf(DATAPROTOCOL_END);

                        // is this a full line (with TAG and DATA)?
                        if (tagEndPosition >= 0 && valEndPosition >= 0)
                        {
                            string tagName = aLine.Substring(tagStartPosition, tagEndPosition - tagStartPosition);
                            string tagValue_raw = aLine.Substring(tagEndPosition + 1, valEndPosition - tagEndPosition - 1);

                            char Separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                            char BadSeparator='.';
                            if (Separator == '.') { BadSeparator = ','; }
                            if (Separator == ',') { BadSeparator = '.'; }

                            string tagValue = tagValue_raw.Replace(BadSeparator, Separator); 

                            if (tagName == "Obj")
                            {
                                ObjTemp= Convert.ToDouble(tagValue);
                                if (ObjTemp>-85 && Temp1 > -85)
                                {
                                    CloudIdx = Temp1 - ObjTemp;
                                    CloudIdxCorr = CloudIndexCorr(ObjTemp, Temp1);
                                }
                            }
                            else if (tagName == "Amb")
                            {
                                ATemp = Convert.ToDouble(tagValue);
                            }
                            else if (tagName == "BTe")
                            {
                                BTemp = Convert.ToDouble(tagValue);

                                //Dolph edition
                                Temp1 = BTemp;
                                //
                            }
                            else if (tagName == "Pre")
                            {
                                if (CheckData(Convert.ToDouble(tagValue), SensorTypeEnum.Press))
                                {
                                    Press = Convert.ToDouble(tagValue);
                                }
                            }
                            else if (tagName == "DT1")
                            {
                                DTemp1 = Convert.ToDouble(tagValue);
                            }
                            else if (tagName == "DH1")
                            {
                                Hum1 = Convert.ToDouble(tagValue);
                            }
                            else if (tagName == "DT2")
                            {
                                DTemp2 = Convert.ToDouble(tagValue);
                            }
                            else if (tagName == "DH2")
                            {
                                Hum2 = Convert.ToDouble(tagValue);
                            }
                            else if (tagName == "Lum")
                            {
                                Illum = Convert.ToDouble(tagValue);
                            }
                            else if (tagName == "Lur")
                            {
                                LumRes = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "Lus")
                            {
                                LumSens = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "Luw")
                            {
                                LumWTime = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "Te1")
                            {
                                if (CheckData(Convert.ToDouble(tagValue), SensorTypeEnum.Temp))
                                {
                                    Temp1 = Convert.ToDouble(tagValue);
                                }
                                //Dolph edition
                                Temp1 = BTemp;
                                //
                            }
                            else if (tagName == "Te2")
                            {
                                if (CheckData(Convert.ToDouble(tagValue), SensorTypeEnum.Temp))
                                {
                                    Temp2 = Convert.ToDouble(tagValue);
                                }
                            }
                            else if (tagName == "Wet")
                            {
                                Wet = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "RGC")
                            {
                                RGC = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "!be")
                            {
                            }
                            else if (tagName == "!en")
                            {

                                //Сохранение Boltwood файла
                                Logging.WirteBoltwoodData(getBoltwoodString());

                                LastMeasure = DateTime.Now;

                                //Сохранение CSV файла
                                Logging.LogData(getCSVline());

                                /*
                                  //Отправка Web запроса
                                    Web_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                    string queryst = "date=" + Web_date + "&ot=" + Convert.ToString(ObjTemp) + "&at=" + Convert.ToString(ATemp) + "&bp=" + Convert.ToString(Press) + "&bt=" + Convert.ToString(BTemp) + "&dh=" + Convert.ToString(Hum1) + "&dt=" + Convert.ToString(DTemp1) +
                                        "&dh2=" + Convert.ToString(Hum2) + "&dt2=" + Convert.ToString(DTemp2) + "&bhv=" + Convert.ToString(Illum) + "&bhs=" + Convert.ToString(LumSens) + "&bhr=" + Convert.ToString(LumRes) +
                                        "&bhw=" + Convert.ToString(LumWTime) + "&owt1=" + Convert.ToString(Temp1) + "&owt2=" + Convert.ToString(Temp2) + "&wsv=" + Convert.ToString(Wet) + "&rgc=" + Convert.ToString(RGC);

                                    if (Press != 333.33)
                                    {
                                        WebServices.sendToServer(queryst);
                                    }
                                 */
                            }
                        
                        }
                        else {
                            //write error log
                            Logging.Log("Incomplete protocol line: " + aLine);


                        }
                    }
                }
                else
                {
                    break;
                }
            }
        
        }


        /// <summary>
        /// Upgraded main method to parse received data
        /// Based on SensorArray
        /// </summary>        
        public void ParseData2(string txtBuffer)
        {
            string aLine = null;
            StringReader strReader = new StringReader(txtBuffer);
            while (true)
            {
                aLine = strReader.ReadLine();
                if (aLine != null)
                {
                    //IS THIS DATA PROTOCOL LINE?
                    if (aLine.Trim().StartsWith(DATAPROTOCOL_START))
                    {

                        int tagStartPosition = DATAPROTOCOL_START.Length;
                        int tagEndPosition = aLine.IndexOf(DATAPROTOCOL_SEPARATOR);
                        int valEndPosition = aLine.IndexOf(DATAPROTOCOL_END);

                        // is this a full line (with TAG and DATA)?
                        if (tagEndPosition >= 0 && valEndPosition >= 0)
                        {
                            string tagName = aLine.Substring(tagStartPosition, tagEndPosition - tagStartPosition);
                            string tagValue_raw = aLine.Substring(tagEndPosition + 1, valEndPosition - tagEndPosition - 1);

                            char Separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                            char BadSeparator = '.';
                            if (Separator == '.') { BadSeparator = ','; }
                            if (Separator == ',') { BadSeparator = '.'; }

                            string tagValue = tagValue_raw.Replace(BadSeparator, Separator);


                            //Присвоить прочитанное значение нужному сенсору
                            int SensIdx = -1;
                            foreach (SensorElement DataSensor in SensorsArray)
                            {
                                SensIdx++;
                                if (DataSensor != null)
                                {
                                    if (DataSensor.SensorArduinoField == tagName)
                                    {
                                        if (CheckData(Convert.ToDouble(tagValue), DataSensor.SensorType))
                                        {
                                            SensorsArray[SensIdx].LastValue = Convert.ToDouble(tagValue);
                                            SensorsArray[SensIdx].LastValueReadTime = DateTime.Now;
                                            SensorsArray[SensIdx].ValuesCount++;

                                            BaseTempVal = SensorsArray[BaseTempIdx].LastValue;
                                        }
                                    }
                                }
                            }

                            //Расчетные поля
                            if (tagName == "Obj")
                            {
                                CloudIdx = BaseTempVal - ObjTemp;
                                CloudIdxCorr = CloudIndexCorr(ObjTemp, BaseTempVal);
                            }
                            else if (tagName == "Lur")
                            {
                                LumRes = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "Lus")
                            {
                                LumSens = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "Luw")
                            {
                                LumWTime = Convert.ToInt16(tagValue);
                            }
                            else if (tagName == "!be")
                            {
                            }
                            else if (tagName == "!en")
                            {

                                //Сохранение Boltwood файла
                                Logging.WirteBoltwoodData(getBoltwoodString());

                                LastMeasure = DateTime.Now;

                                //Сохранение CSV файла
                                Logging.LogData(getCSVline());

                                /*
                                  //Отправка Web запроса
                                    Web_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                    string queryst = "date=" + Web_date + "&ot=" + Convert.ToString(ObjTemp) + "&at=" + Convert.ToString(ATemp) + "&bp=" + Convert.ToString(Press) + "&bt=" + Convert.ToString(BTemp) + "&dh=" + Convert.ToString(Hum1) + "&dt=" + Convert.ToString(DTemp1) +
                                        "&dh2=" + Convert.ToString(Hum2) + "&dt2=" + Convert.ToString(DTemp2) + "&bhv=" + Convert.ToString(Illum) + "&bhs=" + Convert.ToString(LumSens) + "&bhr=" + Convert.ToString(LumRes) +
                                        "&bhw=" + Convert.ToString(LumWTime) + "&owt1=" + Convert.ToString(Temp1) + "&owt2=" + Convert.ToString(Temp2) + "&wsv=" + Convert.ToString(Wet) + "&rgc=" + Convert.ToString(RGC);

                                    if (Press != 333.33)
                                    {
                                        WebServices.sendToServer(queryst);
                                    }
                                 */
                            }

                        }
                        else
                        {
                            //write error log
                            Logging.Log("Incomplete protocol line: " + aLine);
                        }
                    }
                }
                else
                {
                    break;
                }
            }

        }

        /// <summary>
        /// Method to generate contents of Boltwood format file
        /// </summary>   
        public string getBoltwoodString()
        {
            //Calculations for boltwood
            Bolt_DewPoint = DewPoint(Temp1, Hum1);

            //Bolt_Heater
            //not implemented yet

            //Boltwood date time fields
            Bolt_date = DateTime.Now.ToString("yyyy-MM-dd");
            Bolt_time = DateTime.Now.ToString("HH:mm:ss.ff");
            Bolt_now = DateTime.Now.ToOADate();
            TimeSpan MeasureInterval = DateTime.Now.Subtract(LastMeasure);
            Bolt_SinceLastMeasure = (ushort)Math.Round(MeasureInterval.TotalSeconds, 0);

            //Cloud condition
            CloudIdx = Temp1 - ObjTemp;
            if (CloudIdx > CLOUDINDEX_CLEAR) { Bolt_CloudCond = CloudCond.cloudClear; }
            else if (CloudIdx > CLOUDINDEX_CLOUDY) { Bolt_CloudCond = CloudCond.cloudCloudy; }
            else if (CloudIdx >= CLOUDINDEX_CLOUDY_BAD) { Bolt_CloudCond = CloudCond.cloudVeryCloudy; }

            //Bolt_WindCond: windCalm, windWindy, windVeryWindy
            //not implemented yet
            Bolt_WindCond = WindCond.windUnknown;

            TimeSpan MeasureIntervalWF = DateTime.Now.Subtract(Bolt_WetFlag_LastDetected);
            Bolt_WetFlag_sinceLastDetected = (ushort)Math.Round(MeasureIntervalWF.TotalSeconds, 0);
            TimeSpan MeasureIntervalRF = DateTime.Now.Subtract(Bolt_RainFlag_LastDetected);
            Bolt_RainFlag_sinceLastDetected = (ushort)Math.Round(MeasureIntervalRF.TotalSeconds, 0);

            //Rain condition & Bolt_RainFlag + Bolt_WetFlag
            if (Wet > RAININDEX_WET_LIMIT)
            {
                //DRY
                Bolt_RainCond = RainCond.rainDry;
                if (Bolt_RainFlag_sinceLastDetected > 0 && Bolt_RainFlag_sinceLastDetected < 60) { Bolt_RainFlag = RainFlag.rainFlagLastminute; }
                else { Bolt_RainFlag = RainFlag.rainFlagDry; }

                if (Bolt_WetFlag_sinceLastDetected > 0 && Bolt_WetFlag_sinceLastDetected < 60) { Bolt_WetFlag = WetFlag.wetFlagLastminute; }
                else { Bolt_WetFlag = WetFlag.wetFlagDry; }
            }
            else if (Wet > RAININDEX_RAIN_LIMIT)
            {
                //WET
                if (Bolt_CloudCond == CloudCond.cloudCloudy || Bolt_CloudCond == CloudCond.cloudVeryCloudy)
                {
                    Bolt_RainCond = RainCond.rainWet;
                    Bolt_WetFlag = WetFlag.wetFlagRightnow;
                    Bolt_WetFlag_LastDetected = DateTime.Now;
                }
                else
                {
                    //DRY - if not cloudy - don't set as wet
                    Bolt_RainCond = RainCond.rainDry;
                    if (Bolt_RainFlag_sinceLastDetected > 0 && Bolt_RainFlag_sinceLastDetected < 60) { Bolt_RainFlag = RainFlag.rainFlagLastminute; }
                    else { Bolt_RainFlag = RainFlag.rainFlagDry; }

                    if (Bolt_WetFlag_sinceLastDetected > 0 && Bolt_WetFlag_sinceLastDetected < 60) { Bolt_WetFlag = WetFlag.wetFlagLastminute; }
                    else { Bolt_WetFlag = WetFlag.wetFlagDry; }
                }
            }
            else if (Wet >= RAININDEX_BAD_LIMIT)
            {
                //RAIN
                Bolt_RainCond = RainCond.rainRain;

                Bolt_RainFlag = RainFlag.rainFlagRightnow;
                Bolt_RainFlag_LastDetected = DateTime.Now;

                Bolt_WetFlag = WetFlag.wetFlagRightnow;
                Bolt_WetFlag_LastDetected = DateTime.Now;
            }

            //Daylight condition
            if (Illum > DAYLIGHT_LIGHT_LIMIT) { Bolt_DaylighCond = DayCond.dayVeryLight; }
            else if (Illum > DAYLIGHT_DARK_LIMIT) { Bolt_DaylighCond = DayCond.dayLight; }
            else if (Illum >= 0) { Bolt_DaylighCond = DayCond.dayDark; }

            //Bolt_RoofCloseFlag: roof close, =0 not requested, =1 if roof close was requested on this cycle 
            //not implemented yet

            //Bolt_AlertFlag: alert, =0 when not alerting, =1 when alerting 
            //not implemented yet

            //Making boltwood string
            string bold_st = String.Format("{0,10} {1,11} C K {2,6:N1} {3,6:N1} {4,6:N1} {5,6:N1} {6,3:N0} {7,6:N1} {8,3:N0} {9,1:N0} {10,1:N0} {11,5:N0} {12,12:F5} {13,1:N0} {14,1:N0} {15,1:N0} {16,1:N0} {17,1:N0} {18,1:N0}",
                Bolt_date, Bolt_time, ObjTemp, Temp1, ATemp, WindSpeed, Hum1, Bolt_DewPoint, Bolt_Heater,
                (int)Bolt_RainFlag, (int)Bolt_WetFlag, Bolt_SinceLastMeasure.ToString("00000"), Bolt_now.ToString("000000.#####"),
                (int)Bolt_CloudCond, (int)Bolt_WindCond, (int)Bolt_RainCond, (int)Bolt_DaylighCond, (int)Bolt_RoofCloseFlag, (int)Bolt_AlertFlag);

            return bold_st;
        }

        /// <summary>
        /// Method to generate CSV line for datalog file
        /// </summary>   
        public string getCSVline()
        {
            //Супер CSV файла
            string st = Convert.ToString(ObjTemp) + Logging.CSVseparator + Convert.ToString(ATemp) + Logging.CSVseparator + Convert.ToString(BTemp) + Logging.CSVseparator + Convert.ToString(Press) + Logging.CSVseparator
                + Convert.ToString(DTemp1) + Logging.CSVseparator + Convert.ToString(Hum1) + Logging.CSVseparator + Convert.ToString(DTemp2) + Logging.CSVseparator + Convert.ToString(Hum2) + Logging.CSVseparator +
                Convert.ToString(Illum) + Logging.CSVseparator + Convert.ToString(LumRes) + Logging.CSVseparator + Convert.ToString(LumSens) + Logging.CSVseparator + Convert.ToString(LumWTime) + Logging.CSVseparator + Convert.ToString(Temp1) + Logging.CSVseparator +
                Convert.ToString(Temp2) + Logging.CSVseparator + Convert.ToString(Wet) + Logging.CSVseparator + Convert.ToString(RGC) + Logging.CSVseparator;
            
            return st;
        }
        
        /// <summary>
        /// Method to check data validity for different sensors type
        /// </summary>      
        public bool CheckData(double TagVal, SensorTypeEnum checkDataType)
        {
            switch (checkDataType)
            {
                case SensorTypeEnum.Temp:
                    if (TagVal < -80 || TagVal > 80)
                        return false;
                    break;
                case SensorTypeEnum.Hum:
                    if (TagVal <= 0 || TagVal >= 100)
                        return false;
                    break;
                case SensorTypeEnum.Press:
                    if (TagVal <= 0 || TagVal >= 800)
                        return false;
                    break;
                case SensorTypeEnum.Illum:
                    if (TagVal < 0 || TagVal >= 100000)
                        return false;
                    break;
                case SensorTypeEnum.Wet:
                    if (TagVal <= 0 || TagVal >= 1024)
                        return false;
                    break;
                case SensorTypeEnum.RGC:
                    if (TagVal <= 0 || TagVal >= 1000) //maximum value I have ever seen was 237
                        return false;
                    break;
            }
            return true;
        }

        /// <summary>
        /// Calculates Cloud Index by AAG_CloudWatcher methodology
        /// </summary>
        /// <param name="Tsky">Measured sky temperature</param>
        /// <param name="Tamb">Ambient temperature</param>
        /// <returns>Corrected sky temperature which is used as index</returns>
        public double CloudIndexCorr(double Tsky, double Tamb)
        {
            double T67 = 0.0;

            if (Math.Abs((K2 / 10 - Tamb)) < 1)
            {
                T67 = Math.Sign(K6) * Math.Sign(Tamb - K2 / 10) * Math.Abs((K2 / 10 - Tamb));
            }
            else {
                T67 = K6/10 * Math.Sign(Tamb - K2 / 10) * (Math.Log(Math.Abs((K2 / 10 - Tamb)))/Math.Log(10) + K7/100);
            }

            double Td = (K1 / 100) * (Temp1 - K2 / 10) + (K3 / 100) * Math.Pow (Math.Exp(K4 / 1000 * Temp1), (K5 / 100)) + T67;

            double Tcorr = Tsky - Td;

            return Tcorr;
        }

        /// <summary>
        /// Calculates dew point temperature (very good approximation)
        /// </summary>
        /// <param name="Temp">Ambient temperature</param>
        /// <param name="Hum">Current humidity</param>
        /// <returns></returns>
        public double DewPoint(double Temp, double Hum)
        {
            double a = 17.271;
            double b = 237.7;
            double te = (a * Temp) / (b + Temp) + Math.Log(Hum / 100);
            double Td = (b * te) / (a - te);

            return Td;

        }
    
    }
}
