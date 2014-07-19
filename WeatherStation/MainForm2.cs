using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Threading;

namespace WeatherStation
{
 
    public partial class MainForm : Form
    {
        /// <summary>
        /// Link to WeatherStationSerial class object which is used to communicate with Arduino
        /// </summary>
        public WeatherStationSerial Hardware;

        /// <summary>
        /// Link to LogForm, to where all communications with Arduino module is output
        /// </summary>
        private LogWindow LogForm;

        //For graphs
        private DateTime curX;
        public int maxNumberOfPointsInChart = 8640; //For 24h with 10sec interval
        public int MAX_LOG_LENGTH = 10000;

        private About aboutForm;

        private bool SimulationMode = false;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LogForm = new LogWindow(this);
            Hardware = new WeatherStationSerial();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load current settings
            LoadParams();

            Logging.Log("Program started");

            //INIT GRAPHICS
            //chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            foreach (Series serNum in chart1.Series)
            {
                serNum.XValueType = ChartValueType.DateTime;
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";

            // Create cursor object
            System.Windows.Forms.DataVisualization.Charting.Cursor cursor = null;
            // Set cursor object
            cursor = chart1.ChartAreas[0].CursorX;
            // Set cursor properties 
            cursor.LineWidth = 2;
            cursor.LineDashStyle = ChartDashStyle.DashDot;
            cursor.LineColor = Color.Red;
            cursor.SelectionColor = Color.Yellow;
            // Set cursor selection color of X axis cursor
            chart1.ChartAreas[0].CursorX.SelectionColor = Color.Yellow;

            // TEST COMMAND LINE PARAMETERS
            string[] args = Environment.GetCommandLineArgs();

            bool autostart = false;

            for (int i = 1; i < args.Length; i++)
            {
                if (args[i].IndexOf("start") >= 0)
                {
                    //AUTOSTART MONITORING
                    autostart = true;
                } else if (args[i].ToLower().Substring(0,3) == "com")
                {
                    //RESET COM PORT NAME
                    Hardware.PortName = args[i].ToLower();
                }
            }

            if (autostart)
            {
                //AUTOSTART MONITORING
                Logging.Log("Program autostart");
                btnStart.PerformClick();
            }
        }

