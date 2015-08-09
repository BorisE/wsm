using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

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
    public enum WindCond { windUnknown = 0, windCalm=1, windWindy=2, windVeryWindy=3 }
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
        public string SensorName="";        //Sensor Name
        public SensorTypeEnum SensorType;   //Sensor Type
        public bool Enabled = true;         //Sensor Enabled flag
        public bool SendToWebFlag=true;
        public bool SendToNarodMon=false;
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
                startIdx = ValuesLastFiveMin.Count()-1;
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

    public enum CloudSensorModel { Classic=1, AAG=2}

#endregion

namespace WeatherStation
{
    /// <summary>
    /// Class for working with Arduino piece of hardware (through SERIAL PORT)
    /// </summary>
    public class WeatherStationSerial
    {

        /// <summary>
        /// Command dictionary for interpretator
        /// </summary>
        public CommandInterpretator CommandParser;
        
        /// <summary>
        /// Serial Port name
        /// </summary>        
        public string PortName = "COM5";
        public bool UseFileEmulation = false;
        public string _WORK_WITH_FILE_SERIAL = "File Emulation"; //CONSTANT, CAN BE SET FROM EXTERNAL PARAMETERS
        public bool UseSocketRead = false;
        
        /// <summary>
        /// The SerialPort object, which is used for communicating through the RS-232 port
        /// </summary>        
        public SerialPort comport = new SerialPort();

        /// <summary>
        /// Buffer with data
        /// </summary>        
        public string SerialBuffer = "";
        public UInt32 MAX_BUFFER_LEN = 10000;

        /// <summary>
        /// Link to Socket class
        /// </summary>
        public SocketServerClass SocketServer;
        public string SerialBufferFromSocket = "";//serial buffer from socket server should be put here by external process

        /// <summary>
        /// Simulation mode vars
        /// </summary>
        public bool UseSimulation = false;
        public string SerialBufferFullSim = "";
        public int simBufferReadPos = 0;

        //Protocol delimeters
        #region Protocol delimeters
        const string DATAPROTOCOL_START = "[!";
        const string DATAPROTOCOL_END = "]";
        const string DATAPROTOCOL_SEPARATOR = ":";
        #endregion

        /// <summary>
        /// OBSOLETE Fields for sensor data
        /// </summary>        
        #region Obsolete SensorData Fields 
        public double ObjTemp_ = -100.0;
        public double ATemp_ = -100.0; 

        public double BTemp_ = -100.0;
        public double Press_ = 0.0;

        public double Hum1_ = -1.0;
        public double DTemp1_ = -100.0;

        public double Hum2_ = -1.0;
        public double DTemp2_ = -100.0;

        public double Illum_ = -1.0;


        public double Temp1_ = -100.0;
        public double Temp2_ = -100.0;

        public int Wet_ = 1025;
        #endregion

        /// <summary>
        /// Sensor arrays and different settings
        /// </summary>        
        #region Sensor arrays
        public Dictionary<String, SensorElement> SensorsList = new Dictionary<String,SensorElement>();
        public Dictionary<string, int> SensorsArrayHashArduino = new Dictionary<string, int>();

        public string BaseTempName = "Temp1";
        public int BaseTempIdx___ = -1;
        public double BaseTempVal = -100;

        public Dictionary<string, SensorTypeEnum> SensorTypeEnum_Dict = new Dictionary<string, SensorTypeEnum> {
            { "Temp", SensorTypeEnum.Temp },
            { "Press", SensorTypeEnum.Press },
            { "Hum", SensorTypeEnum.Hum },
            { "Illum", SensorTypeEnum.Illum },
            { "Wet", SensorTypeEnum.Wet },
            { "RGC", SensorTypeEnum.RGC },
            { "WSp", SensorTypeEnum.WSp },
            { "Relay", SensorTypeEnum.Relay }
        };
        #endregion

        /// <summary>
        /// Sensors vars and misc settings
        /// </summary>        
        #region Different sensor settings
        public double CloudIdx = -100.0; // Classic model
        public double CloudIdxAAG = -100.0; // AAG model
        
        public double IllumVal = -1.0;
        public double ObjTempVal = -100.0;
        public double SensorCaseTempVal = -100.0;
        public double HumidityVal = -1.0;

        public double PressureVal = 0.0;

        public double HeightAboveSea = 0.0;
        public double PressureNormalVal = 0.0;

        public int LumRes = 0;
        public int LumSens = 0;
        public int LumWTime = 0;
        
        public int WindSensorVal = 0;
        public double WindSpeedVal = 0;

        public Int32 WS_Calibraion_ZeroSpeedAnalogValue = 83;
        public double WS_Calibraion_PartialMultiplier = 1.6;
        public double WS_Calibraion_MaxspeedMultiplier = 32.4;

        public bool WS_AutoCalibrateFlag = false;

        public double autoCalWS_maxPassedFromHit = 300;
        public Int32 WS_HitCount_Threshold = 3;
        //public double autoCalWS_minPassedFromSet = 10;
        //public double autoCalWS_maxPassedFromSet = 600;
        private DateTime WS_MinValue_LastHit = new DateTime(2010, 01, 01);
        private Int32 WS_MinValue_HitCount = 0;
        private double LastMinValue = Double.MaxValue;


        public int WetVal = 1025;
        public int RGCVal = 0;
        public double RainIntensityVal = 0.0;

        public double RGC_Cumulative = 0;
        public double RGC_Cumulative_mm = 0;
        public double RGC_ONETICK_VALUE = 0.01; //number of mm of precipitation per 1 count (tick)
        public DateTime RGC_Cumulative_LastReset;

        public bool AverageDataFlag = false;

        public int MeasureCycleLen = 14530;

        public string SketchVersion = "";
        public string SketchVersionDate = "";

        public WetSensorsMode RainConditionMode = WetSensorsMode.wetSensBoth; //Rain condition determining
        public Dictionary<string, WetSensorsMode> WetSensorsModeDictionary = new Dictionary<string, WetSensorsMode>(){
                {"Use both", WetSensorsMode.wetSensBoth     },
                {"Wet only", WetSensorsMode.wetSensWetOnly  },
                {"RGC only", WetSensorsMode.wetSensRGCOnly  }
          };

        public bool RainLastMinute_Flag = false;
            public bool RainLastMinute_RGC_Flag = false;
            public RainCond RainLastMinute_WetS_FlagC = RainCond.rainUnknown;
        public bool RainNow_Flag = false;
            public bool RainNow_RGC_Flag = false;
            public RainCond RainNow_WetS_FlagC = RainCond.rainUnknown;

