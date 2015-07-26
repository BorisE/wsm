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
using System.Text.RegularExpressions;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Globalization;
using System.Threading;
using System.Resources;

///////////////////////////////////////////
// How to add new settigs:
// 1. Add form element
// 2. Link element through Data/ApplicationSetting/text (or checked, or ...) to setting provider element
// 3. Add writing from element to var in btnOk_Click event
// 4. Add to LoadParams() in MainForm initial var setting from setting provider
// 
// For combobox with selectindex
// 2. DO NOT MAKE LINKING TO Application/Settings
// 3.1 Add writting from element to var in btnOk_Click event
// 3.2 Add writting from element to Properties.Settings.Default.####
// 4. Add to LoadParams() in MainForm initial var setting from setting provider
// 5. Add to SettingsForm.Show() initializing combobox selectedindex from var
///////////////////////////////////////////

namespace WeatherStation
{
    public partial class SettingsForm : Form
    {
        private MainForm ParentMainForm;

        ResourceManager LocRM;

        public SettingsForm(MainForm MF)
        {
            ParentMainForm = MF;
            LocRM = new ResourceManager("WeatherStation.WinFormStrings", Assembly.GetExecutingAssembly()); //create resource manager

            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Logging.Log("Preferences Form load starting...", 3);

            //READ COM PORT LIST
            cmbPortList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                cmbPortList.Items.Add(s);
            cmbPortList.Items.Add(LocRM.GetString("_WORK_WITH_FILE_SERIAL")); //add File Emulation item
            cmbPortList.Items.Add(LocRM.GetString("_WORK_WITH_SOCKET_SERVER")); //add File Emulation item

            //READ AND FILL SENSOR PARAMETERS
            LoadSensorArrayFromSettings();

            //FILL IN SensorType combobox
            List<string> SensTypesList = new List<string>();
            string st = "";
            foreach (SensorTypeEnum senstype in Enum.GetValues(typeof(SensorTypeEnum)))
            {
                st = senstype.ToString();
                SensTypesList.Add(senstype.ToString());
            }
            (dataGridSensors.Columns["SensorType"] as DataGridViewComboBoxColumn).DataSource = SensTypesList;

            //FILL IN FormField combobox
            List<string> SensFormFieldsList = new List<string>();
            //special value for none
            SensFormFieldsList.Add("(none)");
            st = "";
            string CName = "", CName2 = "", CName3 = "";
            foreach (Control c in ParentMainForm.Controls)
            {
                if (c.HasChildren)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2.HasChildren)
                        {
                            foreach (Control c3 in c2.Controls)
                            {
                                CName3 = c3.Name;
                                if (CName3.Substring(0, 6) == "txtFld")
                                {
                                    SensFormFieldsList.Add(c3.Name);
                                }
                            }
                        }
                        else
                        {
                            CName2 = c2.Name;
                            if (CName2.Substring(0, 6) == "txtFld")
                            {
                                SensFormFieldsList.Add(c2.Name);
                            }
                        }
                    }
                }
                else
                {
                    CName = c.Name;
                    if (CName.Substring(0, 6) == "txtFld")
                    {
                        SensFormFieldsList.Add(c.Name);
                    }
                }
            }
            (dataGridSensors.Columns["FormFieldName"] as DataGridViewComboBoxColumn).DataSource = SensFormFieldsList;

            //POPULATE SENSOR DATAGRID
            PopulateSensorListGrid();

            //set comboboxes
            cmbLogLevel.SelectedIndex = Logging.DEBUG_LEVEL-1;
            cmbWetMode.SelectedIndex = (byte)ParentMainForm.Hardware.RainConditionMode; ;

            //enable/disable serial file emulation/socket data read
            if (ParentMainForm.Hardware.UseFileEmulation || ParentMainForm.Hardware.UseSocketRead)
            {
                cmbPortList_SelectedIndexChanged(this,e);
            }

            cmbLang.DataSource = new CultureInfo[]{
                CultureInfo.GetCultureInfo("en-US"),
                CultureInfo.GetCultureInfo("ru-RU")
            };
            cmbLang.DisplayMember = "NativeName";
            cmbLang.ValueMember = "Name";
            cmbLang.SelectedValue = ParentMainForm.currentLang;

            //Load current value to Rain Gauge Incremental value
            if (ParentMainForm.Hardware.RGC_Cumulative < 0)
            {
                ParentMainForm.Hardware.RGC_Cumulative = Logging.LoadRGCValue(out ParentMainForm.Hardware.RGC_Cumulative_LastReset);
            }
            txtGaugeInc.Text = ParentMainForm.Hardware.RGC_Cumulative.ToString();


            //Workaround about "Controls contained in a TabPage are not created until the tab page is shown, and any data bindings in these controls are not activated until the tab page is shown."
            foreach (TabPage tp in tabControl1.TabPages)
            {
                tp.Show();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Logging.Log("Preferences form saving starting...", 3);

            try
            {
                //Debuglevel combobox
                Properties.Settings.Default.LogLevel = (cmbLogLevel.SelectedIndex+1).ToString();
                Logging.DEBUG_LEVEL = (byte)(cmbLogLevel.SelectedIndex + 1);

                //Store to vars main hardware settings
                ParentMainForm.Hardware.PortName = cmbPortList.Text;
                ParentMainForm.Hardware.WatchDog = chkWatchdog.Checked;
                Logging.Log("Preferences: COMPORT: " + cmbPortList.Text, 2);

                ParentMainForm.Hardware.UseFileEmulation= (cmbPortList.Text == LocRM.GetString("_WORK_WITH_FILE_SERIAL"));
                SerialFromFile.SerialFileNameIn = txtSerialFileIn.Text;
                SerialFromFile.SerialFileNameOut = txtSerialFileOut.Text;

                ParentMainForm.Hardware.UseSocketRead = (cmbPortList.Text == LocRM.GetString("_WORK_WITH_SOCKET_SERVER"));

                ParentMainForm.Hardware.CLOUDMODEL = (radioCloudSensorModel_Classic.Checked ? CloudSensorModel.Classic : CloudSensorModel.AAG);
                Properties.Settings.Default.CloudModelClassic = (radioCloudSensorModel_Classic.Checked);
                Properties.Settings.Default.CloudModelAAG = (radioCloudSensorModel_AAG.Checked);
                Logging.Log("Preferences: CLOUDSENSOR_MODEL: " + ParentMainForm.Hardware.CLOUDMODEL.ToString(), 2);
                
                ParentMainForm.Hardware.CLOUDINDEX_CLEAR = Convert.ToDouble(txtClearsky.Text);
                ParentMainForm.Hardware.CLOUDINDEX_CLOUDY = Convert.ToDouble(txtCloudysky.Text);
                Logging.Log("Preferences: CLOUDINDEX_CLEAR: " + txtClearsky.Text, 2);
                Logging.Log("Preferences: CLOUDINDEX_CLOUDY: " + txtCloudysky.Text, 2);

                ParentMainForm.Hardware.CLOUDINDEXAAG_CLEAR = Convert.ToDouble(txtClearskyAAG.Text);
                ParentMainForm.Hardware.CLOUDINDEXAAG_CLOUDY = Convert.ToDouble(txtCloudyskyAAG.Text);
                Logging.Log("Preferences: CLOUDINDEXAAG_CLEAR: " + txtClearskyAAG.Text, 2);
                Logging.Log("Preferences: CLOUDINDEXAAG_CLOUDY: " + txtCloudyskyAAG.Text, 2);

                //Wet combobox
                Properties.Settings.Default.WetSensorsMode = cmbWetMode.SelectedIndex.ToString();
                ParentMainForm.Hardware.RainConditionMode = (WetSensorsMode)(cmbWetMode.SelectedIndex);



                ParentMainForm.Hardware.K1 = Convert.ToDouble(txtK1.Text);
                ParentMainForm.Hardware.K2 = Convert.ToDouble(txtK2.Text);
                ParentMainForm.Hardware.K3 = Convert.ToDouble(txtK3.Text);
                ParentMainForm.Hardware.K4 = Convert.ToDouble(txtK4.Text);
                ParentMainForm.Hardware.K5 = Convert.ToDouble(txtK5.Text);
                ParentMainForm.Hardware.K6 = Convert.ToDouble(txtK6.Text);
                ParentMainForm.Hardware.K7 = Convert.ToDouble(txtK7.Text);

                ParentMainForm.Hardware.WindSpeed_ZeroSpeedValue = Convert.ToInt16(txtWSpeedZero.Text);

                ParentMainForm.Hardware.RAININDEX_WET_LIMIT = Convert.ToDouble(txtWetLimit.Text);
                ParentMainForm.Hardware.RAININDEX_RAIN_LIMIT = Convert.ToDouble(txtRainLimit.Text);
                Logging.Log("Preferences: RAININDEX_WET_LIMIT: " + txtWetLimit.Text, 2);
                Logging.Log("Preferences: RAININDEX_RAIN_LIMIT: " + txtRainLimit.Text, 2);

                //Wet combobox
                Properties.Settings.Default.WetSensorsMode = cmbWetMode.SelectedIndex.ToString();
                ParentMainForm.Hardware.RainConditionMode = (WetSensorsMode)(cmbWetMode.SelectedIndex);

                ParentMainForm.Hardware.RGC_ONETICK_VALUE = Convert.ToDouble(txtGaugeInc.Text);

                ParentMainForm.Hardware.WINDSPEED_WINDY = Convert.ToDouble(txtWindyLimit.Text);
                ParentMainForm.Hardware.WINDSPEED_VERYWINDY = Convert.ToDouble(txtVeryWindyLimit.Text);
                Logging.Log("Preferences: WINDSPEED_WINDY: " + txtWindyLimit.Text, 2);
                Logging.Log("Preferences: WINDSPEED_VERYWINDY: " + txtVeryWindyLimit.Text, 2);

                //Store heating settings
                ParentMainForm.Hardware.HEATER_CLOUDINDEX_MIN = Convert.ToDouble(txtCSHeatingMin.Text);
                ParentMainForm.Hardware.HEATER_CLOUDINDEX_MAX = Convert.ToDouble(txtCSHeatingMax.Text);
                ParentMainForm.Hardware.HEATER_CS_PAUSE = Convert.ToInt16(txtCSHeaterPauseTime.Text);
                ParentMainForm.Hardware.HEATER_MAX_TEMPERATURE_DELTA = Convert.ToDouble(txtHeaterMaxTemp.Text);
                ParentMainForm.Hardware.HEATER_MAX_DURATION = Convert.ToInt16(txtHeaterMaxDuration.Text);
                ParentMainForm.Hardware.HEATER_WET_START_THRESHOLD = Convert.ToDouble(txtHeaterWetThreshold.Text);
                ParentMainForm.Hardware.CS_NEEDHEATING_MAXDELTA = Convert.ToDouble(txtCSDecreasingMaxDelta.Text);
                ParentMainForm.Hardware.CS_NEEDHEATING_MINDELTA = Convert.ToDouble(txtCSDecreasingMinDelta.Text);


                ParentMainForm.Hardware.HeightAboveSea = Convert.ToDouble(txtHeightAboveSea.Text);

                //Store to vars main interface settings
                ParentMainForm.maxNumberOfPointsInChart = Convert.ToInt32(txtMaxPoints.Text);
                ParentMainForm.timer_main.Interval = Convert.ToInt32(txtRefreshInterval.Text);
                ParentMainForm.timer_debug_changetext.Interval = Convert.ToInt16(txtRefreshInterval.Text);
                ParentMainForm.LogForm.MAX_LOG_LINES = Convert.ToInt32(txtMaxLogWindowLines.Text);

                WebServices.LIMIT_WEB_SEND_INTERVAL = Convert.ToUInt32(txtRefreshWebDataInterval.Text);
                WebServices.LIMIT_NARODMON_SEND_INTERVAL = Convert.ToUInt32(txtRefreshNarodmonInterval.Text);

                ParentMainForm.bMinModeEnabled = chkMinMode.Checked;
                ParentMainForm.bMinimizeToTray = chkTrayIcon.Checked;
                ParentMainForm.bDebugPannels = chkShowDebugPannels.Checked;

                //Language combobox
                ParentMainForm.currentLang = cmbLang.SelectedValue.ToString();
                Properties.Settings.Default.currentLang = ParentMainForm.currentLang;

                //Store webservice settings
                WebServices.WebDataFlag = chkWebData.Checked;
                WebServices.siteipURL = txtWebDataURL.Text;

                WebServices.SendToNarodmonFlag = chkNarodMon.Checked;
                WebServices.Narodmon_MAC = txtNarodmonMAC.Text;

                ParentMainForm.Hardware.AverageDataFlag = chkAverageData.Checked;

                ParentMainForm.SocketServer.serverPort=Convert.ToInt32(txtSocketServerPort.Text);
                bool old_bRunSocketServerFlag = ParentMainForm.bRunSocketServerFlag;
                ParentMainForm.bRunSocketServerFlag = chkSocketServer.Checked;
                if (ParentMainForm.bRunSocketServerFlag && !old_bRunSocketServerFlag)
                //if wasn't checked earlier - run socket server. Can't stop it btw
                {
                    ParentMainForm.RunSocketServer();
                }

                //Store log settings
                Logging.LogFilePath = txtLogFileLocation.Text;
                Logging.SerialLogFilePath = txtSerialLogFileLocation.Text;
                Logging.DataFilePath = txtCSVFileLocation.Text;
                Logging.BoltwoodFilePath = txtBoltwoodFileLocation.Text;

                Logging.LogFileFlag = chkLogFileFlag.Checked;
                Logging.SerialLogFileFlag = chkSerialLogFileFlag.Checked;
                Logging.DataFileFlag = chkCSVFileFlag.Checked;
                Logging.BoltwoodFileFlag = chkBoltwoodFileFlag.Checked;

                //Store to vars base temp sensor settings (COMBOBOX)
                string BaseTempSt = (string)cmbBaseTempSensor.SelectedItem;
                if (ParentMainForm.Hardware.SensorsList.ContainsKey(BaseTempSt))
                {
                    ParentMainForm.Hardware.BaseTempName = BaseTempSt;
                    //ParentMainForm.Hardware.BaseTempIdx = ParentMainForm.Hardware.SensorsArrayHash[BaseTempSt];
                }
                else
                {
                    Logging.Log("Settings error! Base temperature sensor not found (" + BaseTempSt+")");
                }

                Logging.Log("Settings: Base temperature sensor: " + BaseTempSt, 2);

                //Save datagrid to Properties.Settings
                //1 - make param strings
                string SensorName = "", SensorType = "", SensorEnabled = "", SendToWeb = "", SendToNarodmon = "", ArduinoName = "", WebCustomName = "", SensorFieldNames = "";
                foreach (DataGridViewRow SensorRow in dataGridSensors.Rows)
                {

                    /*                    dataGridSensors.Rows[curRowIndex].Cells["SensorName"].Value = DataSensor.SensorName;
                                        dataGridSensors.Rows[curRowIndex].Cells["SensorType"].Value = DataSensor.SensorType.ToString();
                                        dataGridSensors.Rows[curRowIndex].Cells["SensorEnabled"].Value = DataSensor.Enabled;
                                        dataGridSensors.Rows[curRowIndex].Cells["SendToWeb"].Value = DataSensor.SendToWebFlag;
                                        dataGridSensors.Rows[curRowIndex].Cells["SendToNarodmon"].Value = DataSensor.SendToNarodMon;
                                        dataGridSensors.Rows[curRowIndex].Cells["ArduinoName"].Value = DataSensor.SensorArduinoField;
                    */
                    SensorName += SensorRow.Cells["SensorName"].Value + ";";
                    SensorType += SensorRow.Cells["SensorType"].Value + ";";
                    SensorEnabled += SensorRow.Cells["SensorEnabled"].Value + ";";
                    SendToWeb += SensorRow.Cells["SendToWeb"].Value + ";";
                    SendToNarodmon += SensorRow.Cells["SendToNarodmon"].Value + ";";
                    ArduinoName += SensorRow.Cells["ArduinoName"].Value + ";";
                    WebCustomName += SensorRow.Cells["WebCustomName"].Value + ";";
                    SensorFieldNames += SensorRow.Cells["FormFieldName"].Value + ";";

                }
                //2 - store param strings
                Properties.Settings.Default.SensorName = SensorName;
                Properties.Settings.Default.SensorType = SensorType;
                Properties.Settings.Default.SensorEnabled = SensorEnabled;
                Properties.Settings.Default.SensorSendToWeb = SendToWeb;
                Properties.Settings.Default.SensorSendToNarodmon = SendToNarodmon;
                Properties.Settings.Default.SensorArduinoName = ArduinoName;
                Properties.Settings.Default.SensorWebCustomName = WebCustomName;
                Properties.Settings.Default.SensorFieldName = SensorFieldNames;
                //3 - commit changes
                Properties.Settings.Default.Save();

                //4 - reload data from AppSettings into SensorArray
                LoadSensorArrayFromSettings();

                Logging.Log("Sensor names: " + SensorName, 2);
                Logging.Log("Sensor types: " + SensorType, 2);
                Logging.Log("Sensor enabled: " + SensorEnabled, 2);
                Logging.Log("Sensor SendToWeb: " + SendToWeb, 2);
                Logging.Log("Sensor SendToNarodmon: " + SendToNarodmon, 2);
                Logging.Log("Sensor ArduinoName: " + ArduinoName, 2);
                Logging.Log("Sensor WebCustomName: " + WebCustomName, 2);
                Logging.Log("Sensor SensorFieldName: " + SensorFieldNames, 2);

                Logging.Log("Preferences was saved");

                this.Close();
            }
            catch (FormatException ex)
            {
                StackTrace st = new StackTrace(ex, true);
                StackFrame[] frames = st.GetFrames();
                string messstr = "";

                // Iterate over the frames extracting the information you need
                foreach (StackFrame frame in frames)
                {
                    messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                }

                string FullMessage = "Some of the fields has invalid values" + Environment.NewLine;
                FullMessage += Environment.NewLine + "Hint: look for incorrect decimal point ( \".\" instead of \",\" ) or a accidential letter in textbox";
                FullMessage += Environment.NewLine + "Hint 2: clicking in every field could help";
                FullMessage += Environment.NewLine + Environment.NewLine + "Debug information:" + Environment.NewLine + "IOException source: " + ex.Data + " " + ex.Message
                        + Environment.NewLine + Environment.NewLine + messstr;
                MessageBox.Show(this, FullMessage, "Invalid value", MessageBoxButtons.OK);

                Logging.Log(FullMessage);
            }

            //write settings to Arduino
            string OutSt = "";
            ParentMainForm.Hardware.sendParametersToSerial(out OutSt);
            ParentMainForm.Hardware.queryParametersFromSerial();
            ParentMainForm.LogForm.AppendLogText(OutSt);

        }


        private void btnLogPathBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Button bttn = (Button)sender;
                string DialogPath = folderBrowserDialog.SelectedPath;
                if (DialogPath.Substring(DialogPath.Length - 1, 1) != "\\") DialogPath = DialogPath + "\\";

                if (bttn.Name == "btnLogPathBrowse") { txtLogFileLocation.Text = DialogPath; }
                else if (bttn.Name == "btnSerialLogPathBrowse") { txtSerialLogFileLocation.Text = DialogPath; }
                else if (bttn.Name == "btnCSVPathBrowse") { txtCSVFileLocation.Text = DialogPath; }
                else if (bttn.Name == "btnBoltwoodPathBrowse") { txtBoltwoodFileLocation.Text = DialogPath; }

                //Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }


        private void btnGenerateMac_Click(object sender, EventArgs e)
        {
            string myString = WebServices.GetMacAddress();
            myString = Regex.Replace(myString, ".{2}", "$0-");
            txtNarodmonMAC.Text = (myString.Substring(myString.Length - 1, 1) == "-" ? myString.Substring(0, myString.Length - 1) : myString);
        }

        private void btnResetSensorList_Click(object sender, EventArgs e)
        {
            //Load default values
            ParentMainForm.Hardware.initSensorList();

            //POPULATE DATAGRID
            PopulateSensorListGrid();
        }

        /// <summary>
        /// Load sensor data from Application.Settings into SensorsArray
        /// </summary>
        public void LoadSensorArrayFromSettings()
        {
            Logging.Log("Load sensor data from settings...", 3);


            //Read sensor parameters from Settings and split them into arrays
            string SensorName = Properties.Settings.Default.SensorName;
            string[] SensorNameArr = SensorName.Split(';');

            string SensorType = Properties.Settings.Default.SensorType;
            string[] SensorTypeArr = SensorType.Split(';');

            string SensorEnabled = Properties.Settings.Default.SensorEnabled;
            string[] SensorEnabledArr = SensorEnabled.Split(';');

            string SendToWeb = Properties.Settings.Default.SensorSendToWeb;
            string[] SendToWebArr = SendToWeb.Split(';');

            string SendToNarodmon = Properties.Settings.Default.SensorSendToNarodmon;
            string[] SendToNarodmonArr = SendToNarodmon.Split(';');

            string ArduinoName = Properties.Settings.Default.SensorArduinoName;
            string[] ArduinoNameArr = ArduinoName.Split(';');

            string WebCustomName = Properties.Settings.Default.SensorWebCustomName;
            string[] WebCustomNameArr = WebCustomName.Split(';');

            string SensorFieldName = Properties.Settings.Default.SensorFieldName;
            string[] SensorFieldNameArr = SensorFieldName.Split(';');

            if (SensorName != "")
            {
                //Clear default values
                ParentMainForm.Hardware.SensorsList.Clear();

                //Fill in new from Settings
                Int16 nI = -1;
                foreach (string SName in SensorNameArr)
                {
                    if (SName != "")
                    {
                        nI++;
                        
                        SensorElement SensorEl = new SensorElement();

                        SensorEl.SensorName = SName;
                        SensorEl.SensorType = ParentMainForm.Hardware.SensorTypeEnum_Dict[SensorTypeArr[nI]];
                        SensorEl.Enabled = Convert.ToBoolean(SensorEnabledArr[nI]);
                        SensorEl.SendToWebFlag = Convert.ToBoolean(SendToWebArr[nI]);
                        SensorEl.SendToNarodMon = Convert.ToBoolean(SendToNarodmonArr[nI]);
                        //SensorEl.SensorFormField = "";
                        SensorEl.SensorArduinoField = ArduinoNameArr[nI];
                        SensorEl.WebCustomName = WebCustomNameArr[nI];
                        SensorEl.SensorFormField = SensorFieldNameArr[nI];

                        ParentMainForm.Hardware.SensorsList.Add(SensorEl.SensorName, SensorEl);
                    }
                }
            }
            Logging.Log("Preferences: LoadSensorArrayFromSettings(): Sensor data was loaded", 3);

        }


        /// <summary>
        /// Populate data grid with sensor data from SensorArray
        /// </summary>
        private void PopulateSensorListGrid()
        {
            int curRowIndex = 0;
            cmbBaseTempSensor.Items.Clear();
            dataGridSensors.Rows.Clear();
            foreach (SensorElement DataSensor in ParentMainForm.Hardware.SensorsList.Values)
            {
                if (DataSensor != null)
                {
                    //Add sensor to grid
                    curRowIndex = dataGridSensors.Rows.Add();
                    dataGridSensors.Rows[curRowIndex].Cells["SensorName"].Value = DataSensor.SensorName;
                    dataGridSensors.Rows[curRowIndex].Cells["SensorType"].Value = DataSensor.SensorType.ToString();
                    dataGridSensors.Rows[curRowIndex].Cells["SensorEnabled"].Value = DataSensor.Enabled;
                    dataGridSensors.Rows[curRowIndex].Cells["SendToWeb"].Value = DataSensor.SendToWebFlag;
                    dataGridSensors.Rows[curRowIndex].Cells["SendToNarodmon"].Value = DataSensor.SendToNarodMon;
                    dataGridSensors.Rows[curRowIndex].Cells["ArduinoName"].Value = DataSensor.SensorArduinoField;
                    dataGridSensors.Rows[curRowIndex].Cells["WebCustomName"].Value = DataSensor.WebCustomName;
                    dataGridSensors.Rows[curRowIndex].Cells["FormFieldName"].Value = (DataSensor.SensorFormField != "" ? DataSensor.SensorFormField : "(none)");


                    //FILL IN TEMP SENSORS
                    if (DataSensor.SensorType == SensorTypeEnum.Temp)
                    {
                        cmbBaseTempSensor.Items.Add(DataSensor.SensorName);
                    }
                }
            }
            Logging.Log("Preferences: PopulateSensorListGrid(): ended", 3);
        }

        #region Validating handlers ==============================================
        private void txtCheckIntPos_Validating(object sender, CancelEventArgs e)
        {
            txtCheckIntPos_TextChanged(sender, e);
        }

        private void txtCheckIntPos_TextChanged(object sender, EventArgs e)
        {

            TextBox CheckingTB = sender as TextBox;
            // Determine if the TextBox has a digit character.
            string text = CheckingTB.Text;
            bool hasMoreThanDigit = false;
            foreach (char letter in text)
            {
                if (!char.IsDigit(letter))
                {
                    hasMoreThanDigit = true;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (hasMoreThanDigit)
            {
                errorProvider1.SetError(CheckingTB, "Needs to be only a digit");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCheckInt_Validating(object sender, CancelEventArgs e)
        {
            txtCheckInt_TextChanged(sender, e);
        }
        private void txtCheckInt_TextChanged(object sender, EventArgs e)
        {

            TextBox CheckingTB = sender as TextBox;
            // Determine if the TextBox has a digit character.
            string text = CheckingTB.Text;
            bool hasMoreThanDigit = false;
            foreach (char letter in text)
            {
                if (!char.IsDigit(letter) && !(letter == '-' && text.Substring(0, 1) == "-" && (text.Split('-').Length - 1) == 1))
                {
                    hasMoreThanDigit = true;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (hasMoreThanDigit)
            {
                errorProvider1.SetError(CheckingTB, "Needs to be only a digit");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCheckFloatPos_Validating(object sender, CancelEventArgs e)
        {
            txtCheckFloatPos_TextChanged(sender, e);
        }
        private void txtCheckFloatPos_TextChanged(object sender, EventArgs e)
        {

            TextBox CheckingTB = sender as TextBox;
            // Determine if the TextBox has a digit character.
            string text = CheckingTB.Text;
            bool hasMoreThanDigit = false;
            char decSep = Convert.ToChar(CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
            foreach (char letter in text)
            {
                if (!char.IsDigit(letter) && !(letter == decSep && (text.Split(decSep).Length - 1) == 1))
                {
                    hasMoreThanDigit = true;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (hasMoreThanDigit)
            {
                errorProvider1.SetError(CheckingTB, "Needs to be only a digit or decimal point [" + CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator + "]");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCheckFloat_Validating(object sender, CancelEventArgs e)
        {
            txtCheckFloat_TextChanged(sender, e);
        }
        private void txtCheckFloat_TextChanged(object sender, EventArgs e)
        {

        }        
        #endregion Validating handlers ==============================================

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //I forgot why i use this, so i comment it :)
            //e.Cancel = true;
            //this.Hide();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            //Workaround about "Controls contained in a TabPage are not created until the tab page is shown, and any data bindings in these controls are not activated until the tab page is shown."
            foreach (TabPage tp in tabControl1.TabPages)
            {
                tp.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload(); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset all settings to their default values (this can't be undone)?" , "Reset to default values", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            Properties.Settings.Default.Reset(); 
        }

        private void btnGenerateMac_Click_1(object sender, EventArgs e)
        {
            string myString = WebServices.GetMacAddress();
            myString = Regex.Replace(myString, ".{2}", "$0-");
            txtNarodmonMAC.Text = (myString.Substring(myString.Length - 1, 1) == "-" ? myString.Substring(0, myString.Length - 1) : myString);
        }


        /// <summary>
        /// Handle when user choose file serial emulation
        /// </summary>
        private void cmbPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPortList.Text == LocRM.GetString("_WORK_WITH_FILE_SERIAL"))
            {
                txtSerialFileIn.Enabled = true;
                txtSerialFileOut.Enabled = true;
                btnOpenReadFromFile.Enabled = true;
                btnOpenWriteToFile.Enabled = true;

                chkWatchdog.Enabled = false;
            }
            else if (cmbPortList.Text == LocRM.GetString("_WORK_WITH_SOCKET_SERVER"))
            {
                txtSerialFileIn.Enabled = false;
                txtSerialFileOut.Enabled = false;
                btnOpenReadFromFile.Enabled = false;
                btnOpenWriteToFile.Enabled = false;

                chkWatchdog.Enabled = false;

                chkSocketServer.Checked = true;
            }
            else
            {
                txtSerialFileIn.Enabled = false;
                txtSerialFileOut.Enabled = false;
                btnOpenReadFromFile.Enabled = false;
                btnOpenWriteToFile.Enabled = false;

                chkWatchdog.Enabled = true;
            }

        }

        /// <summary>
        /// User press choose file button
        /// </summary>
        private void btnOpenReadFromFile_Click(object sender, EventArgs e)
        {

            DialogResult result = fileChooseDialog.ShowDialog();
  
            if (result == DialogResult.OK)
            {
                Button bttn = (Button)sender;
                string FileNameSt = fileChooseDialog.FileName;
                //if (FileNameSt.Substring(FileNameSt.Length - 1, 1) != "\\") FileNameSt = FileNameSt + "\\";

                if (bttn.Name == "btnOpenReadFromFile") { txtSerialFileIn.Text = FileNameSt; }
                else if (bttn.Name == "btnOpenWriteToFile") { txtSerialFileOut.Text = FileNameSt; }

                //Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        
        
        }

        private void btnSetGaugeInc_Click(object sender, EventArgs e)
        {
            ParentMainForm.Hardware.RGC_Cumulative_LastReset=DateTime.Now;

            try
            {
                ParentMainForm.Hardware.RGC_Cumulative = Convert.ToInt32(txtGaugeInc.Text);
            }
            catch {
                Logging.Log("Hardware.RGC_Cumulative conversion error");
                ParentMainForm.Hardware.RGC_Cumulative = 0;
            }
            
            //Save current RGC cumulative value for narodmon
            Logging.SaveRGCValue((int)ParentMainForm.Hardware.RGC_Cumulative, ParentMainForm.Hardware.RGC_Cumulative_LastReset);
        }

        private void PopulateRainConditions()
        {
        }

        private void btnCalculatePressure_Click(object sender, EventArgs e)
        {
            double Temp = -100.0;
            if (ParentMainForm.Hardware.CheckData(ParentMainForm.Hardware.BaseTempVal, SensorTypeEnum.Temp))
            {
                Temp = ParentMainForm.Hardware.BaseTempVal;
            }
            else
            {
                Temp = 0.0;
            }
            Temp = Convert.ToDouble(txtTempCalc.Text);
            //txtTempCalc.Text = Temp.ToString();
            double Press = ParentMainForm.Hardware.CalcPressureOnHeight(760.0, Convert.ToDouble(txtHeightAboveSea.Text), Temp);
            txtNormalPressure.Text = String.Format("{0:0.0}",Press);
        }


    }
}
