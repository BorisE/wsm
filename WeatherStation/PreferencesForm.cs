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

namespace WeatherStation
{
    public partial class PreferencesForm : Form
    {
        private MainForm ParentMainForm;
        public PreferencesForm(MainForm MF)
        {
            InitializeComponent();
            ParentMainForm = MF;
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            //READ COM PORT LIST
            foreach (string s in SerialPort.GetPortNames())
                cmbPortList.Items.Add(s);

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

            //POPULATE SENSOR DATAGRID
            PopulateSensorListGrid();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //Store to vars main hardware settings
                ParentMainForm.Hardware.PortName = cmbPortList.Text;
                ParentMainForm.Hardware.WatchDog = chkWatchdog.Checked;

                ParentMainForm.Hardware.CLOUDINDEX_CLEAR = Convert.ToDouble(txtClearsky.Text);
                ParentMainForm.Hardware.CLOUDINDEX_CLOUDY = Convert.ToDouble(txtCloudysky.Text);

                ParentMainForm.Hardware.K1 = Convert.ToDouble(txtK1.Text);
                ParentMainForm.Hardware.K2 = Convert.ToDouble(txtK2.Text);
                ParentMainForm.Hardware.K3 = Convert.ToDouble(txtK3.Text);
                ParentMainForm.Hardware.K4 = Convert.ToDouble(txtK4.Text);
                ParentMainForm.Hardware.K5 = Convert.ToDouble(txtK5.Text);
                ParentMainForm.Hardware.K6 = Convert.ToDouble(txtK6.Text);
                ParentMainForm.Hardware.K7 = Convert.ToDouble(txtK7.Text);

                ParentMainForm.Hardware.RAININDEX_WET_LIMIT = Convert.ToDouble(txtWetLimit.Text);
                ParentMainForm.Hardware.RAININDEX_RAIN_LIMIT = Convert.ToDouble(txtRainLimit.Text);

                //Store to vars main interface settings
                ParentMainForm.maxNumberOfPointsInChart = Convert.ToInt16(txtMaxPoints.Text);
                ParentMainForm.timer1.Interval = Convert.ToInt16(txtRefreshInterval.Text);
                ParentMainForm.timer_debug.Interval = Convert.ToInt16(txtRefreshInterval.Text);

                //Store webservice settings
                WebServices.WebDataFlag = chkWebData.Checked;
                WebServices.siteipURL = txtWebDataURL.Text;

                WebServices.SendToNarodmonFlag = chkNarodMon.Checked;
                WebServices.Narodmon_MAC = txtNarodmonMAC.Text;

                //Store log settings
                Logging.LogFilePath = txtLogFileLocation.Text;
                Logging.SerialLogFilePath = txtSerialLogFileLocation.Text;
                Logging.DataFilePath = txtCSVFileLocation.Text;
                Logging.BoltwoodFilePath = txtBoltwoodFileLocation.Text;

                Logging.LogFileFlag = chkLogFileFlag.Checked;
                Logging.SerialLogFileFlag = chkSerialLogFileFlag.Checked;
                Logging.DataFileFlag = chkCSVFileFlag.Checked;
                Logging.BoltwoodFileFlag = chkBoltwoodFileFlag.Checked;

                //Store to vars base temp sensor settings
                string BaseTempSt = (string)cmbBaseTempSensor.SelectedItem;
                int curSensIndex = 0;
                foreach (SensorElement DataSensor in ParentMainForm.Hardware.SensorsArray)
                {
                    if (DataSensor != null)
                    {
                        curSensIndex++;
                        if (DataSensor.SensorName == BaseTempSt)
                        {
                            ParentMainForm.Hardware.BaseTempIdx = curSensIndex;
                            ParentMainForm.Hardware.BaseTempName = BaseTempSt;
                        }
                    }
                }

                //Save datagrid to Properties.Settings
                //1 - make param strings
                string SensorName = "", SensorType = "", SensorEnabled = "", SendToWeb = "", SendToNarodmon = "", ArduinoName = "", WebCustomName="";
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


                }
                //2 - store param strings
                Properties.Settings.Default.SensorName = SensorName;
                Properties.Settings.Default.SensorType = SensorType;
                Properties.Settings.Default.SensorEnabled = SensorEnabled;
                Properties.Settings.Default.SensorSendToWeb = SendToWeb;
                Properties.Settings.Default.SensorSendToNarodmon = SendToNarodmon;
                Properties.Settings.Default.SensorArduinoName = ArduinoName;
                Properties.Settings.Default.SensorWebCustomName = WebCustomName;