        /// Array wich holds 5 min average for cloud index every fivth minute of last hour (0:05, 0:10, 0:15, 0:20 etc)
        private const int SKYSENSOR_HISTORY_LENGTH = 12;
        public List<double> SkyIndex5min = new List<double>(); 
        private int SkyIndexAlreadyAddedMinute = -1;
        #endregion

        /// <summary>
        /// Relay and Heating settings
        /// </summary>
        #region Relay and Heating settings
        public int Relay1 = 0;
        public DateTime LastHeating1SwitchOn =  new DateTime(2014, 1, 1, 0, 0, 1), LastHeating1SwitchOff = new DateTime(2014, 1, 1, 0, 0, 1);
        public int SinceLastHeating1;
        public bool CloudSensorNeedHeatingFlag = false;
        public int Heating1Off_SecondsPassed=0, Heating1On_SecondsPassed = 0;

        public int Relay2 = 0;
        public DateTime LastHeating2SwitchOn = new DateTime(2014, 1, 1, 0, 0, 1), LastHeating2SwitchOff = new DateTime(2014, 1, 1, 0, 0, 1);
        public int SinceLastHeating2;
        public int Heating2Off_SecondsPassed = 0, Heating2On_SecondsPassed = 0;
        

        public double HEATER_CLOUDINDEX_MIN = 14.0;
        public double HEATER_CLOUDINDEX_MAX = 19.0;
        public int CS_NEEDHEATING_LOOKBACK_CYCLES = 5; //5 cycles per 5 min ~ 25 min
        public double CS_NEEDHEATING_MINDELTA = 0.0;
        public double CS_NEEDHEATING_MAXDELTA = 2.0;
        
        public int HEATER_CS_PAUSE = 1800;

        public Dictionary<String, ArduinoSettingsClass> ArduinoSettings = new Dictionary<String, ArduinoSettingsClass>();
        
        public double HEATER_MAX_TEMPERATURE_DELTA = 55.0;
        public int HEATER_MAX_DURATION = 600;
        public double HEATER_WET_START_THRESHOLD = 1010;
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
        #endregion

        /// <summary>
        /// Limits for classic cloud index values
        /// </summary>        
        #region Clolud sensor limits

        public CloudSensorModel CLOUDMODEL = CloudSensorModel.Classic;
        
        public double CLOUDINDEX_CLEAR = 10;
        public double CLOUDINDEX_CLOUDY = 5;
        public double CLOUDINDEX_CLOUDY_BAD = -10;

        public double CLOUDINDEXAAG_CLEAR = 5;
        public double CLOUDINDEXAAG_CLOUDY = 0;
        public double CLOUDINDEXAAG_CLOUDY_BAD = -20;
        
        #endregion

        /// <summary>
        /// Limits for rain
        /// </summary>        
        #region Wet sensor limits
        public double RAININDEX_WET_LIMIT = 1005;
        public double RAININDEX_RAIN_LIMIT = 980;
        public double RAININDEX_BAD_LIMIT = 1;
        #endregion

        /// <summary>
        /// Limits for daylight
        /// </summary>        
        #region Daylight sensor limits
        public double DAYLIGHT_DARK_LIMIT = 0;
        public double DAYLIGHT_LIGHT_LIMIT = 50;
        #endregion

        /// <summary>
        /// Limits for wins speed
        /// </summary>        
        #region Windspeed sensor limits
        public double WINDSPEED_WINDY = 15 / 3.6; //15 kph - 4.2 m/s
        public double WINDSPEED_VERYWINDY = 30 / 3.6; //30 kph - 8.3 m/s
        #endregion
        
        /// <summary>
        /// Coefficients for AAG cloud index model
        /// </summary>        
        #region Coefficients for AAG cloud index model
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
        #endregion

        /// <summary>
        /// Last time data was read (WATCHDOG)
        /// </summary>        
        #region Internal WATCHDOG
        public bool WatchDog = true;
        public UInt32 MAX_WAIT_DATA_INTERVAL = 100; //how long to wait before restart
        public DateTime LastTimeDataRead;
        #endregion

        /// <summary>
        /// Constructor ********************************************************************************
        /// </summary>        
        public WeatherStationSerial(MainForm MF=null)
        {
            //if calling with parameter - using graphical form for displaying serial data
            //if (MF != null) ParentMainForm = MF; 
            
            initSensorList();

            CommandParser = new CommandInterpretator();
            InitComandInterpretator();

        }

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


        /// <summary>
        /// Attach event handler to serial port object
        /// </summary>        
        public void eventHandler()
        {
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);
            Logging.Log("Comport DataReceived event handler was set", 2);

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

            Logging.Log("Comport settings were set", 2);

        }

