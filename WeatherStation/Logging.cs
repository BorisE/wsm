using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WeatherStation
{
        /// <summary>
        /// ADDED FOR COMPATABILITY WITH NEXT LOGGER VERSION
        /// </summary>
        public enum Highlight
        {
            Normal = 0,
            Error = 1,
            Hoghlight = 2
        }
    
    public static class Logging
    {
        private static TextWriter LogFile = null;
        public static string LogFileName = "weather_station_"; //Text log
        public static string LogFileExt = ".log"; //Text log
        public static string LogFilePath = "";
        public static bool LogFileFlag = true;

        private static TextWriter SerialLogFile = null;
        public static string SerialLogFileName = "weather_station_serial_"; //Serial log file
        public static string serialLogExt = ".log";
        public static string SerialLogFilePath = "";
        public static bool SerialLogFileFlag = true;

        private static TextWriter dataLogFile = null;
        public static string dataLogFileName = "weather_station_"; //CSV log data
        public static string dataLogExt = ".csv";
        public static char CSVseparator = ';';
        public static string DataFilePath = "";
        public static bool DataFileFlag = true;

        private static TextWriter BoltwoodFile = null;
        public static string BoltwoodFileName = "cloudsensor"; //cloud sensor file
        public static string BoltwoodFileExt = ".dat";
        public static string BoltwoodFilePath = "";
        public static bool BoltwoodFileFlag = true;

        //DEBUG LEVEL
        public static byte DEBUG_LEVEL = 1;

        //RGC value storage
        private static string RGCFileName = "rgc.dat"; //Text log
        public static DateTime RGCLastSaved;

        private static string ApplicationFilePath
        {
            get { return Application.StartupPath + "\\"; }
        }

        /// <summary>
        /// Error log procedures
        /// </summary>
        #region Error log section
        public static void OpenLogFile()
        {
            if (LogFilePath == "") LogFilePath = ApplicationFilePath;
            try
            {
                LogFile = File.AppendText(LogFilePath + LogFileName + DateTime.Now.ToString("yyyy-MM-dd") + LogFileExt);
            }
            catch {
                MessageBox.Show("Cannot open log file");
            }
        }

        public static void CloseLogFile()
        {
            try
            {
                LogFile.Close();
            }
            catch
            {
                //MessageBox.Show("Cannot close log file");
            }
            LogFile = null;
        }

        public static void Log(string logMessage, byte LogLevel=1)
        {
            // if current log level is less then DebugLevel
            if (LogLevel <= DEBUG_LEVEL)
            {
                try
                {
                    if (LogFile == null)
                    {
                        OpenLogFile();
                    }

                    LogFile.Write("{0} {1} [{2}]:", DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm:ss.fff"), LogLevel);
                    LogFile.WriteLine("{0}", logMessage);
                }
                catch {
                    MessageBox.Show("Cannot write log file");
                }
                
                CloseLogFile();
            }
        }
        #endregion

        /// <summary>
        /// Add log record function. ADDED AS A WRAPPER FOR COMPATABILITY WITH NEXT VERSION LOGGER CLASS (used in Observatory control)
        /// </summary>
        /// <param name="logMessage"></param>
        /// <param name="LogLevel"></param>
        /// <param name="ColorHoghlight"></param>
        public static void AddLog(string logMessage, byte LogLevel = 1, Highlight ColorHoghlight = Highlight.Normal)
        {
            Log(logMessage, LogLevel);
        }

        /// <summary>
        /// Serial log procedures
        /// </summary>
        #region Serial log section
        public static void OpenSerialLogFile()
        {
            if (SerialLogFilePath == "") SerialLogFilePath = ApplicationFilePath;

            string FullFileName = SerialLogFilePath + SerialLogFileName + DateTime.Now.ToString("yyyy-MM-dd") + serialLogExt;

            try
            {
                if (!File.Exists(FullFileName))
                {
                    SerialLogFile = File.CreateText(FullFileName);
                }
                else
                {
                    SerialLogFile = File.AppendText(FullFileName);
                }
            }
            catch
            {
                Logging.Log("Cannot open serial log file");
            }
        }

        public static void CloseSerialLogFile()
        {
            try
            {
                SerialLogFile.Close();
            }
            catch
            {
                Logging.Log("Cannot close serial log file");
            }

            SerialLogFile = null;
        }

        public static void LogSerial(string logMessage)
        {
            if (SerialLogFile == null)
            {
                OpenSerialLogFile();
            }

            try
            {
                SerialLogFile.Write("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
                SerialLogFile.WriteLine(": {0}", logMessage);
            }
            catch
            {
                Logging.Log("Cannot write serial log file");
            }
            
        }
        #endregion

        /// <summary>
        /// Data log procedures
        /// </summary>
        #region Data log section
        public static void OpenDataLogFile(string headerline)
        {
            if (DataFilePath == "") DataFilePath = ApplicationFilePath;

            //string FullFileName = DataFilePath + dataLogFileName + DateTime.Now.ToShortDateString()+dataLogExt; //bad for 
            string FullFileName = DataFilePath + dataLogFileName + DateTime.Now.ToString("yyyy-MM-dd") +dataLogExt;

            try
            {
                if (!File.Exists(FullFileName))
                {
                    dataLogFile = File.CreateText(FullFileName);
                    dataLogFile.WriteLine(headerline);
                }
                else
                {
                    dataLogFile = File.AppendText(FullFileName);
                }

            }
            catch
            {
                Logging.Log("Cannot open data log file");
            }
        
        }

        public static void CloseDataLogFile()
        {
            try
            {
                dataLogFile.Close();
            }
            catch
            {
                Logging.Log("Cannot close data log file");
            }

            dataLogFile = null;
        }

        public static void LogData(string dataline, string headerline)
        {
            if (dataLogFile == null)
            {
                OpenDataLogFile(headerline);
            }
            
            try
            {
                dataLogFile.WriteLine("{0} {1:H:mm:ss}" + CSVseparator + " {2}", DateTime.Now.ToShortDateString(), DateTime.Now, dataline);
            }
            catch
            {
                Logging.Log("Cannot write data log file");
            }
            CloseDataLogFile();

        }

        public static void _SaveRGCValueTxt(int RGCVal)
        {
            if (DataFilePath == "") DataFilePath = ApplicationFilePath;
            try
            {
                using (StreamWriter outfile = new StreamWriter(DataFilePath + RGCFileName))
                {
                    outfile.Write(RGCVal.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Cannot write RGCValueTxt log file");
            }
        }
        public static int _LoadRGCValueTxt()
        {
            if (DataFilePath == "") DataFilePath = ApplicationFilePath;
            int RGCVav = 0;
            try
            {
                using (StreamReader sr = new StreamReader(DataFilePath + RGCFileName))
                {
                    String RGCValSt = sr.ReadToEnd();
                    RGCVav = Convert.ToInt16(RGCValSt);
                }
            }
            catch
            {
                Logging.Log("Cannot load RGC Value file");
                RGCVav = 0;
            }
            return RGCVav;
        }

        public static bool SaveRGCValue(int RGCVal,DateTime LastReset)
        {
            if (DataFilePath == "") DataFilePath = ApplicationFilePath;
            if (LastReset == DateTime.MinValue) LastReset = DateTime.Now;

            BinaryWriter bw;
            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream(DataFilePath + RGCFileName, FileMode.Create));
            }
            catch
            {
                return false;
            }
            //writing into the file
            try
            {
                bw.Write(RGCVal);
                bw.Write(DateTime.Now.ToString());
                bw.Write(LastReset.ToString());
            }
            catch
            {
                Logging.Log("Cannot save RGC Value file");
                return false;
            }
            bw.Close();
            return true;
        }

        public static int LoadRGCValue(out DateTime RGCLastReset)
        {
            if (DataFilePath == "") DataFilePath = ApplicationFilePath;
            int RGCVav = 0;
            RGCLastSaved = DateTime.MinValue;
            RGCLastReset = DateTime.MinValue;

            BinaryReader br;
            //open file
            try
            {
                br = new BinaryReader(new FileStream(DataFilePath + RGCFileName, FileMode.Open));
            }
            catch
            {
                Logging.Log("Cannot load RGC Value file"); 
                return 0;
            }
            //read file
            string RGC_LastSavedSt="",RGC_LastResetSt="";
            try
            {
                RGCVav = br.ReadInt32();
                RGC_LastSavedSt = br.ReadString();
                RGC_LastResetSt = br.ReadString();
            }
            catch
            {
                return 0;
            }

            try
            {
                RGCLastSaved = Convert.ToDateTime(RGC_LastSavedSt);
                RGCLastReset = Convert.ToDateTime(RGC_LastResetSt);
            }
            catch {
                Logging.Log("Cannot load RGC Value file");
            }
            br.Close();

            Logging.Log("LoadRGCValue = " + RGCVav + "",3);
            
            return RGCVav;
        }
        
        #endregion

        /// <summary>
        /// Boltwood data storage procedures
        /// </summary>
        #region Boltwood data section
        public static void OpenBoltwoodFile()
        {
            if (BoltwoodFilePath == "") BoltwoodFilePath = ApplicationFilePath;
            string FullFileName = BoltwoodFilePath + BoltwoodFileName + BoltwoodFileExt;

            try
            {
                BoltwoodFile = File.CreateText(FullFileName);
            }
            catch
            {
                Logging.Log("Cannot create boltwood data file");
            }
        }

        public static void CloseBoltwoodFile()
        {
            try
            {
                BoltwoodFile.Close();
            }
            catch
            {
                Logging.Log("Cannot close boltwood data file");
            }
            BoltwoodFile = null;
        }

        public static void WirteBoltwoodData(string dataline)
        {
            if (BoltwoodFile == null)
            {
                OpenBoltwoodFile();
            }

            try
            {
                BoltwoodFile.Write(dataline);
            }
            catch
            {
                Logging.Log("Cannot write boltwood data file");
            }

            CloseBoltwoodFile();

        }
        #endregion
    
    }
}