        /// <summary>
        /// Start monitoring
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // If the port is open, close it.
            if (Hardware.IsOpen())
            {
                if (!Hardware.stopReadData())
                {
                    Logging.Log("Could not close the COM port [" + Hardware.comport.PortName + "]");
                    LogForm.txtLog.Text += "Could not close the COM port [" + Hardware.comport.PortName + "]\r\n";
                    MessageBox.Show(this, "Could not close the COM port [" + Hardware.comport.PortName + "]", "COM Port couldn't be closed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    btnStart.Text = "Start";
                    timer1.Enabled = false;
                    Logging.Log("Monitoring on [" + Hardware.comport.PortName + "] was stopped");
                    LogForm.txtLog.Text += "Monitoring on [" + Hardware.comport.PortName + "] was stopped\r\n";
                    Logging.CloseLogFile();
                }
            }
            else
            {
                if (!Hardware.startReadData())
                {
                    Logging.Log("Could not open the COM port [" + Hardware.comport.PortName + "].  Most likely it is already in use, has been removed, or is unavailable.");
                    LogForm.txtLog.Text += "Could not open the COM port [" + Hardware.comport.PortName + "].  Most likely it is already in use, has been removed, or is unavailable.\r\n";
                    MessageBox.Show(this, "Could not open the COM port [" + Hardware.comport.PortName + "].  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else 
                {
                    timer1.Enabled = true;
                    Logging.Log("Monitoring on [" + Hardware.comport.PortName + "] was started");
                    LogForm.txtLog.Text += "Monitoring on [" + Hardware.comport.PortName + "] was started\r\n";
                    btnStart.Text = "Stop";
                }

            }
        }

        private void timer_debug_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();

            Hardware.SerialBuffer = @"Weather station v0.7
[!ver:0.7]
IP: 192.168.1.178

=== New cycle ===
[!!be:1]
Object/Ambient: -4.5/22.1
[!Obj:" + String.Format("{0:N1}", -4.5 + rand.NextDouble() * 10) + @"]
[!Amb:" + String.Format("{0:N1}", 22.5 + rand.NextDouble() * 5) + @"]

Temperature: 26.60C
Pressure: 100462 Pa   753.53 mmHg  
Standard Atmosphere: 0.9915
Altitude: 72.09 M
[!BTe:" + String.Format("{0:N1}", 24.5 + rand.NextDouble() * 5) + @"]
[!Pre:" + String.Format("{0:N0}", 730 + rand.NextDouble() * 50) + @"]

Humidity: 1.00 %	
Temperature: 26.40 C  
Dew point: -34.05 /fast: -33.96 *C
[!DT1:" + String.Format("{0:N1}", 22.5 + rand.NextDouble() * 5) + @"]
[!DH1:" + String.Format("{0:N0}", 30 + rand.NextDouble() * 10) + @"]

Humidity(2): 42.80 %	
Temperature(2): 24.80 C  
Dew point: 11.32 /fast: 11.29 *C
[!DT2:" + String.Format("{0:N1}", 24.0 + rand.NextDouble() * 5) + @"]
[!DH2:" + String.Format("{0:N0}", 10 + rand.NextDouble() * 30) + @"]

Illuminance: 1454.8[0.5x] r:17 s:254 wt:572
[!Lum:" + String.Format("{0:F0}", 1454.8 + rand.NextDouble() * 1000) + @"]
[!Lur:17]
[!Lus:254]
[!Luw:572]

Inside t: 23.00C Outside t: 39.25C 
[!Te1:" +String.Format("{0:N1}",23.0+rand.NextDouble()*5)+@"]
[!Te2:" + String.Format("{0:N1}", 26.0 + rand.NextDouble() * 10) + @"]

Wetsensor analog value: 1022     digital value: 1
[!Wet:" + String.Format("{0:F0}", 1022 - rand.NextDouble() * 10) + @"]

Rain Gauge counter: 
[!RGC:" + String.Format("{0:N0}", 0 + rand.NextDouble() * 3) + @"]

[!!en:1]
waiting 10000
";
            //WebServices.sendDataToNetMon("");
            timer1_Tick(sender,e);
        }

        
        /// <summary>
        /// Timer ticking - main function in the form interface; used to check the buffer every second
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {

            //Check if data receiving (whatchdog)
            if (Hardware.WatchDog && !SimulationMode) Hardware.CheckIfDataReceiving();
            
            //Parse data
            Hardware.ParseData2(Hardware.SerialBuffer);

            //Logging.Log(Hardware.SerialBuffer);

            //output buffer to Log window
            LogForm.txtLog.Text += Hardware.SerialBuffer;

            //Cut log window contents if it is greater then MAX_LOG_LENGTH
            if (LogForm.txtLog.Text.Length > MAX_LOG_LENGTH)
            {
                LogForm.txtLog.Text = LogForm.txtLog.Text.Substring(LogForm.txtLog.Text.Length - MAX_LOG_LENGTH);
            }
            
            //clear current buffer
            Hardware.SerialBuffer = "";

            //Refresh form values
            RefreshFormFields2();

            //Refresh form values
            RefreshBoltwoodFields();
            
            //Refresh graph
            refreshGraphs();
            
            //Send data to web
            SendDataToWeb2();
        }


        /// <summary>
        /// Show preferences form
        /// </summary>
        private void btnPreferences_Click(object sender, EventArgs e)
        {
            PreferencesForm PrefForm = new PreferencesForm(this);
            PrefForm.ShowDialog();
            PrefForm.Close();
        }


        private void btnLogWindow_Click(object sender, EventArgs e)
        {
            LogForm.Show();
        }

        private void RefreshFormFields_obsolete()
        {
            txtObj.Text = Convert.ToString(Hardware.ObjTemp);
            txtATemp.Text = Convert.ToString(Hardware.ATemp);

            txtCloudIndex1.Text = Convert.ToString(Hardware.CloudIdx);
            txtCloudIndex2.Text = Convert.ToString(Math.Round(Hardware.CloudIdxCorr,2));

            txtBTemp.Text = Convert.ToString(Hardware.BTemp);
            txtPress.Text = Convert.ToString(Hardware.Press);

            txtHum1.Text = Convert.ToString(Hardware.Hum1);
            txtDTemp1.Text = Convert.ToString(Hardware.DTemp1);
            
            txtHum2.Text = Convert.ToString(Hardware.Hum2);
            txtDTemp2.Text = Convert.ToString(Hardware.DTemp2);

            txtIllum.Text = Convert.ToString(Hardware.Illum);
            txtLumRes.Text = Convert.ToString(Hardware.LumRes);
            txtLumSen.Text = Convert.ToString(Hardware.LumSens);
            txtLumWTime.Text = Convert.ToString(Hardware.LumWTime);

            switch (Hardware.LumRes)
            {
                case 16: txtIllumRes.Text = "1x"; break;
                case 17: txtIllumRes.Text = "0.5x"; break;
                case 19: txtIllumRes.Text = "4x"; break;
            }

            txtWet.Text = Convert.ToString(Hardware.Wet);
            txtRGC.Text = Convert.ToString(Hardware.RGC);

            txtTemp1.Text = Convert.ToString(Hardware.Temp1);
            txtTemp2.Text = Convert.ToString(Hardware.Temp2);
        
        }

        private void RefreshFormFields2()
        {

            //Include all sensor that needed to web query
            int SensIdx = -1;
            foreach (SensorElement DataSensor in Hardware.SensorsArray)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.SensorFormField != "")
                    {
                        TextBox SensVal = this.Controls.Find(DataSensor.SensorFormField, true).FirstOrDefault() as TextBox;
                        SensVal.Text = Convert.ToString(DataSensor.LastValue);
                    }
                }
            }