                //3 - commit changes
                Properties.Settings.Default.Save();

                //4 - reload data from AppSettings into SensorArray
                LoadSensorArrayFromSettings();

                Logging.Log("Preferences was saved");

                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(this, "IOException source: " + ex.Data+" "+ex.Message, "Wrong value", MessageBoxButtons.OK);
            }
        }

        private void btnLogPathBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Button bttn = (Button)sender;
                string DialogPath = folderBrowserDialog.SelectedPath;
                if (DialogPath.Substring(DialogPath.Length-1, 1) != "\\") DialogPath = DialogPath + "\\";

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
            myString=Regex.Replace(myString, ".{2}", "$0-");
            txtNarodmonMAC.Text = (myString.Substring(myString.Length - 1, 1) == "-" ? myString.Substring(0, myString.Length - 1) : myString);
        }

        private void btnResetSensorList_Click(object sender, EventArgs e)
        {
            //Clear current values
            Array.Clear(ParentMainForm.Hardware.SensorsArray, 0, ParentMainForm.Hardware.SensorsArray.Length);

            //Load default values
            ParentMainForm.Hardware.initSensorArray();

            //POPULATE DATAGRID
            PopulateSensorListGrid();
        }

        /// <summary>
        /// Load sensor data from Application.Settings into SensorsArray
        /// </summary>
        private void LoadSensorArrayFromSettings()
        {
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

            if (SensorName != "")
            {
                //Clear default values
                Array.Clear(ParentMainForm.Hardware.SensorsArray, 0, ParentMainForm.Hardware.SensorsArray.Length);

                //Fill in new from Settings
                Int16 nI = -1;
                foreach (string SName in SensorNameArr)
                {
                    if (SName != "")
                    {
                        nI++;
                        ParentMainForm.Hardware.SensorsArray[nI] = new SensorElement();
                        ParentMainForm.Hardware.SensorsArray[nI].SensorName = SName;
                        ParentMainForm.Hardware.SensorsArray[nI].SensorType = ParentMainForm.Hardware.SensorTypeEnum_Dict[SensorTypeArr[nI]];
                        ParentMainForm.Hardware.SensorsArray[nI].Enabled = Convert.ToBoolean(SensorEnabledArr[nI]);
                        ParentMainForm.Hardware.SensorsArray[nI].SendToWebFlag = Convert.ToBoolean(SendToWebArr[nI]);
                        ParentMainForm.Hardware.SensorsArray[nI].SendToNarodMon = Convert.ToBoolean(SendToNarodmonArr[nI]);
                        //ParentMainForm.Hardware.SensorsArray[nI].SensorFormField = "";
                        ParentMainForm.Hardware.SensorsArray[nI].SensorArduinoField = ArduinoNameArr[nI];
                        ParentMainForm.Hardware.SensorsArray[nI].WebCustomName = WebCustomNameArr[nI];
                    }
                }
            }

        }


        /// <summary>
        /// Populate data grid with sensor data from SensorArray
        /// </summary>
        private void PopulateSensorListGrid()
        {
            int curRowIndex = 0;
            dataGridSensors.Rows.Clear();
            foreach (SensorElement DataSensor in ParentMainForm.Hardware.SensorsArray)
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
                    

                    //FILL IN TEMP SENSORS
                    if (DataSensor.SensorType == SensorTypeEnum.Temp)
                    {
                        cmbBaseTempSensor.Items.Add(DataSensor.SensorName);
                    }
                }
            }

        }

        private void btnReadFromSerial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }
    }
}