        /// <summary>
        /// This method is called to start reading data
        /// </summary>        
        public bool startReadData()
        {
            bool error = false;
            Logging.Log("startReadData command issued", 2);

            // If the port is not open
            if (!comport.IsOpen)
            {

                if (UseSocketRead)
                {
                    //nothing much to check...
                    sendParametersToSerial();
                    queryParametersFromSerial();
                    if (!error) Logging.Log("Socket data read was opened", 2);
                }
                else if (UseFileEmulation)
                {
                    error=!SerialFromFile.Open();
                    sendParametersToSerial();
                    queryParametersFromSerial();
                    if (!error) Logging.Log("FileEmulation was opened", 2);
                }
                else
                {
                    try
                    {
                        setPortSettings();
                        eventHandler();

                        // Open the port
                        comport.Open();
                        Logging.Log("Comport was opened", 2);

                        sendParametersToSerial();
                        queryParametersFromSerial();
                    }
                    catch (UnauthorizedAccessException) { error = true; }
                    catch (IOException) { error = true; }
                    catch (ArgumentException) { error = true; }
                }
            }
            if (error)
            {
                Logging.Log("Couldn't open comport", 2);
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
            Logging.Log("stopReadData command issued", 2);
            
            // If the port is open, close it.
            if (UseFileEmulation)
            {
                error = SerialFromFile.Close();
                if (!error) Logging.Log("FileEmulation was closed", 2);
            }
            else if (UseSocketRead)
            {
                //if it was socket data - do nothing - data could be receiving even in stop mode (I think for now at least...)
                //error = !.Close();
                error = false;
                if (!error) Logging.Log("Socket read command was received, but no need to stop in this mode", 2);
            }
            else
            {
                if (comport.IsOpen)
                {
                    try
                    {
                        // Close the port
                        comport.Close();
                        Logging.Log("Comport was closed", 2);
                    }
                    catch (UnauthorizedAccessException) { error = true; }
                    catch (IOException) { error = true; }
                    catch (ArgumentException) { error = true; }
                }
            }
            if (error)
            {
                Logging.Log("Couldn't close comport", 2);
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
            //string[] lines = SerialBuffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            /// if using with VISUAL INTERFACE
            //if (ParentMainForm!=null) ParentMainForm.LogForm.AppendLogText(data);
            
            //Log serial data if needed
            if (Logging.SerialLogFileFlag) Logging.LogSerial(data);

            if (SerialBuffer.Length > MAX_BUFFER_LEN) 
            {
                SerialBuffer = SerialBuffer.Substring((Int16)(SerialBuffer.Length - MAX_BUFFER_LEN));
                Logging.Log("SerialBuffer was cut to " + MAX_BUFFER_LEN, 3);
            }

            Logging.Log("SerialBuffer data was received", 3);
            LastTimeDataRead = DateTime.Now;
        }

        /// <summary>
        /// Simulated read in arbitrary portions from previously formed SerialBufferFullSim data into main Serial Buffer
        /// Full simulation! :)
        /// </summary>
        /// <returns></returns>
        public bool port_DataReceived_simulated()
        {
            if (simBufferReadPos < SerialBufferFullSim.Length)
            {
                // Read arbitrary nyum from predefined buffer
                Random rnd = new Random();
                int BuffReadLen = rnd.Next(4, 100);
                if ((simBufferReadPos + BuffReadLen) > SerialBufferFullSim.Length)
                {
                    BuffReadLen = SerialBufferFullSim.Length - simBufferReadPos;
                }
                string data = SerialBufferFullSim.Substring(simBufferReadPos, BuffReadLen);
                simBufferReadPos += BuffReadLen;

                SerialBuffer += data;

                //string[] lines = SerialBuffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                //Log serial data if needed
                if (Logging.SerialLogFileFlag) Logging.LogSerial(data);

                if (SerialBuffer.Length > MAX_BUFFER_LEN)
                {
                    SerialBuffer = SerialBuffer.Substring((Int16)(SerialBuffer.Length - MAX_BUFFER_LEN));
                    Logging.Log("SerialBuffer was cut to " + MAX_BUFFER_LEN, 3);
                }

                Logging.Log("SerialBuffer data was received", 3);
                LastTimeDataRead = DateTime.Now;
                
                return false;
            }
            else
            {
                //read complete
                return true;
            }
        }

        /// <summary>
        /// Wrapper for writing data to serial port
        /// </summary>
        /// <param name="CommandSt">string with command, which should be sent to Arduino</param>
        public bool WriteSerialData(string CommandSt)
        {
            string FullCommandSt = "(" + CommandSt + ")";
            bool error = false;


            if (UseSocketRead)
            {
                //error = !.WriteData(FullCommandSt);
                //if (!error) Logging.Log("Command to Serial File Emulation was sent: " + FullCommandSt);
                error = false;
                Logging.Log("Command to socket client isn't implemented yet: " + FullCommandSt);
                return !error;
            }
            else if (UseFileEmulation)
            {
                error = !SerialFromFile.WriteData(FullCommandSt);
                if (!error) Logging.Log("Command to Serial File Emulation was sent: " + FullCommandSt);
                return !error;
            }
            else
            {
                try
                {
                    comport.WriteLine(FullCommandSt);
                    Logging.Log("Command to serial sent: " + FullCommandSt);
                    return true;
                }
                catch
                {
                    Logging.Log("Error writing command " + FullCommandSt + " to serial");
                    return false;
                }
            }
        }

        /// <summary>
        /// Send current settings to Arduino. Overload with returning sent command string
        /// </summary>
        /// <returns>true - if all data was sent</returns>
        public bool sendParametersToSerial(out string CommandStr)
        {
            Logging.Log("sendParametersToSerial(overload) enter", 3);
            
            String St = ""; CommandStr = "";
            St = "!TD:" + Convert.ToString(HEATER_MAX_TEMPERATURE_DELTA);
            CommandStr += "out: " + St;
            bool retval1 = WriteSerialData(St);
            St = "!WT:" + Convert.ToString(HEATER_WET_START_THRESHOLD);
            CommandStr += "out: " + St;
            bool retval2 = WriteSerialData(St);
            St = "!RT:" + Convert.ToString(HEATER_MAX_DURATION);
            CommandStr += "out: " + St;
            bool retval3 = WriteSerialData(St);

            Logging.Log("sendParametersToSerial (overload) was sent", 3);
            
            return (retval1 && retval2 && retval3);
        }

        /// <summary>
        /// Send current settings to Arduino
        /// </summary>
        /// <returns>true - if all data was sent</returns>
        public bool sendParametersToSerial()
        {
            Logging.Log("sendParametersToSerial enter", 3);

            String St = ""; string StAll = "";
            St = "!TD:" + Convert.ToString(HEATER_MAX_TEMPERATURE_DELTA); //Earlier: + ")" + Environment.NewLine
            StAll += St;
            bool retval1 = WriteSerialData(St);
            St = "!WT:" + Convert.ToString(HEATER_WET_START_THRESHOLD) ;
            StAll += St;
            bool retval2 = WriteSerialData(St);
            St = "!RT:" + Convert.ToString(HEATER_MAX_DURATION); 
            StAll += St;
            bool retval3 = WriteSerialData(St);

            Logging.Log("sendParametersToSerial was sent", 3);

            return (retval1 && retval2 && retval3);
        }

        /// <summary>
        /// Send command to Arduino to print current settings 
        /// </summary>
        /// <returns></returns>
        public bool queryParametersFromSerial()
        {
            bool retval1 = WriteSerialData("!?S");

            Logging.Log("getParametersToSerial command was sent", 3);

            return retval1;
        }

        /// <summary>
        /// Send command to Arduino to print current settings. Overload with return string
        /// </summary>
        /// <returns></returns>
        public bool queryParametersFromSerial(out string CommandStr)
        {
            String St = "!?S"; CommandStr = St;
            bool retval1 = WriteSerialData(St);

            return retval1;
        }

        /// <summary>
        /// External method to check when was the last communication
        /// </summary>        
        public UInt32 SinceLastDataReceived()
        {
            UInt32 SinceLastRead_sec = UInt32.MaxValue;

            if (UseFileEmulation)
            {
                SinceLastRead_sec = SerialFromFile.SinceLastModification();
            }
            else if (UseSocketRead)
            {
                TimeSpan SinceLastRead = DateTime.Now.Subtract(SocketServer.LastTimeDataRead);
                SinceLastRead_sec = (UInt32)Math.Round(SinceLastRead.TotalSeconds, 0);
            }
            else
            {
                TimeSpan SinceLastRead = DateTime.Now.Subtract(LastTimeDataRead);
                SinceLastRead_sec = (UInt32)Math.Round(SinceLastRead.TotalSeconds, 0);
            }

            return SinceLastRead_sec;
        }

        /// <summary>
        /// External method to check when was last data received and restart communication (a la watchdog)
        /// </summary>        
        public void CheckIfDataReceiving()
        {
            uint PassedSinceReceiving = SinceLastDataReceived();
            if (PassedSinceReceiving > MAX_WAIT_DATA_INTERVAL)
            {
                //restart connection
                Logging.Log("Waiting too long for data (" + PassedSinceReceiving + "). Restarting connection to COM port...");
                stopReadData();
                System.Threading.Thread.Sleep(2000);
                startReadData();
            }
            else
            {
                Logging.Log("CheckIfDataReceiving is ok. Passed since last receive: " + PassedSinceReceiving + "", 3);
            }
        }

        /// <summary>
        /// External interface to check if communication was started
        /// </summary>        
        public bool IsOpened()
        {
            bool ret = false;
            if (UseFileEmulation)
            {
                ret = SerialFromFile.ConsideredOpen;
            }
            else if (UseSocketRead)
            {
                ret = (SocketServer.listenerSocket.IsBound);
            }
            else
            {
                ret=comport.IsOpen;
            }
            return ret;

        }

        /// <summary>
        /// Method to stop communications
        /// </summary>        
        public void Close()
        {
            comport.Close();
        }

        /// <summary>
        /// External method for parsing buffer data and then make all needed calculations
        /// </summary>        
        public void LOOP_CYCLE(out string curSerBuffer)
        {
            //0.1 If Serial file emulation, read file
            if (UseFileEmulation && !UseSimulation) SerialBuffer = SerialFromFile.Read();

            //0.2. If use socket data mode, all data should be already put into var from MainForm
            if (UseSocketRead && !UseSimulation) SerialBuffer = SocketServer.SocketServerCommandBuffer;
            
            //1. PARSE BUFFER
            ParseBufferData();
            
            //Get out and clear buffer after parsing
            curSerBuffer = SerialBuffer;
            SerialBuffer = "";

            //2. MAKE CALCULATIONS
            MakeSensorsCalculations();
        }
            
        /// <summary>
        /// Upgraded main method to parse received data
        /// Based on SensorArray
        /// Mast be called from external. Working asynchronously with data reading
        /// </summary>        
        internal void ParseBufferData()
        {
            string aLine = null;
            StringReader strReader = new StringReader(SerialBuffer);
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

                        // IS THIS A FULL LINE (WITH TAG AND DATA)?
                        if (tagEndPosition >= 0 && valEndPosition >= 0)
                        {
                            //0. PREPARE VALUES
                            string tagName = aLine.Substring(tagStartPosition, tagEndPosition - tagStartPosition);
                            string tagValue_raw = aLine.Substring(tagEndPosition + 1, valEndPosition - tagEndPosition - 1);
                            
                            //0.1. Automatic decimal point correction
                            char Separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                            char BadSeparator = '.';
                            
                            if (Separator == '.') { BadSeparator = ','; }
                            if (Separator == ',') { BadSeparator = '.'; }

                            string tagValue_st = tagValue_raw.Replace(BadSeparator, Separator);
                            
                            //0.2. Try to convert to double. 
                            double tagValue_dbl = -100.0;
                            try
                            {
                                tagValue_dbl = Utils.ConvertToDouble(tagValue_st);
                            }
                            catch (Exception Ex)
                            {
                                //Note, that exception is not always an error - some values should state in string format, i.e. version info
                            }

                            //LINE PARSED TO tagName AND tagValue
                            
                            //1. WRITE IT TO SENSOR VALUE
                            int SensIdx = -1;
                            foreach (SensorElement DataSensor in SensorsList.Values)
                            {
                                SensIdx++;
                                if (DataSensor != null) {
                                    if (DataSensor.SensorArduinoField == tagName){
                                        try
                                        {
                                            //Trim value if it is too lengthy (in case of Arduino malfunction)
                                            if (tagValue_st.Length > 20)
                                            {
                                                tagValue_st = tagValue_st.Substring(0, 20) + "[...]";
                                                Logging.AddLog("TagValue is too long in ParseBufferData for pair [" + tagName + "][" + tagValue_st + "]", 2);
                                            }
                                            
                                            //Convert to Double
                                            if (CheckData(tagValue_dbl, DataSensor.SensorType))
                                            {
                                                SensorsList[DataSensor.SensorName].AddValue(tagValue_dbl);
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
                                            Logging.AddLog("Exception in ParseBufferData for pair [" + tagName + "][" + tagValue_st + "], message: " + ex.Message + ". " + ex.ToString(), 1);
                                        }
                                    }
                                }
                            }

                            //2. PARSING PARTICULAR CASES
                            if (tagName == "Obj")
                            {
                            }
                            else if (tagName == "RL1")
                            {
                                int Relay1_n = Convert.ToInt16(tagValue_dbl);
                                if (Relay1 == 0 && Relay1_n == 1)
                                {
                                    LastHeating1SwitchOn = DateTime.Now;
                                }
                                else if (Relay1==1 && Relay1_n==0) {
                                    LastHeating1SwitchOff = DateTime.Now;
                                }
                                Relay1=Relay1_n;
                            }
                            else if (tagName == "RL2")
                            {
                                int Relay2_n = Convert.ToInt16(tagValue_dbl);
                                if (Relay2 == 0 && Relay2_n == 1)
                                {
                                    LastHeating2SwitchOn = DateTime.Now;
                                }
                                else if (Relay2 == 1 && Relay2_n == 0)
                                {
                                    LastHeating2SwitchOff = DateTime.Now;
                                }
                                Relay2 = Relay2_n;
                            }
                            else if (tagName == "WnV")
                            {
                                WindSensorVal = Convert.ToInt16(tagValue_dbl);
                                
                                //autocalibrate min speed
                                if (WS_AutoCalibrateFlag)
                                {
                                    AutoCalibrateWindSpeed();
                                }
                                WindSpeedVal = calcWindSpeed(WindSensorVal);
                            }
                            else if (tagName == "Lur")
                            {
                                LumRes = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "Lus")
                            {
                                LumSens = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "Luw")
                            {
                                LumWTime = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "!r")
                            {
                                MeasureCycleLen = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "!be")
                            {
                            }
                            else if (tagName == "Pre")
                            {
                                PressureVal = tagValue_dbl;
                                PressureNormalVal = CalcNormalPressure();
                            }
                            else if (tagName == "ver")
                            {
                                SketchVersion = tagValue_st;
                                VersionData.HardwareVersionSt = SketchVersion;
                            }
                            else if (tagName == "ved")
                            {
                                SketchVersionDate = tagValue_st;
                                VersionData.HardwareCompileTimeSt = SketchVersionDate;
                            }
                            else if (tagName == "!en")
                            {

                            }
                            else if (tagName == "?TD")
                            {
                                ArduinoSettingsClass El = new ArduinoSettingsClass();
                                El.Value = tagValue_st;
                                El.ReadTime = DateTime.Now;
                                ArduinoSettings["TD"]= El;
                            }
                            else if (tagName == "?WT")
                            {
                                ArduinoSettingsClass El = new ArduinoSettingsClass();
                                El.Value = tagValue_st;
                                El.ReadTime = DateTime.Now;
                                ArduinoSettings["WT"] = El;
                            }
                            else if (tagName == "?RT")
                            {
                                ArduinoSettingsClass El = new ArduinoSettingsClass();
                                El.Value = tagValue_st;
                                El.ReadTime = DateTime.Now;
                                ArduinoSettings["RT"] = El;
                            }
                        }
                        else
                        //THE LINE IS INCOMPLETE
                        {
                            //write error log
                            Logging.Log("Incomplete protocol line: " + aLine,2);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void AutoCalibrateWindSpeed()
        {
            
            double curVal = SensorsList["WSp"].LastValue;
            double minVal = SensorsList["WSp"].MinValue;
            TimeSpan PassedFromMinSet=DateTime.Now-SensorsList["WSp"].MinValueSetTime;

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
            TimeSpan PassedFromMinHit = DateTime.Now - WS_MinValue_LastHit;
            //reset min value
            if (PassedFromMinHit.Seconds > autoCalWS_maxPassedFromHit)
            {
                SensorsList["WSp"].MinValue = curVal;
                WS_MinValue_HitCount = 0;
                WS_MinValue_LastHit = new DateTime(2010, 01, 01);
            }

        }

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
                    if (CheckData(SensorsList[BaseTempName].LastValue, SensorTypeEnum.Temp))
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
                RGC_Cumulative += (RGCVal >= 0 ? RGCVal : 0);
                RGC_Cumulative_mm += (RGCVal >= 0 ? RGCVal : 0) * RGC_ONETICK_VALUE;
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
                Logging.Log("Exception in MakeSensorCalculations! " +Environment.NewLine+ ex.ToString());
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

        /// <summary>
        /// Check if sensor heating needed
        /// </summary>
        public void CheckIfSkySensorHeatingNeeded()
        {
            Logging.Log("CheckIfSkySensorHeatingNeeded enter", 3);

            CloudSensorNeedHeatingFlag = false;

            // Check - if cloud sensor values are in given interval?
            bool CSNeedsHeating_CSIntervalMet = (CloudIdx > HEATER_CLOUDINDEX_MIN && CloudIdx < HEATER_CLOUDINDEX_MAX);

            // Ckeck - if CS temp monotonous decreasing
            double deltaCur = -100.0;
            bool CSNeedsHeating_CSDecreasingTempMet=false;
            for (int i = 1; i < Math.Min(SkyIndex5min.Count, CS_NEEDHEATING_LOOKBACK_CYCLES); i++)
            {
                deltaCur = SkyIndex5min[i] - SkyIndex5min[i-1];
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
            CloudSensorNeedHeatingFlag=(CSNeedsHeating_CSIntervalMet && CSNeedsHeating_CSDecreasingTempMet);
            if (CloudSensorNeedHeatingFlag) Logging.Log("Cloud sensor heating narrow condition is met, but need to test other", 2);
 
            // Check - how long has been passed since last switch on
            TimeSpan SinceLastHeatingMF = DateTime.Now.Subtract(LastHeating1SwitchOff);
            Heating1Off_SecondsPassed = (int)Math.Round(SinceLastHeatingMF.TotalSeconds, 0);
            SinceLastHeatingMF = DateTime.Now.Subtract(LastHeating1SwitchOn);
            Heating1On_SecondsPassed = (int)Math.Round(SinceLastHeatingMF.TotalSeconds, 0);
            SinceLastHeating1 = Math.Min(Heating1Off_SecondsPassed, Heating1On_SecondsPassed);
            bool CSNeedsHeating_SinceLastHeatingMet = (SinceLastHeating1 > HEATER_CS_PAUSE); //since last heating session passed enough time
            //Relay off now?
            bool CSNeedsHeating_RelayOffNow = (SensorsList["RL1"].LastValue == 0); //heating not engaged already

            //Check - humidity is high?
            bool CSNeedsHeating_HumidityMet = (SensorsList["Hum1"].LastValue >= 99.9); //high humidity

            //Check - is it raining now?
            bool CSNeedsHeating_NotRainingMet = ( !RainLastMinute_Flag ); //no rain in last minute

            //Check - is it dark?
            bool CSNeedsHeating_DarknessMet = (IllumVal <= DAYLIGHT_DARK_LIMIT && IllumVal >= 0); //is it dark now?

             
            //GENERAL CHECK
            if (CloudSensorNeedHeatingFlag && CSNeedsHeating_SinceLastHeatingMet && CSNeedsHeating_RelayOffNow && CSNeedsHeating_HumidityMet
                && CSNeedsHeating_NotRainingMet && CSNeedsHeating_DarknessMet )
            {
                //Switch on
                HeatingOn();
            }

            Logging.Log("CheckIfSkySensorHeatingNeeded exit", 3);
        }

        /// <summary>
        /// Wrapper for heating turn on
        /// </summary>
        public bool HeatingOn()
        {
            LastHeating1SwitchOn = DateTime.Now;
            Logging.Log("Heating on", 1);
            return WriteSerialData("RL1:1");
        }

        /// <summary>
        /// Wrapper for heating turn off
        /// </summary>
        public bool HeatingOff()
        {
            LastHeating1SwitchOff = DateTime.Now;
            Logging.Log("Heating off", 1);
            return WriteSerialData("RL1:0");
        }


        /// <summary>
        /// Wrapper for writing Boltwood CS file
        /// </summary>
        public void WriteBolwoodFile()
        {
            Logging.Log("WriteBolwoodFile enter", 3);

            //Сохранение Boltwood файла
            Logging.WirteBoltwoodData(getBoltwoodString());

            Logging.Log("WriteBolwoodFile exit", 3);

        }

        /// <summary>
        /// Wrapper for writing CSV file
        /// </summary>
        public void WriteCSV()
        {
            Logging.Log("WriteCSV enter", 3);

            //Сохранение CSV файла
            Logging.LogData(getCSVline(), getCSVHeaderline());

            Logging.Log("WriteCSV exit", 3);
        }

        /// <summary>
        /// Method to generate contents of Boltwood format file
        /// </summary>   
        public string getBoltwoodString_old()
        {
            Logging.Log("getBoltwoodString_old enter. This should never happened!", 3);

            //Calculations for boltwood
            Bolt_DewPoint = calcDewPoint(BaseTempVal, HumidityVal);

            //Bolt_Heater
            //not implemented yet

            //Boltwood date time fields
            Bolt_date = DateTime.Now.ToString("yyyy-MM-dd");
            Bolt_time = DateTime.Now.ToString("HH:mm:ss.ff");
            Bolt_now = DateTime.Now.ToOADate();
            TimeSpan MeasureInterval = DateTime.Now.Subtract(LastMeasure);
            Bolt_SinceLastMeasure = (ushort)Math.Round(MeasureInterval.TotalSeconds, 0);

            //Cloud condition
            //CloudIdx = Temp1 - ObjTemp;
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
            if (WetVal > RAININDEX_WET_LIMIT)
            {
                //DRY
                Bolt_RainCond = RainCond.rainDry;
                if (Bolt_RainFlag_sinceLastDetected > 0 && Bolt_RainFlag_sinceLastDetected < 60) { Bolt_RainFlag = RainFlag.rainFlagLastminute; }
                else { Bolt_RainFlag = RainFlag.rainFlagDry; }

                if (Bolt_WetFlag_sinceLastDetected > 0 && Bolt_WetFlag_sinceLastDetected < 60) { Bolt_WetFlag = WetFlag.wetFlagLastminute; }
                else { Bolt_WetFlag = WetFlag.wetFlagDry; }
            }
            else if (WetVal > RAININDEX_RAIN_LIMIT)
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
            else if (WetVal >= RAININDEX_BAD_LIMIT)
            {
                //RAIN
                Bolt_RainCond = RainCond.rainRain;

                Bolt_RainFlag = RainFlag.rainFlagRightnow;
                Bolt_RainFlag_LastDetected = DateTime.Now;

                Bolt_WetFlag = WetFlag.wetFlagRightnow;
                Bolt_WetFlag_LastDetected = DateTime.Now;
            }

            //Daylight condition
            if (IllumVal > DAYLIGHT_LIGHT_LIMIT) { Bolt_DaylighCond = DayCond.dayVeryLight; }
            else if (IllumVal > DAYLIGHT_DARK_LIMIT) { Bolt_DaylighCond = DayCond.dayLight; }
            else if (IllumVal >= 0) { Bolt_DaylighCond = DayCond.dayDark; }

            //Bolt_RoofCloseFlag: roof close, =0 not requested, =1 if roof close was requested on this cycle 
            //not implemented yet

            //Bolt_AlertFlag: alert, =0 when not alerting, =1 when alerting 
            //not implemented yet

            //Making boltwood string
            string bold_st = String.Format("{0,10} {1,11} C K {2,6:N1} {3,6:N1} {4,6:N1} {5,6:N1} {6,3:N0} {7,6:N1} {8,3:N0} {9,1:N0} {10,1:N0} {11,5:N0} {12,12:F5} {13,1:N0} {14,1:N0} {15,1:N0} {16,1:N0} {17,1:N0} {18,1:N0}",
                Bolt_date, Bolt_time, ObjTempVal, BaseTempVal, SensorCaseTempVal, WindSpeedVal, HumidityVal, Bolt_DewPoint, Bolt_Heater,
                (int)Bolt_RainFlag, (int)Bolt_WetFlag, Bolt_SinceLastMeasure.ToString("00000"), Bolt_now.ToString("000000.#####"),
                (int)Bolt_CloudCond, (int)Bolt_WindCond, (int)Bolt_RainCond, (int)Bolt_DaylighCond, (int)Bolt_RoofCloseFlag, (int)Bolt_AlertFlag);

            return bold_st;
        }

        /// <summary>
        /// Method to generate contents of Boltwood format file
        /// - Changed: rain condition from main method
        /// </summary>   
        public string getBoltwoodString()
        {
            Logging.Log("getBoltwoodString enter", 3);

            //Calculations for boltwood
            Bolt_DewPoint = calcDewPoint(BaseTempVal, HumidityVal);

            //Bolt_Heater
            //not implemented yet

            //Boltwood date time fields
            Bolt_date = DateTime.Now.ToString("yyyy-MM-dd");
            Bolt_time = DateTime.Now.ToString("HH:mm:ss.ff");
            Bolt_now = DateTime.Now.ToOADate();
            TimeSpan MeasureInterval = DateTime.Now.Subtract(LastMeasure);
            Bolt_SinceLastMeasure = (ushort)Math.Round(MeasureInterval.TotalSeconds, 0);

            //Cloud condition
            //CloudIdx = Temp1 - ObjTemp;
            if (CLOUDMODEL == CloudSensorModel.Classic)
            {
                if (CloudIdx > CLOUDINDEX_CLEAR) { Bolt_CloudCond = CloudCond.cloudClear; }
                else if (CloudIdx > CLOUDINDEX_CLOUDY) { Bolt_CloudCond = CloudCond.cloudCloudy; }
                else if (CloudIdx >= CLOUDINDEX_CLOUDY_BAD) { Bolt_CloudCond = CloudCond.cloudVeryCloudy; }
            }
            else
            {
                if (CloudIdxAAG > CLOUDINDEXAAG_CLEAR) { Bolt_CloudCond = CloudCond.cloudClear; }
                else if (CloudIdxAAG > CLOUDINDEXAAG_CLOUDY) { Bolt_CloudCond = CloudCond.cloudCloudy; }
                else if (CloudIdxAAG >= CLOUDINDEXAAG_CLOUDY_BAD) { Bolt_CloudCond = CloudCond.cloudVeryCloudy; }
            }

            //Bolt_WindCond: windCalm, windWindy, windVeryWindy
            Bolt_WindCond = WindCond.windUnknown;
            if (WindSpeedVal >= WINDSPEED_VERYWINDY) { Bolt_WindCond = WindCond.windVeryWindy; }
            else if (WindSpeedVal >= WINDSPEED_WINDY) { Bolt_WindCond = WindCond.windWindy; }
            else if (WindSpeedVal < 0) { Bolt_WindCond = WindCond.windUnknown; }
            else { Bolt_WindCond = WindCond.windCalm; }

            TimeSpan MeasureIntervalWF = DateTime.Now.Subtract(Bolt_WetFlag_LastDetected);
            Bolt_WetFlag_sinceLastDetected = (ushort)Math.Round(MeasureIntervalWF.TotalSeconds, 0);
            TimeSpan MeasureIntervalRF = DateTime.Now.Subtract(Bolt_RainFlag_LastDetected);
            Bolt_RainFlag_sinceLastDetected = (ushort)Math.Round(MeasureIntervalRF.TotalSeconds, 0);

            //Rain condition & Bolt_RainFlag + Bolt_WetFlag
            if (RainNow_Flag)
            {
            //RAIN
                Bolt_RainCond = RainCond.rainRain;

                Bolt_RainFlag = RainFlag.rainFlagRightnow;
                Bolt_RainFlag_LastDetected = DateTime.Now;

                Bolt_WetFlag = WetFlag.wetFlagRightnow;
                Bolt_WetFlag_LastDetected = DateTime.Now;
            }
            else if (!RainNow_Flag && RainNow_WetS_FlagC == RainCond.rainWet)
            {
            //WET
                Bolt_RainCond = RainCond.rainWet;
                Bolt_WetFlag = WetFlag.wetFlagRightnow;
                Bolt_WetFlag_LastDetected = DateTime.Now;
            }
            else
            {
            //DRY
                Bolt_RainCond = RainCond.rainDry;
                if (Bolt_RainFlag_sinceLastDetected > 0 && Bolt_RainFlag_sinceLastDetected < 60) { Bolt_RainFlag = RainFlag.rainFlagLastminute; }
                else { Bolt_RainFlag = RainFlag.rainFlagDry; }

                if (Bolt_WetFlag_sinceLastDetected > 0 && Bolt_WetFlag_sinceLastDetected < 60) { Bolt_WetFlag = WetFlag.wetFlagLastminute; }
                else { Bolt_WetFlag = WetFlag.wetFlagDry; }
            }

            //Daylight condition
            if (IllumVal > DAYLIGHT_LIGHT_LIMIT) { Bolt_DaylighCond = DayCond.dayVeryLight; }
            else if (IllumVal > DAYLIGHT_DARK_LIMIT) { Bolt_DaylighCond = DayCond.dayLight; }
            else if (IllumVal >= 0) { Bolt_DaylighCond = DayCond.dayDark; }

            //Bolt_RoofCloseFlag: roof close, =0 not requested, =1 if roof close was requested on this cycle 
            //not implemented yet

            //Bolt_AlertFlag: alert, =0 when not alerting, =1 when alerting 
            //not implemented yet

            //Making boltwood string
            string bold_st = String.Format("{0,10} {1,11} C K {2,6:N1} {3,6:N1} {4,6:N1} {5,6:N1} {6,3:N0} {7,6:N1} {8,3:N0} {9,1:N0} {10,1:N0} {11,5:N0} {12,12:F5} {13,1:N0} {14,1:N0} {15,1:N0} {16,1:N0} {17,1:N0} {18,1:N0}",
                Bolt_date, Bolt_time, ObjTempVal, BaseTempVal, SensorCaseTempVal, WindSpeedVal, HumidityVal, Bolt_DewPoint, Bolt_Heater,
                (int)Bolt_RainFlag, (int)Bolt_WetFlag, Bolt_SinceLastMeasure.ToString("00000"), Bolt_now.ToString("000000.#####"),
                (int)Bolt_CloudCond, (int)Bolt_WindCond, (int)Bolt_RainCond, (int)Bolt_DaylighCond, (int)Bolt_RoofCloseFlag, (int)Bolt_AlertFlag);

            Logging.Log("getBoltwoodString exit", 3);

            return bold_st;
        }


        /// <summary>
        /// Method to generate CSV line for datalog file
        /// </summary>   
        public string getCSVline()
        {
            Logging.Log("getCSVline enter", 3);

            //Строка CSV файла
            string st = "";

            int SensIdx = -1;
            foreach (SensorElement DataSensor in SensorsList.Values)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.Enabled)
                    {
                        st += Convert.ToString(DataSensor.LastValue) + Logging.CSVseparator;
                    }
                }
            }

            st += Convert.ToString(CloudIdx) + Logging.CSVseparator;
            st += Convert.ToString(CloudIdxAAG) + Logging.CSVseparator;

            Logging.Log("getCSVline exit", 3);
            return st;
        }

        /// <summary>
        /// Method to generate CSV header line for datalog file
        /// </summary>   
        public string getCSVHeaderline()
        {
            Logging.Log("getCSVHeaderline enter", 3);

            //Строка CSV файла
            string st = "Date" + Logging.CSVseparator;

            int SensIdx = -1;
            foreach (SensorElement DataSensor in SensorsList.Values)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.Enabled)
                    {
                        if (DataSensor.SensorName == BaseTempName)
                        {
                            st += "[" + Convert.ToString(DataSensor.SensorName) + "]" + Logging.CSVseparator;
                        }
                        else
                        {
                            st += Convert.ToString(DataSensor.SensorName) + Logging.CSVseparator;
                        }
                    }
                }
            }
            st += "CloudIdx" + Logging.CSVseparator;
            st += "CloudIdxAAG" + Logging.CSVseparator;

            Logging.Log("getCSVHeaderline exit", 3);
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
                    if (TagVal < 0 || TagVal >= 1000) //maximum value I have ever seen was 237
                        return false;
                    break;
                case SensorTypeEnum.Relay:
                    if (TagVal < 0 || TagVal > 1) //only 2 values allowed: 0 and 1
                        return false;
                    break;
                case SensorTypeEnum.WSp:
                    if (TagVal < 0 || TagVal > 1023) //Actually it is AnalogUnits. 1023 - max value, corresponds to MaxSpeed (def 32.4 m/s). Hurricane > 32
                        return false;
                    break;
            }
            return true;
        }
        
        /// <summary>
        /// Method to check data validity for different sensors type
        /// Specail for working with SensorArray
        /// </summary>      
        public bool CheckData(SensorElement Sensor)
        {
            double TagVal = Sensor.LastValue;
            switch (Sensor.SensorType)
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
                    if (TagVal < 0 || TagVal >= 1000) //maximum value I have ever seen was 237
                        return false;
                    break;
                case SensorTypeEnum.Relay:
                    if (TagVal < 0 || TagVal > 1) //only 2 values allowed: 0 and 1
                        return false;
                    break;
            }
            return true;
        }

        /// <summary>
        /// Calculates Cloud Index by classic methodology
        /// </summary>
        /// <param name="Tsky">Measured sky temperature</param>
        /// <param name="Tamb">Ambient temperature</param>
        /// <returns>Corrected sky temperature which is used as index</returns>
        public double calcCloudIndex(double Tsky, double Tamb, double Tcase=-100.0)
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
            else {
                T67 = K6/10 * Math.Sign(Tamb - K2 / 10) * (Math.Log(Math.Abs((K2 / 10 - Tamb)))/Math.Log(10) + K7/100);
            }

            double Td = (K1 / 100) * (Tamb - K2 / 10) + (K3 / 100) * Math.Pow(Math.Exp(K4 / 1000 * Tamb), (K5 / 100)) + T67;

            double Tcorr = Td-Tsky;

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
            /*  Calculate RAIN RIGHT NOW CONDITION */
            /* Calculate Wet Sensor value */
            try
            {
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
                Logging.Log("Exception in Calculate Wet Sensor value: " + ex.ToString());
            }


            /* Calculate RGC Sensor value */
            try
            {
                if (RGCVal > 0)
                {
                    RainNow_RGC_Flag = true;
                    Logging.Log("RGC sensed rain now",3);
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
                Logging.Log("Exception in Calculate RGC Sensor value: " + ex.ToString());
            }

            /*  Calculate RAIN IN LAST MINUTE CONDITION */
            /*
             * 
             * Last minute =    if rain now true - rain during previous cycles (5 min approx)
             *                  if rain now flase - rain during previous cycles (5 min approx)
             */
            
            int NumValuesInMinute = (int)Math.Round(60.0 / MeasureCycleLen * 1000);
            
            // Calculate rain last minute for RGC sensor 
            int countRRainCylcles = 0;
            try
            {
                for (int i = 1; i < Math.Min(NumValuesInMinute, SensorsList["RGC"].ValuesLastFiveMin.Count); i++)
                {
                    if (SensorsList["RGC"].ValuesLastFiveMin[i]>0) countRRainCylcles++;
                }
                if (countRRainCylcles > 0 && SensorsList["RGC"].Enabled) //
                {
                    RainLastMinute_RGC_Flag = true;
                    Logging.Log("RGC sensed rain last minute",2);
                }
                else
                {
                    RainLastMinute_RGC_Flag = false;
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
                Logging.Log("Exception in Calculate rain last minute for RGC sensor: " + ex.ToString());
            }

             // Calculate rain last minute for WET sensor 

            int countWRainCylcles = 0, countWWetCylcles=0;

            try
            {

                for (int i = 1; i < Math.Min(NumValuesInMinute, SensorsList["Wet"].ValuesLastFiveMin.Count); i++)
                {
                    if (SensorsList["Wet"].ValuesLastFiveMin[i] <= RAININDEX_RAIN_LIMIT) {countWRainCylcles++;}
                    else if (SensorsList["Wet"].ValuesLastFiveMin[i] <= RAININDEX_WET_LIMIT) {countWWetCylcles++;}
                }
                if (countWRainCylcles > 0 && SensorsList["Wet"].Enabled) //
                {
                    RainLastMinute_WetS_FlagC = RainCond.rainRain;
                    Logging.Log("Wet sensed rain last minute", 3);
                }
                else if (countWWetCylcles > 0  && SensorsList["Wet"].Enabled) //
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
                Logging.Log("Exception in Calculate Wet Sensor value: " + ex.ToString());
            }

            /*  Rain now conditions when using both sensors
             *  Wet            | rainUnknown   | rainWet   | rainRain  | rainDry   |
             *  --------------------------------------------------------------------
             *  RGC>0 & RGCLM- |       X       |     X     |     X     |           |
             *  RGC>0 & RGCLM+ |       X       |     X     |     X     |     X     |
             *  RGC=0 & RGCLM- |               |           |           |           |
             *  RGC=0 & RGCLM+ |               |           |     X     |           |
             *  --------------------------------------------------------------------
             */
            try
            {
                switch (RainConditionMode)
                {
                    case WetSensorsMode.wetSensBoth:
                        if ((RainNow_RGC_Flag && ( RainNow_WetS_FlagC == RainCond.rainUnknown || RainNow_WetS_FlagC == RainCond.rainWet || RainNow_WetS_FlagC == RainCond.rainRain ))
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
                            || (countRRainCylcles>=2 && ( RainLastMinute_WetS_FlagC == RainCond.rainDry )))
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

                        if (RainNow_WetS_FlagC==RainCond.rainRain ) {RainNow_Flag = true;}
                        else {RainNow_Flag = false;}

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

            double RVal = Math.Round(windspeed_raw, 1); //round value to 0.1

            return RVal;
        }

        public string getSensorsString()
        {
            Logging.Log("getSensorsString enter", 3);

            string st = "";
            int SensIdx = -1;
            foreach (SensorElement DataSensor in SensorsList.Values)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.Enabled)
                    {
                        st += Convert.ToString(DataSensor.SensorName) + "=" + Convert.ToString(DataSensor.LastValue) + Logging.CSVseparator;
                    }
                }
            }

            st += "CloudIdx="+ Convert.ToString(CloudIdx) + Logging.CSVseparator;
            st += "CloudIdxAAG=" + Convert.ToString(CloudIdxAAG) + Logging.CSVseparator;

            Logging.Log("getSensorsString exit, ret: ["+st+"]", 3);
            return st;
        }

        public string getBaseTemp()
        {
            Logging.Log("getBaseTemp enter", 3);

            string st = "";

            st = String.Format("{0:0.0}",BaseTempVal);

            Logging.Log("getBaseTemp exit, ret: [" + st + "]", 3);
            return st;
        }

        public double CalcPressureOnHeight(double PressBase,double dHeight, double dTemp)
        {
            const double MollMass=0.029; //молярная масса сухого воздуха, M = 0,029 кг/моль;
            const double g=9.81; //ускорение свободного падения, g = 9,81 м/с²;
            const double R=8.31; // универсальная газовая постоянная, R = 8,31 Дж/моль·К;
            
            double Tabs=dTemp+273; // абсолютная температура воздуха, К, T = t + 273, где t — температура в °C;

            double Press=PressBase*Math.Exp(-MollMass*g*dHeight/(R*Tabs));

            return Press;
        }

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