            //Calculated fields
            txtCloudIndex1.Text = Convert.ToString(Hardware.CloudIdx);
            txtCloudIndex2.Text = Convert.ToString(Math.Round(Hardware.CloudIdxCorr, 2));
        }


        private void RefreshBoltwoodFields()
        {
            txtCloudCond.Text = Convert.ToString(Hardware.Bolt_CloudCond);
            txtRainCond.Text = Convert.ToString(Hardware.Bolt_RainCond);
            txtDayCond.Text = Convert.ToString(Hardware.Bolt_DaylighCond);
            txtRainflag.Text = Convert.ToString(Hardware.Bolt_RainFlag);
            txtWetflag.Text = Convert.ToString(Hardware.Bolt_WetFlag);

            if (Hardware.Bolt_CloudCond == CloudCond.cloudClear)
            {
                txtCloudCond.ForeColor = Color.Black;
            }
            else if (Hardware.Bolt_CloudCond == CloudCond.cloudCloudy)
            {
                txtCloudCond.ForeColor = Color.Blue;
            }
            else if (Hardware.Bolt_CloudCond == CloudCond.cloudVeryCloudy)
            {
                txtCloudCond.ForeColor = Color.Red;
            }

            if (Hardware.Bolt_RainCond == RainCond.rainDry){
                txtRainCond.ForeColor = Color.Black;
            }else if (Hardware.Bolt_RainCond == RainCond.rainWet){
                txtRainCond.ForeColor = Color.Blue;
            }else if (Hardware.Bolt_RainCond == RainCond.rainRain){
                txtRainCond.ForeColor = Color.Red;
            }

            if (Hardware.Bolt_DaylighCond == DayCond.dayDark)
            {
                txtDayCond.ForeColor = Color.Black;
            }
            else if (Hardware.Bolt_DaylighCond == DayCond.dayLight)
            {
                txtDayCond.ForeColor = Color.Blue;
            }
            else if (Hardware.Bolt_DaylighCond == DayCond.dayVeryLight)
            {
                txtDayCond.ForeColor = Color.PaleGoldenrod;
            }

        }

        private void SendDataToWeb()
        {
            //Send data to custom site
            if (WebServices.WebDataFlag)
            {
                Hardware.Web_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string queryst = "date=" + Hardware.Web_date + "&ot=" + Convert.ToString(Hardware.ObjTemp) + "&at=" + Convert.ToString(Hardware.ATemp) +
                    "&bp=" + Convert.ToString(Hardware.Press) + "&bt=" + Convert.ToString(Hardware.BTemp) + "&dh=" + Convert.ToString(Hardware.Hum1) +
                    "&dt=" + Convert.ToString(Hardware.DTemp1) + "&dh2=" + Convert.ToString(Hardware.Hum2) + "&dt2=" + Convert.ToString(Hardware.DTemp2) +
                    "&bhv=" + Convert.ToString(Hardware.Illum) + "&bhs=" + Convert.ToString(Hardware.LumSens) + "&bhr=" + Convert.ToString(Hardware.LumRes) +
                    "&bhw=" + Convert.ToString(Hardware.LumWTime) + "&owt1=" + Convert.ToString(Hardware.Temp1) + "&owt2=" + Convert.ToString(Hardware.Temp2) +
                    "&wsv=" + Convert.ToString(Hardware.Wet) + "&rgc=" + Convert.ToString(Hardware.RGC);
                WebServices.sendToServer(queryst);
            }
        }

        /// <summary>
        /// Send Data to web wrapper
        /// </summary>
        private void SendDataToWeb2()
        {
            if (WebServices.WebDataFlag)
            {
                SendDataToCustomSite();
            }

            if (WebServices.SendToNarodmonFlag && WebServices.SinceLastNarodMonDataSent() > WebServices.LIMIT_NARODMON_SEND_INTERVAL)
            {
                SendDataToNarodmon();
            }
        }

        /// <summary>
        /// SEND DATA TO CUSTOM WEBSITE
        /// Using SensorArray
        /// </summary>
        private void SendDataToCustomSite()
        {
            string webstr = "";
            Hardware.Web_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Include all sensor that needed to web query
            int SensIdx = -1;
            foreach (SensorElement DataSensor in Hardware.SensorsArray)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.SendToWebFlag)
                        webstr += "&" + DataSensor.WebCustomName + "=" + Convert.ToString(DataSensor.LastValue);
                }
            }

            //Send web query
            string queryst = "date=" + Hardware.Web_date + webstr;
            WebServices.sendToServer(queryst);
        }


        /// <summary>
        /// SEND DATA TO NARODMON WEBSITE
        /// Using SensorArray
        /// </summary>
        private void SendDataToNarodmon()
        {
            //Присвоить прочитанное значение нужному сенсору
            string DevPrefix = WebServices.Narodmon_MAC.Replace("-", "");
            string narodmonst="";

            int SensIdx = -1;
            foreach (SensorElement DataSensor in Hardware.SensorsArray)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.SendToNarodMon)
                    {
                        if (Hardware.CheckData(Convert.ToDouble(DataSensor.LastValue), DataSensor.SensorType))
                        {
                            narodmonst += (narodmonst != "" ? "&" : "") + DevPrefix + SensIdx.ToString("D2") + "=" + Convert.ToString(DataSensor.LastValue);
                        }
                    }
                                
                }
            }                

            WebServices.sendDataToNetMon(narodmonst);
        }

        private void refreshGraphs()
        {
            curX = DateTime.Now;
            //Graph1 & 2
            if (Hardware.CheckData(Convert.ToDouble(txtObj.Text), SensorTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), SensorTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtCloudIndex1.Text), SensorTypeEnum.Temp)) { 
                addGraphicsPoint(chart1, 0, curX, Convert.ToDouble(txtCloudIndex1.Text)); 
            }
            if (Hardware.CheckData(Convert.ToDouble(txtObj.Text), SensorTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), SensorTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtCloudIndex2.Text), SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 1, curX, Convert.ToDouble(txtCloudIndex2.Text));
            }
            if (Hardware.CheckData(Convert.ToDouble(txtObj.Text), SensorTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 2, curX, Convert.ToDouble(txtObj.Text)); 
            }

            //Graph3
            if (Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), SensorTypeEnum.Temp)) { 
                addGraphicsPoint(chart1, 3, curX, Convert.ToDouble(txtTemp1.Text)); }
            if (Hardware.CheckData(Convert.ToDouble(txtTemp2.Text), SensorTypeEnum.Temp)) { 
                addGraphicsPoint(chart1, 4, curX, Convert.ToDouble(txtTemp2.Text)); 
            }
