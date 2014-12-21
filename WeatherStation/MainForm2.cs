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
using System.Diagnostics;
using System.Reflection;
using System.Resources;

public enum FormAppearanceMode { MODE_MIN, MODE_MAX };

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
        public LogWindow LogForm;

        /// <summary>
        /// Link to preferences form + functions for loading parameters
        /// </summary>
        //public PreferencesForm PrefForm;

        /// <summary>
        /// Link to preferences form + functions for loading parameters
        /// </summary>
        public SettingsForm SetForm;

        /// <summary>
        /// Link to serial from file methods
        /// </summary>
        //public SerialFromFile SerialFile;

        /// <summary>
        /// Link to NON LOCALISED resource manager
        /// </summary>
        ResourceManager LocRM;

        //For graphs
        private DateTime curX;
        public int maxNumberOfPointsInChart = 8640; //For 24h with 10sec interval
        public int MAX_LOG_LENGTH = 10000;

        private About aboutForm;

        private bool SimulationMode = false;

        private FormAppearanceMode FORM_APPEARANCE_MODE = FormAppearanceMode.MODE_MAX;
        private int Form_Normal_Width  = 0;

        public bool bMinModeEnabled = true;
        public bool bMinimizeToTray = true;
        public bool bDebugPannels = true;

        public int RefreshWebInterval=60;
        public int RefreshNarodmonInterval = 60;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LocRM = new ResourceManager("WeatherStation.WinFormStrings", Assembly.GetExecutingAssembly()); //create resource manager

            LogForm = new LogWindow(this);
            Hardware = new WeatherStationSerial(this);
            //PrefForm = new PreferencesForm(this);
            SetForm = new SettingsForm(this);
            //SerialFile = new SerialFromFile();
        }

        /// <summary>
        /// Form loading
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load current settings

            SetForm.LoadSensorArrayFromSettings();
            LoadParams();

            Logging.Log("Program started",1);

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

            //Debug pannels
            if (!bDebugPannels)
            {
                panelDebug.Visible = false;
            }

            //SWITCH TO MAXIMUM MODE
            Form_Normal_Width = this.Width;
            Form_SwitchTo_Maximum_Mode();
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            //PrefForm.ShowDialog();
            SetForm.ShowDialog();
        }

        private void btnLogWindow_Click(object sender, EventArgs e)
        {
            LogForm.Show();
            LogForm.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutForm = new About(Hardware.SketchVersion, Hardware.SketchVersionDate);
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Start monitoring
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // If the port is open, close it.
            if (Hardware.IsOpened())
            {
                if (!Hardware.stopReadData())
                {
                    Logging.Log("Could not close the COM port [" + Hardware.PortName + "]");
                    LogForm.txtLog.AppendText("Could not close the COM port [" + Hardware.PortName + "]");
                    MessageBox.Show(this, "Could not close the COM port [" + Hardware.PortName + "]", "COM Port couldn't be closed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    btnStart.Text = "Start";
                    btnStart_min.Text = "Start";
                    timer_main.Enabled = false;
                    Logging.Log("Monitoring on [" + Hardware.PortName + "] was stopped");
                    LogForm.txtLog.AppendText("Monitoring on [" + Hardware.PortName + "] was stopped");
                    Logging.CloseLogFile();
                }
                btnRelay.Enabled = false;
            }
            else
            {
                if (!Hardware.startReadData())
                {
                    Logging.Log("Could not open the COM port [" + Hardware.PortName + "].  Most likely it is already in use, has been removed, or is unavailable.");
                    LogForm.txtLog.AppendText("Could not open the COM port [" + Hardware.PortName + "].  Most likely it is already in use, has been removed, or is unavailable.");
                    MessageBox.Show(this, "Could not open the COM port [" + Hardware.PortName + "].  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRelay.Enabled = false;
                }
                else
                {
                    timer_main.Enabled = true;
                    Logging.Log("Monitoring on [" + Hardware.PortName + "] was started");
                    LogForm.AppendLogText("Monitoring on [" + Hardware.PortName + "] was started");
                    btnStart.Text = "Stop";
                    btnStart_min.Text = "Stop";

                    //init Hardware.RGC_Cumulative prev value
                    Hardware.RGC_Cumulative = Logging.LoadRGCValue(out Hardware.RGC_Cumulative_LastReset);

                    btnRelay.Enabled = true;
                }

            }
        }

        /// <summary>
        /// Monitoring Simulation start
        /// Starts two timer ticks:
        /// 1. Simulation of asynchroneous serial data read to buffer:
        ///     - first by timer_debug_changetext tick form BUFFER TEXT in SerialBufferFullSim
        ///     - then start fast timer_debug_portread tick, which emulates arbitrary number of bytes read to Serail Buffer
        /// 2. Working (as in case of productive cycle) with data from Serial Buffer
        /// </summary>
        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (timer_debug_changetext.Enabled)
            {
                btnSimulate.Text = "Simulation start";
                btnStart.Enabled = true;
                btnStart_min.Text = "Start";
                timer_main.Enabled = false;
                timer_debug_changetext.Enabled = false;
                timer_debug_portread.Enabled = false;
                SimulationMode = false;
                Logging.Log("Monitoring simulation was stopped");
                LogForm.AppendLogText("Monitoring simulation was stopped");
                Logging.CloseLogFile();
            }
            else
            {
                timer_main.Enabled = true;
                timer_debug_changetext.Enabled = true;
                //timer_debug_portread.Enabled = true; //this timer is started by timer_debug_changetext tick
                Logging.Log("Monitoring simulation was started");
                SimulationMode = true;
                LogForm.AppendLogText("Monitoring simulation was started");
                btnSimulate.Text = "Stop simulation";
                btnStart_min.Text = "Stop";
                btnStart.Enabled = false;

                //load last value for RGC cumulative
                Hardware.RGC_Cumulative = Logging.LoadRGCValue(out Hardware.RGC_Cumulative_LastReset);
            }
        }

        /// <summary>
        /// Timer ticking - used to make all data manupalation and visualization at given interval
        /// </summary>
        private void timer_main_Tick(object sender, EventArgs e)
        {
            Logging.Log("Main working tick started", 3);

            //Check if data receiving (whatchdog)
            if (Hardware.WatchDog && !SimulationMode) Hardware.CheckIfDataReceiving();

            //Get current buffer for logging
            string curSerialBuffer = Hardware.SerialBuffer;
            //Parse data and make all calculation
            Hardware.LOOP_CYCLE();

            //Write boltwood file (and calculate boltwood fields values)
            if (Properties.Settings.Default.BoltwoodFileFlag)
            {
                Hardware.WriteBolwoodFile();
            }

            //Write CSV Data file
            if (Properties.Settings.Default.CSVFileFlag)
            {
                Hardware.WriteCSV();
            }

            //output buffer to Log window
            LogForm.AppendLogText(curSerialBuffer);

            //Refresh form values
            RefreshFormFields2();

            //Refresh form values
            RefreshBoltwoodFields();

            //Refresh graph
            refreshGraphs();

            //Send data to web
            SendDataToWeb2();

            Logging.Log("Main working tick ended", 3);
        }

        /// <summary>
        /// Sumulation timer 1 - it genereates contents which is later read in portions in timer 2
        /// </summary>
        private void timer_debug_Tick(object sender, EventArgs e)
        {

            Random rand = new Random(DateTime.Now.Millisecond);

            ArduinoSettingsClass El = new ArduinoSettingsClass();

            string ArdSetTD = (Hardware.ArduinoSettings.TryGetValue("TD", out El) ? El.Value : "30");
            string ArdSetWT = (Hardware.ArduinoSettings.TryGetValue("WT", out El) ? El.Value : "1005");
            string ArdSetRT = (Hardware.ArduinoSettings.TryGetValue("RT", out El) ? El.Value : "300");

            int WindSensorVal_sim = rand.Next(83,200);
            double WindSpeedVal_sim = Hardware.calcWindSpeed(WindSensorVal_sim);

            Hardware.SerialBufferFullSim = @"Weather station v0.8sim
[!ver:0.8sim]
[!ved:13082014]
IP: 192.168.1.178

=== New cycle ===
[!!be:1]
[!Obj:" + String.Format("{0:N1}", -4.5 + rand.NextDouble() * 15) + @"]
[!Amb:" + String.Format("{0:N1}", 22.5 + rand.NextDouble() * 5) + @"]

[!BTe:" + String.Format("{0:N1}", 24.5 + rand.NextDouble() * 5) + @"]
[!Pre:" + String.Format("{0:N0}", 730 + rand.NextDouble() * 50) + @"]

[!DT1:" + String.Format("{0:N1}", 22.5 + rand.NextDouble() * 5) + @"]
[!DH1:" + String.Format("{0:N0}", 30 + rand.NextDouble() * 60) + @"]

[!DT2:" + String.Format("{0:N1}", 24.0 + rand.NextDouble() * 5) + @"]
[!DH2:" + String.Format("{0:N0}", 10 + rand.NextDouble() * 30) + @"]

[!Lum:" + String.Format("{0:F0}", 1454.8 + rand.NextDouble() * 1000) + @"]
[!Lur:" + String.Format("{0:N0}", 17) + @"]
[!Lus:" + String.Format("{0:N0}", 254) + @"]
[!Luw:" + String.Format("{0:N0}", 572 )+ @"]

[!Te1:" + String.Format("{0:N1}", 23.0 + rand.NextDouble() * 5) + @"]
[!Te2:" + String.Format("{0:N1}", 26.0 + rand.NextDouble() * 10) + @"]

[!Wet:" + String.Format("{0:F0}", 1022 - rand.NextDouble() * 30) + @"]

[!RGC:" + String.Format("{0:N0}", 0 + rand.NextDouble() * 3) + @"]

[!WnV:" + String.Format("{0:N0}", WindSensorVal_sim) + @"]
[!WnS:" + String.Format("{0:N1}", WindSpeedVal_sim) + @"]

[!RL1:" + String.Format("{0:N0}", 0 + rand.NextDouble()) + @"]

[!?TD:" + ArdSetTD + @"]
[!?WT:" + ArdSetWT + @"]
[!?RT:" + ArdSetRT + @"]

[!!en:1]
waiting 10000
";
            Logging.Log("Simulated text created", 3);
            Hardware.simBufferReadPos = 0;
            timer_debug_portread.Enabled = true; //starts read in portions timer ticks
        }

        /// <summary>
        /// Sumulation timer 2 - it simulates reading data from serial in arbitrary portions into Serial Buffer
        /// </summary>
        private void timer_debug_portread_Tick(object sender, EventArgs e)
        {
            if (Hardware.port_DataReceived_simulated())
            {
                timer_debug_portread.Enabled = false;
                Logging.Log("Simulated text parsed", 3);
            }
        }
        
        /// <summary>
        /// Refresh main and aux form fields
        /// </summary>
        private void RefreshFormFields2()
        {
            Logging.Log("Main.RefreshFormFields2 enter", 3);

            //Include all sensor that needed to display
            int SensIdx = -1;
            foreach (SensorElement DataSensor in Hardware.SensorsArray)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.Enabled && DataSensor.SensorFormField != "")
                    {
                        try
                        {
                            TextBox SensVal = this.Controls.Find(DataSensor.SensorFormField, true)[0] as TextBox;
                            SensVal.Text = Convert.ToString(DataSensor.LastValue);

                            if (DataSensor.SensorName == Hardware.BaseTempName)
                            {
                                SensVal.BorderStyle = BorderStyle.FixedSingle;
                            }
                            else
                            {
                                SensVal.BorderStyle = BorderStyle.Fixed3D;
                            }
                        }
                        catch { }
                    }
                }
            }

            //Calculated fields (custom fields)
            txtCloudIndex1.Text = Convert.ToString(Hardware.CloudIdx);
            txtCloudIndex2.Text = Convert.ToString(Math.Round(Hardware.CloudIdxCorr, 2));
            txtFldWSpeed.Text = Convert.ToString(Hardware.WindSpeedVal);//WindSpeed
            
            //Heating button
            if (Hardware.Relay1==1 && btnRelay.Text == "On")
            {
                btnRelay.Text = "Off";
                btnRelay.BackColor = Color.Red;
                btnIndRelay.BackColor = Color.Red;
            }
            else if (Hardware.Relay1 == 0 && btnRelay.Text == "Off")
            {
                btnRelay.Text = "On";
                btnRelay.BackColor = default(Color);
                btnRelay.UseVisualStyleBackColor = true;
                btnIndRelay.BackColor = default(Color);
                //btnIndRelay.UseVisualStyleBackColor = true;
            }

            //For debug
            try{ txt0min.Text = Convert.ToString(Math.Round(Hardware.SkyIndex5min[0], 1));  }catch { }
            try{ txt5min.Text = Convert.ToString(Math.Round(Hardware.SkyIndex5min[1], 1));  }catch { }
            try{ txt10min.Text = Convert.ToString(Math.Round(Hardware.SkyIndex5min[2], 1)); }catch { }
            try{ txt15min.Text = Convert.ToString(Math.Round(Hardware.SkyIndex5min[3], 1)); }catch { }
            try{ txt20min.Text = Convert.ToString(Math.Round(Hardware.SkyIndex5min[4], 1)); }catch { }

            //Arduino settings for debug
            try { txtArdSetTD.Text = Convert.ToString(Hardware.ArduinoSettings["TD"].Value); }
            catch { }
            try { txtArdSetWT.Text = Convert.ToString(Hardware.ArduinoSettings["WT"].Value); }
            catch { }
            try { txtArdSetRT.Text = Convert.ToString(Hardware.ArduinoSettings["RT"].Value); }
            catch { }


            //Check if sky sensor needed heating
            Hardware.CheckIfSkySensorHeatingNeeded();
            try { 
                txtCSNeedHeating.Text = Convert.ToString(Hardware.CloudSensorNeedHeatingFlag);
                if (Hardware.CloudSensorNeedHeatingFlag)
                {
                    txtCSNeedHeating.BackColor = Color.Cyan;
                }
                else
                {
                    txtCSNeedHeating.BackColor = Color.Empty;
                }
            }
            catch { }

            //Since laset relay on/off
            try { 
                txtSinceHeatingOn.Text = Convert.ToString(Hardware.HeatingOn_SecondsPassed);
                txtSinceHeatingOff.Text = Convert.ToString(Hardware.HeatingOff_SecondsPassed);
                if (Hardware.HeatingOn_SecondsPassed < Hardware.HEATER_CS_PAUSE)
                {
                    txtSinceHeatingOn.ForeColor = Color.Silver;
                }
                else
                {
                    txtSinceHeatingOn.ForeColor = Color.Empty;
                }
                if (Hardware.HeatingOff_SecondsPassed < Hardware.HEATER_CS_PAUSE)
                {
                    txtSinceHeatingOff.ForeColor = Color.Silver;
                }
                else
                {
                    txtSinceHeatingOff.ForeColor = Color.Empty;
                }
            }
            catch { }

            //Rain flags
            //RGC sensor
            try
            {
                if (Hardware.RainNow_RGC_Flag)
                {
                    txtRGCLastMin.Text = "Now";
                    txtRGCLastMin.BackColor = Color.LightSkyBlue;

                    //Save current RGC cumulative value for narodmon
                    Logging.SaveRGCValue((int)Hardware.RGC_Cumulative, Hardware.RGC_Cumulative_LastReset);
                }
                else if (Hardware.RainLastMinute_RGC_Flag)
                {
                    txtRGCLastMin.Text = "Rain";
                    txtRGCLastMin.BackColor = Color.LightSkyBlue;
                }
                else
                {
                    txtRGCLastMin.Text = "-";
                    txtRGCLastMin.BackColor = Color.Empty;
                }
            }
            catch { }
            //Wet sensor
            try
            {
                if (Hardware.RainNow_WetS_FlagC == RainCond.rainRain)
                {
                    txtWetLastMin.Text = "Now";
                    txtWetLastMin.BackColor = Color.LightSkyBlue;
                }
                else if (Hardware.RainLastMinute_WetS_FlagC == RainCond.rainRain)
                {
                    txtWetLastMin.Text = "Rain";
                    txtWetLastMin.BackColor = Color.LightSkyBlue;
                }
                else if (Hardware.RainLastMinute_WetS_FlagC==RainCond.rainWet)
                {
                    txtWetLastMin.Text = "Wet";
                    txtWetLastMin.BackColor = Color.Cyan;
                }
                else
                {
                    txtWetLastMin.Text = "-";
                    txtWetLastMin.BackColor = Color.Empty;
                }
            }
            catch { }
            
            //MAIN Rain flag
            try
            {
                if (Hardware.RainNow_Flag)
                {
                    txtRainLastMinute.Text = "Now";
                    txtRainLastMinute.BackColor = Color.LightSkyBlue;
                    btnIndRain.BackColor = Color.Red;
                }
                else if (Hardware.RainLastMinute_Flag)
                {
                    txtRainLastMinute.Text = "Rain";
                    txtRainLastMinute.BackColor = Color.LightSkyBlue;
                    btnIndRain.BackColor = Color.MistyRose;
                }
                else
                {
                    txtRainLastMinute.Text = "-";
                    txtRainLastMinute.BackColor = Color.Empty;
                    btnIndRain.BackColor = Color.PaleGreen;
                }
            }
            catch { }

            //RG cumulative
            txtFldRGCCumulative.Text = Convert.ToString(Hardware.RGC_Cumulative);

            //Cloud index coloring
            Color CS_color = Color.Blue;
            string[] CS_Colors_arr = new String[9] {"#FF2200", "#DF2F20","#BF3C40", "#9F4860", "#805580", "#60629F", "#406FBF", "#207BDF", "#0088FF"};
            int CS_coloridx = 0;
            if (Hardware.CloudIdx > 20)
            {
                CS_coloridx=8;
            }
            else
            {
                CS_coloridx =  Convert.ToInt16(Math.Max(Math.Floor(Hardware.CloudIdx/3)+1,0));
            }
            CS_color = System.Drawing.ColorTranslator.FromHtml(CS_Colors_arr[CS_coloridx]);
            btnIndCloud.BackColor = CS_color;
            txtCloudIndex1.BackColor = CS_color;

            ///////////////////////////////////////////////////////////////////////////////////////////
            //MINIMUN DATA FIELDS
            txtMinCloudIdx.Text = Convert.ToString(Hardware.CloudIdx);
            txtMinRainIdx.Text = Convert.ToString(Hardware.WetVal);
            txtMinTemp.Text = Convert.ToString(Hardware.BaseTempVal);
            txtMinWind.Text = Convert.ToString(Hardware.WindSpeedVal);//WindSpeed

            Logging.Log("Main.RefreshFormFields2 exit", 3);
        }

        /// <summary>
        /// Refresh boltwood fields
        /// </summary>
        private void RefreshBoltwoodFields()
        {
            txtCloudCond.Text = Convert.ToString(Hardware.Bolt_CloudCond);
            txtRainCond.Text = Convert.ToString(Hardware.Bolt_RainCond);
            txtDayCond.Text = Convert.ToString(Hardware.Bolt_DaylighCond);
            txtRainflag.Text = Convert.ToString(Hardware.Bolt_RainFlag);
            txtWetflag.Text = Convert.ToString(Hardware.Bolt_WetFlag);
            txtWindCond.Text = Convert.ToString(Hardware.Bolt_WindCond);

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

        /// <summary>
        /// Send Data to web wrapper
        /// </summary>
        private void SendDataToWeb2()
        {
            Logging.Log("Main.SendDataToWeb2 enter", 3);
            if (WebServices.WebDataFlag && WebServices.SinceLastDataSent(WebServices.LastWebDataSent) > WebServices.LIMIT_WEB_SEND_INTERVAL)
            {
                SendDataToCustomSite();
            }

            if (WebServices.SendToNarodmonFlag && WebServices.SinceLastDataSent(WebServices.LastNarodMonDataSent) > WebServices.LIMIT_NARODMON_SEND_INTERVAL)
            {
                SendDataToNarodmon();
            }
            Logging.Log("Main.SendDataToWeb2 exit", 3);
        }

        /// <summary>
        /// SEND DATA TO CUSTOM WEBSITE (called from SendDataToWeb2())
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
                    if (DataSensor.Enabled && DataSensor.SendToWebFlag)
                        webstr += "&" + DataSensor.WebCustomName + "=" + Convert.ToString(DataSensor.LastValue);
                }
            }

            //Send web query
            string queryst = "date=" + Hardware.Web_date + webstr;
            WebServices.sendToServer(queryst);
        }

        /// <summary>
        /// SEND DATA TO NARODMON WEBSITE  (called from SendDataToWeb2())
        /// Using SensorArray
        /// </summary>
        private void SendDataToNarodmon()
        {
            //Присвоить прочитанное значение нужному сенсору
            string DevPrefix = WebServices.Narodmon_MAC.Replace("-", "");
            string narodmonst="";

            int SensIdx = 0;
            foreach (SensorElement DataSensor in Hardware.SensorsArray)
            {
                SensIdx++;
                if (DataSensor != null)
                {
                    if (DataSensor.Enabled && DataSensor.SendToNarodMon)
                    {
                        if (Hardware.CheckData(Convert.ToDouble(DataSensor.LastValue), DataSensor.SensorType))
                        {
                            if (DataSensor.SensorName=="RGC"){
                                narodmonst += (narodmonst != "" ? "&" : "") + DevPrefix + SensIdx.ToString("D2") + "=" + Convert.ToString(Hardware.RGC_Cumulative_mm);
                                //Hardware.RGC_Cumulative = 0;
                                //Hardware.RGC_Cumulative_mm = 0;
                            }else{
                                narodmonst += (narodmonst != "" ? "&" : "") + DevPrefix + SensIdx.ToString("D2") + "=" + Convert.ToString(DataSensor.LastValue);
                            }
                        }
                    }
                                
                }
            }

            if (Hardware.CheckData(Convert.ToDouble(Hardware.CloudIdx), SensorTypeEnum.Temp))
            {
                narodmonst += (narodmonst != "" ? "&" : "") + DevPrefix + "00" + "=" + Convert.ToString(Hardware.CloudIdx);
            }

            WebServices.sendDataToNarodmon(narodmonst);
        }

        /// <summary>
        /// Refresh graphical data, using data from SensorArray
        /// </summary>        
        private void refreshGraphs()
        {
            Logging.Log("Main.refreshGraphs enter", 3);

            curX = DateTime.Now;
            //Graph1 & 2
            if (Hardware.CheckData(Hardware.CloudIdx, SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 0, curX, Hardware.CloudIdx); 
            }
            if (Hardware.CheckData(Hardware.CloudIdxCorr, SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 1, curX, Hardware.CloudIdxCorr);
            }
            if (Hardware.CheckData(Hardware.ObjTempVal, SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 2, curX, Hardware.ObjTempVal); 
            }

            //Graph3 (Temperature)
            if (Hardware.CheckData(Hardware.BaseTempVal, SensorTypeEnum.Temp)) {
                addGraphicsPoint(chart1, 3, curX, Hardware.BaseTempVal);
            }
            if (Hardware.CheckData(Hardware.SensorsArray[Hardware.SensorsArrayHash["Temp2"]].LastValue, SensorTypeEnum.Temp)) {
                addGraphicsPoint(chart1, 4, curX, Hardware.SensorsArray[Hardware.SensorsArrayHash["Temp2"]].LastValue); 
            }
            if (Hardware.CheckData(Hardware.SensorsArray[Hardware.SensorsArrayHash["ATemp"]]))
            {
                addGraphicsPoint(chart1, 11, curX, Hardware.SensorsArray[Hardware.SensorsArrayHash["ATemp"]].LastValue);
            }

            /*            if (Hardware.CheckData(Convert.ToDouble(txtTemp2.Text), SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 5, curX, Convert.ToDouble(txtATemp.Text));
            }*/

            //Graph4
            if (Hardware.CheckData(Hardware.SensorsArray[Hardware.SensorsArrayHash["Wet"]].LastValue, SensorTypeEnum.Wet))
            {
                addGraphicsPoint(chart1, 6, curX, (1024 - (int)Hardware.SensorsArray[Hardware.SensorsArrayHash["Wet"]].LastValue));
            }
            if (Hardware.CheckData(Hardware.SensorsArray[Hardware.SensorsArrayHash["RGC"]].LastValue, SensorTypeEnum.RGC))
            {
                addGraphicsPoint(chart1, 7, curX, Hardware.SensorsArray[Hardware.SensorsArrayHash["RGC"]].LastValue);
            }
            if (Hardware.CheckData(Hardware.HumidityVal, SensorTypeEnum.Hum))
            {
                addGraphicsPoint(chart1, 8, curX, Hardware.HumidityVal);
            }
            //if (Hardware.CheckData(Hardware.SensorsArray[Hardware.SensorsArrayHash["Hum2"]].LastValue, SensorTypeEnum.Hum))
            //{
            //    addGraphicsPoint(chart1, 10, curX, Hardware.SensorsArray[Hardware.SensorsArrayHash["Hum2"]].LastValue);
            //}

            //Graph5
            if (Hardware.CheckData(Hardware.IllumVal, SensorTypeEnum.Illum))
            {
                addGraphicsPoint(chart1, 9, curX, Hardware.IllumVal);
            }
            if (Hardware.CheckData(Hardware.SensorsArray[Hardware.SensorsArrayHash["RL1"]]))
            {
                addGraphicsPoint(chart1, 10, curX, Hardware.SensorsArray[Hardware.SensorsArrayHash["RL1"]].LastValue);
            }
            if (Hardware.CheckData(Hardware.WindSpeedVal, SensorTypeEnum.WSp))
            {
                addGraphicsPoint(chart1, "WindSpeed", curX, Hardware.WindSpeedVal);
            }


            ///////////////////////////////////////////////////////////////////////////////////////////
            //MINIMUN GRAPH
            if (Hardware.CheckData(Hardware.CloudIdx, SensorTypeEnum.Temp))
            {
                addGraphicsPoint(chart2, 0, curX, Hardware.CloudIdx);
            }

            Logging.Log("Main.refreshGraphs exit", 3);
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

        /// <summary>
        /// Add graphics point overload method - Series Name instead of Series Num
        /// </summary>
        /// <param name="CurChart"></param>
        /// <param name="serName">Series name</param>
        /// <param name="XVal"></param>
        /// <param name="YVal"></param>
        private void addGraphicsPoint(Chart CurChart, string serName, DateTime XVal, double YVal)
        {
            //curX=DateTime.Now;
            CurChart.Series[serName].Points.AddXY(XVal, YVal);

            // Keep a constant number of points by removing them from the left
            if (CurChart.Series[serName].Points.Count > maxNumberOfPointsInChart)
            {
                // Remove data points on the left side
                while (CurChart.Series[serName].Points.Count > maxNumberOfPointsInChart)
                {
                    CurChart.Series[serName].Points.RemoveAt(0);
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



        /// <summary>
        /// Run on Form closing
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(this, "Exit", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if (!Hardware.stopReadData())
            {
                Logging.Log("Could not close the COM port");
                LogForm.AppendLogText("Could not close the COM port");
            }
            Logging.Log("Application closed");
            Logging.CloseLogFile();
            LogForm.AppendLogText("Application closed");
        }

        /// <summary>
        /// Used to load all prameters during startup
        /// </summary>
        public void LoadParams()
        {
            Logging.Log("Loading saved parameters",3);
            try
            {
                Hardware.PortName = Properties.Settings.Default.comport;
                Hardware.WatchDog = Properties.Settings.Default.ComWatchdog;

                Hardware.UseFileEmulation = (Hardware.PortName == LocRM.GetString("_WORK_WITH_FILE_SERIAL"));                
                SerialFromFile.SerialFileNameIn = Properties.Settings.Default.SerialFileIn;
                SerialFromFile.SerialFileNameOut = Properties.Settings.Default.SerialFileOut;

                Hardware.CLOUDINDEX_CLEAR = Convert.ToDouble(Properties.Settings.Default.Clearsky);
                Hardware.CLOUDINDEX_CLOUDY = Convert.ToDouble(Properties.Settings.Default.Cloudysky);

                Hardware.K1 = Convert.ToDouble(Properties.Settings.Default.K1);
                Hardware.K2 = Convert.ToDouble(Properties.Settings.Default.K2);
                Hardware.K3 = Convert.ToDouble(Properties.Settings.Default.K3);
                Hardware.K4 = Convert.ToDouble(Properties.Settings.Default.K4);
                Hardware.K5 = Convert.ToDouble(Properties.Settings.Default.K5);
                Hardware.K6 = Convert.ToDouble(Properties.Settings.Default.K6);
                Hardware.K7 = Convert.ToDouble(Properties.Settings.Default.K7);

                Hardware.WindSpeed_ZeroSpeedValue = Convert.ToInt16(Properties.Settings.Default.WindSpeed_Zero);

                Hardware.RAININDEX_WET_LIMIT = Convert.ToDouble(Properties.Settings.Default.WetLimit);
                Hardware.RAININDEX_RAIN_LIMIT = Convert.ToDouble(Properties.Settings.Default.RainLimit);

                //Colors color = (Colors)System.Enum.Parse(typeof(Colors), "Green");
                Hardware.RainConditionMode = (WetSensorsMode)Convert.ToByte(Properties.Settings.Default.WetSensorsMode);
                //Hardware.RainConditionMode = (WetSensorsMode)Enum.Parse(typeof(WetSensorsMode), Properties.Settings.Default.WetSensorsMode);
                //Hardware.RainConditionMode = Hardware.WetSensorsModeDictionary[Properties.Settings.Default.WetSensorsMode];
                //Hardware.RainConditionMode = Hardware.WetSensorsModeDictionary[Properties.Settings.Default.WetSensorsMode];

                Hardware.WINDSPEED_WINDY = Convert.ToDouble(Properties.Settings.Default.WindyLimit);
                Hardware.WINDSPEED_VERYWINDY = Convert.ToDouble(Properties.Settings.Default.VeryWindyLimit);


                Hardware.HEATER_MAX_DURATION = Convert.ToInt16(Properties.Settings.Default.HeatingMaxDuration);
                Hardware.HEATER_MAX_TEMPERATURE_DELTA = Convert.ToInt16(Properties.Settings.Default.HeatingMaxTemp);
                Hardware.HEATER_WET_START_THRESHOLD = Convert.ToInt16(Properties.Settings.Default.HeatingWetThreshold);
                Hardware.HEATER_CLOUDINDEX_MIN = Convert.ToDouble(Properties.Settings.Default.HeatingCSThresholdMin);
                Hardware.HEATER_CLOUDINDEX_MAX = Convert.ToDouble(Properties.Settings.Default.HeatingCSThresholdMax);
                Hardware.HEATER_CS_PAUSE = Convert.ToInt16(Properties.Settings.Default.HeatingPauseTime);

                Hardware.CS_NEEDHEATING_MAXDELTA = Convert.ToDouble(Properties.Settings.Default.HeatingCS_MaxDelta);
                Hardware.CS_NEEDHEATING_MINDELTA = Convert.ToDouble(Properties.Settings.Default.HeatingCS_MinDelta);
                Hardware.CS_NEEDHEATING_LOOKBACK_CYCLES = (int)Math.Round(Convert.ToInt16(Properties.Settings.Default.HeatingPauseTime) / 5 / 60.0 - 1, 0);
                

                maxNumberOfPointsInChart = Convert.ToInt16(Properties.Settings.Default.MaxPoints);
                timer_main.Interval = Convert.ToInt16(Properties.Settings.Default.RefreshInterval);
                timer_debug_changetext.Interval = Convert.ToInt16(Properties.Settings.Default.RefreshInterval);
                WebServices.LIMIT_WEB_SEND_INTERVAL = Convert.ToUInt32(Properties.Settings.Default.RefreshWebInterval);
                WebServices.LIMIT_NARODMON_SEND_INTERVAL = Convert.ToUInt32(Properties.Settings.Default.RefreshNarodmonInterval);

                bMinModeEnabled = Properties.Settings.Default.MinModeEnabled;
                bMinimizeToTray = Properties.Settings.Default.MinimizeToSystemTray;
                bDebugPannels = Properties.Settings.Default.ShowDebugPannels;

                WebServices.WebDataFlag = Properties.Settings.Default.WebDataFlag;
                WebServices.siteipURL = Properties.Settings.Default.WebDataURL;

                WebServices.SendToNarodmonFlag = Properties.Settings.Default.SendToNarodmon;
                WebServices.Narodmon_MAC = Properties.Settings.Default.Narodmon_MAC;

                Logging.LogFilePath = Properties.Settings.Default.logFileLocation;
                Logging.DataFilePath = Properties.Settings.Default.CSVFileLocation;
                Logging.BoltwoodFilePath = Properties.Settings.Default.BoltwoodFileLocation;
                Logging.SerialLogFilePath = Properties.Settings.Default.SerialLogFileLocation;

                Logging.LogFileFlag = Properties.Settings.Default.logFileFlag;
                Logging.DataFileFlag = Properties.Settings.Default.CSVFileFlag;
                Logging.BoltwoodFileFlag = Properties.Settings.Default.BoltwoodFileFlag;
                Logging.SerialLogFileFlag = Properties.Settings.Default.SerialLogFileFlag;

                string tempSt = Properties.Settings.Default.LogLevel;
                Logging.DEBUG_LEVEL = Convert.ToByte(tempSt);

                //Load base temp sensor settings
                string BaseTempSt = Properties.Settings.Default.BaseTempSensor;
                if (Hardware.SensorsArrayHash.ContainsKey(BaseTempSt))
                {
                    Hardware.BaseTempName = BaseTempSt;
                    Hardware.BaseTempIdx = Hardware.SensorsArrayHash[BaseTempSt];
                }
                else
                {
                    Logging.Log("Load params error - base temperature sensor not found (" + BaseTempSt + ")");
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

                string FullMessage = "Error loading params. ";
                FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                Logging.Log(FullMessage);
            }
            Logging.Log("Loading saved parameters end", 3);
        }

        /// <summary>
        /// Relay on/off switch
        /// </summary>
        private void btnRelay_Click(object sender, EventArgs e)
        {
            Logging.Log("btnRelay_Click enter", 3);
            if (btnRelay.Text == "On")
            {
                if (!Hardware.HeatingOn())
                {
                    ShowError("Couldn't write to COM port [" + Hardware.comport.PortName + "]");
                }
                else
                {
                    btnRelay.Text = "Off";
                    btnRelay.BackColor = Color.Red;
                }
            }
            else if (btnRelay.Text == "Off")
            {
                if (!Hardware.HeatingOff())
                {
                    ShowError("Couldn't write to COM port [" + Hardware.comport.PortName + "]");
                }
                else
                {
                    btnRelay.Text = "On";
                    btnRelay.BackColor = default(Color);
                    btnRelay.UseVisualStyleBackColor = true;
                }
             }
            Logging.Log("btnRelay_Click exit", 3);
        }

        /// <summary>
        /// Query Arduino settings
        /// </summary>
        private void btnQueryArduinoSettings_Click(object sender, EventArgs e)
        {
            Logging.Log("btnQueryArduinoSettings_Click enter", 3);
            Hardware.WriteSerialData("!?S");
            Logging.Log("btnQueryArduinoSettings_Click exit", 3);
        }


        /// <summary>
        /// Service function to display and log errors
        /// </summary>
        /// <param name="ErrorMsg">Error message</param>
        public void ShowError(string ErrorMsg)
        {
            Logging.Log(ErrorMsg);
            MessageBox.Show(ErrorMsg);
        }

        private void btnStart_min_Click(object sender, EventArgs e)
        {
            if (SimulationMode)
            {
                btnSimulate_Click(sender, e);
            }
            else
            {
                btnStart_Click(sender, e);
            }
        }

        /*********************************************************************************************************************
         * Changing form appearence mode 
        *********************************************************************************************************************/
        #region FORM_APPEREANCE_MODE

        /// <summary>
        /// MINIMUM mode
        /// </summary>
        private void Form_SwitchTo_Minimum_Mode()
        {
            if (!bMinModeEnabled) return;

            //if maximized - switch to normal first
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;

            FORM_APPEARANCE_MODE = FormAppearanceMode.MODE_MIN;

            //hide default pannel
            pannelMaximum.Visible = false;

            //show minimum pannel
            pannelMinimum.Location = new Point(0, 0);
            pannelMinimum.Visible = true;
            
            //change window size
            int borderWidth = (this.Width - this.ClientSize.Width) / 2;
            int titleBarHeight = this.Height - this.ClientSize.Height - 2 * borderWidth;

            this.MinimumSize = new Size(Form_Normal_Width, pannelMinimum.Size.Height + titleBarHeight + borderWidth * 2); ;
            this.MaximumSize = new Size(Form_Normal_Width, pannelMinimum.Size.Height + titleBarHeight + borderWidth*2);
            this.ClientSize = new Size(pannelMinimum.Size.Width, pannelMinimum.Size.Height);

            //change window behaviour
            this.TopMost = true;
            this.Opacity = 1;

        }

        /// <summary>
        /// MAXIMUM mode
        /// </summary>
        private void Form_SwitchTo_Maximum_Mode()
        {
            //if (!bMinModeEnabled) return;

            FORM_APPEARANCE_MODE = FormAppearanceMode.MODE_MAX;

            //hide min pannel
            pannelMinimum.Visible = false;

            //show maximum pannel
            pannelMaximum.Visible = true;

            //change window size
            int borderWidth = (this.Width - this.ClientSize.Width) / 2;
            int titleBarHeight = this.Height - this.ClientSize.Height - 2 * borderWidth;

            this.MinimumSize = new Size(pannelMaximum.Size.Width + borderWidth * 2, pannelMaximum.Size.Height + titleBarHeight + borderWidth * 2);
            this.MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, this.MinimumSize.Height);
            this.ClientSize = new Size(this.ClientSize.Width, pannelMaximum.Size.Height);

            //change window behaviour
            this.TopMost = false;
            this.Opacity = 1;
        }

        /// <summary>
        /// Capture events for Minimize / Maximize event for changing FORM MODE
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            bool stopEvents = false;

            if (m.Msg == 0x0112 && bMinModeEnabled) // WM_SYSCOMMAND and Min mode enabled in settings
            {
                // Check your window state here
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    if (FORM_APPEARANCE_MODE == FormAppearanceMode.MODE_MIN)
                    {
                        Form_SwitchTo_Maximum_Mode();
                        stopEvents = true;
                    };

                }
                else if (m.WParam == new IntPtr(0xF020)) // Minimize event - SC_MINIMIZE from Winuser.h
                {
                    if (FORM_APPEARANCE_MODE == FormAppearanceMode.MODE_MAX)
                    {
                        Form_SwitchTo_Minimum_Mode();
                        stopEvents = true;
                    };
                }
            }

            if (!stopEvents)
            {
                base.WndProc(ref m);
            }
        }

        //Make form in MIN MODE a bit transparent when not in focus
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (FORM_APPEARANCE_MODE == FormAppearanceMode.MODE_MIN)
            {
                this.Opacity = 1;
            }
        }
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (FORM_APPEARANCE_MODE == FormAppearanceMode.MODE_MIN)
            {
                this.Opacity = 0.8;
            }
        }
        #endregion

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState && bMinimizeToTray)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState && bMinimizeToTray)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }



    }
}