/*            if (Hardware.CheckData(Convert.ToDouble(txtTemp2.Text), SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 5, curX, Convert.ToDouble(txtATemp.Text));
            }*/

            //Graph4
            if (Hardware.CheckData(Convert.ToDouble(txtWet.Text), SensorTypeEnum.Wet)) { 
                addGraphicsPoint(chart1, 6, curX, (1024 - Convert.ToInt16(txtWet.Text))); }
            if (Hardware.CheckData(Convert.ToDouble(txtRGC.Text), SensorTypeEnum.RGC))
            {
                addGraphicsPoint(chart1, 7, curX, Convert.ToInt16(txtRGC.Text));
            }
            if (Hardware.CheckData(Convert.ToDouble(txtHum1.Text), SensorTypeEnum.Hum))
            { 
                addGraphicsPoint(chart1, 8, curX, Convert.ToDouble(txtHum1.Text)); }
            if (Hardware.CheckData(Convert.ToDouble(txtHum2.Text), SensorTypeEnum.Hum))
            {
                addGraphicsPoint(chart1, 10, curX, Convert.ToDouble(txtHum2.Text));
            }

            //Graph5
            if (Hardware.CheckData(Convert.ToDouble(txtIllum.Text), SensorTypeEnum.Illum))
            {
                addGraphicsPoint(chart1, 9, curX, Convert.ToDouble(txtIllum.Text));
            }

        }


        private void addGraphicsPoint(Chart CurChart, int seriesNum, DateTime XVal, double YVal)
        {

            //curX=DateTime.Now;
            CurChart.Series[seriesNum].Points.AddXY(XVal, YVal);

            
            // Keep a constant number of points by removing them from the left
            if (CurChart.Series[seriesNum].Points.Count > maxNumberOfPointsInChart)
            {
                // Remove data points on the left side
                while (CurChart.Series[seriesNum].Points.Count > maxNumberOfPointsInChart)
                {
                    CurChart.Series[seriesNum].Points.RemoveAt(0);
                }

                // Adjust X axis scale
                //CurChart.ChartAreas[0].AxisX.Minimum = curX - maxNumberOfPointsInChart;
                //CurChart.ChartAreas[0].AxisX.Maximum = CurChart.ChartAreas[0].AxisX.Minimum + maxNumberOfPointsInChart;
            }
            
            // Adjust Y & X axis scale
            CurChart.ResetAutoValues();            
            
            // Invalidate chart
            CurChart.Invalidate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(this, "Exit", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if (!Hardware.stopReadData())
            {
                Logging.Log("Could not close the COM port");
                LogForm.txtLog.Text += "Could not close the COM port\r\n";
            }
            Logging.Log("Application closed");
            Logging.CloseLogFile();
            LogForm.txtLog.Text += "Application closed\r\n";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (timer_debug.Enabled)
            {
                btnSimulate.Text = "Simulation";
                timer_debug.Enabled = false;
                SimulationMode = false;
                Logging.Log("Monitoring simulation was stopped");
                LogForm.txtLog.Text += "Monitoring simulation was stopped\r\n";
                Logging.CloseLogFile();
            }else{
                timer_debug.Enabled = true;
                Logging.Log("Monitoring simulation was started");
                SimulationMode = true;
                LogForm.txtLog.Text += "Monitoring simulation was started\r\n";
                btnSimulate.Text = "Stop simulation";
            }
            
            
        }

        public void LoadParams()
        {
            Hardware.PortName = Properties.Settings.Default.comport;
            Hardware.WatchDog = Properties.Settings.Default.ComWatchdog;

            Hardware.CLOUDINDEX_CLEAR = Convert.ToDouble(Properties.Settings.Default.Clearsky);
            Hardware.CLOUDINDEX_CLOUDY = Convert.ToDouble(Properties.Settings.Default.Cloudysky);

            Hardware.K1 = Convert.ToDouble(Properties.Settings.Default.K1);
            Hardware.K2 = Convert.ToDouble(Properties.Settings.Default.K2);
            Hardware.K3 = Convert.ToDouble(Properties.Settings.Default.K3);
            Hardware.K4 = Convert.ToDouble(Properties.Settings.Default.K4);
            Hardware.K5 = Convert.ToDouble(Properties.Settings.Default.K5);
            Hardware.K6 = Convert.ToDouble(Properties.Settings.Default.K6);
            Hardware.K7 = Convert.ToDouble(Properties.Settings.Default.K7);

            Hardware.RAININDEX_WET_LIMIT = Convert.ToDouble(Properties.Settings.Default.WetLimit);
            Hardware.RAININDEX_RAIN_LIMIT = Convert.ToDouble(Properties.Settings.Default.RainLimit);

            maxNumberOfPointsInChart = Convert.ToInt16(Properties.Settings.Default.MaxPoints);
            timer1.Interval = Convert.ToInt16(Properties.Settings.Default.RefreshInterval);
            timer_debug.Interval = Convert.ToInt16(Properties.Settings.Default.RefreshInterval);

            WebServices.WebDataFlag = Properties.Settings.Default.WebDataFlag;
            WebServices.siteipURL = Properties.Settings.Default.WebDataURL;

            WebServices.SendToNarodmonFlag = Properties.Settings.Default.SendToNarodmon;
            WebServices.Narodmon_MAC = Properties.Settings.Default.Narodmon_MAC;

            Logging.LogFilePath = Properties.Settings.Default.logFileLocation;
            Logging.DataFilePath = Properties.Settings.Default.CSVFileLocation;
            Logging.BoltwoodFilePath = Properties.Settings.Default.BoltwoodFileLocation;

            Logging.LogFileFlag = Properties.Settings.Default.logFileFlag;
            Logging.DataFileFlag = Properties.Settings.Default.CSVFileFlag;
            Logging.BoltwoodFileFlag = Properties.Settings.Default.BoltwoodFileFlag;
        }


    }
}
