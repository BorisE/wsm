namespace WeatherStation
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtRefreshNarodmonInterval = new System.Windows.Forms.TextBox();
            this.btnGenerateMac = new System.Windows.Forms.Button();
            this.txtRefreshWebDataInterval = new System.Windows.Forms.TextBox();
            this.txtNarodmonMAC = new System.Windows.Forms.TextBox();
            this.txtWebDataURL = new System.Windows.Forms.TextBox();
            this.chkNarodMon = new System.Windows.Forms.CheckBox();
            this.chkWebData = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.chkShowDebugPannels = new System.Windows.Forms.CheckBox();
            this.chkTrayIcon = new System.Windows.Forms.CheckBox();
            this.chkMinMode = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.btnBoltwoodPathBrowse = new System.Windows.Forms.Button();
            this.btnSerialLogPathBrowse = new System.Windows.Forms.Button();
            this.btnCSVPathBrowse = new System.Windows.Forms.Button();
            this.btnLogPathBrowse = new System.Windows.Forms.Button();
            this.txtBoltwoodFileLocation = new System.Windows.Forms.TextBox();
            this.txtLogFileLocation = new System.Windows.Forms.TextBox();
            this.txtSerialLogFileLocation = new System.Windows.Forms.TextBox();
            this.txtCSVFileLocation = new System.Windows.Forms.TextBox();
            this.chkBoltwoodFileFlag = new System.Windows.Forms.CheckBox();
            this.chkSerialLogFileFlag = new System.Windows.Forms.CheckBox();
            this.chkCSVFileFlag = new System.Windows.Forms.CheckBox();
            this.chkLogFileFlag = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRefreshInterval = new System.Windows.Forms.TextBox();
            this.txtMaxPoints = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtSerialFileOut = new System.Windows.Forms.TextBox();
            this.txtSerialFileIn = new System.Windows.Forms.TextBox();
            this.chkWatchdog = new System.Windows.Forms.CheckBox();
            this.btnOpenWriteToFile = new System.Windows.Forms.Button();
            this.btnOpenReadFromFile = new System.Windows.Forms.Button();
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.tabModeling = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtWSpeedZero = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVeryWindyLimit = new System.Windows.Forms.TextBox();
            this.txtWindyLimit = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.K7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.txtK7 = new System.Windows.Forms.TextBox();
            this.txtK3 = new System.Windows.Forms.TextBox();
            this.txtK6 = new System.Windows.Forms.TextBox();
            this.txtK4 = new System.Windows.Forms.TextBox();
            this.txtK5 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbWetMode = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWetLimit = new System.Windows.Forms.TextBox();
            this.txtRainLimit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCloudysky = new System.Windows.Forms.TextBox();
            this.txtClearsky = new System.Windows.Forms.TextBox();
            this.tabSensors = new System.Windows.Forms.TabPage();
            this.dataGridSensors = new System.Windows.Forms.DataGridView();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SensorType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SendToWeb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SendToNarodmon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ArduinoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebCustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormFieldName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBaseTempSensor = new System.Windows.Forms.ComboBox();
            this.btnResetSensorList = new System.Windows.Forms.Button();
            this.btnReadFromSerial = new System.Windows.Forms.Button();
            this.tabHeater = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCSHeaterPauseTime = new System.Windows.Forms.TextBox();
            this.txtCSDecreasingMaxDelta = new System.Windows.Forms.TextBox();
            this.txtCSHeatingMax = new System.Windows.Forms.TextBox();
            this.txtCSDecreasingMinDelta = new System.Windows.Forms.TextBox();
            this.txtCSHeatingMin = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHeaterWetThreshold = new System.Windows.Forms.TextBox();
            this.txtHeaterMaxTemp = new System.Windows.Forms.TextBox();
            this.txtHeaterMaxDuration = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileChooseDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabModeling.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSensors)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tabHeater.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabModeling);
            this.tabControl1.Controls.Add(this.tabSensors);
            this.tabControl1.Controls.Add(this.tabHeater);
            this.errorProvider1.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.errorProvider1.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.MyToolTip.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabGeneral
            // 
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Controls.Add(this.groupBox11);
            this.tabGeneral.Controls.Add(this.groupBox8);
            this.tabGeneral.Controls.Add(this.groupBox3);
            this.tabGeneral.Controls.Add(this.groupBox6);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.errorProvider1.SetError(this.tabGeneral, resources.GetString("tabGeneral.Error"));
            this.errorProvider1.SetIconAlignment(this.tabGeneral, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabGeneral.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabGeneral, ((int)(resources.GetObject("tabGeneral.IconPadding"))));
            this.tabGeneral.Name = "tabGeneral";
            this.MyToolTip.SetToolTip(this.tabGeneral, resources.GetString("tabGeneral.ToolTip"));
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.label33);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Controls.Add(this.txtRefreshNarodmonInterval);
            this.groupBox11.Controls.Add(this.btnGenerateMac);
            this.groupBox11.Controls.Add(this.txtRefreshWebDataInterval);
            this.groupBox11.Controls.Add(this.txtNarodmonMAC);
            this.groupBox11.Controls.Add(this.txtWebDataURL);
            this.groupBox11.Controls.Add(this.chkNarodMon);
            this.groupBox11.Controls.Add(this.chkWebData);
            this.errorProvider1.SetError(this.groupBox11, resources.GetString("groupBox11.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox11, ((int)(resources.GetObject("groupBox11.IconPadding"))));
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox11, resources.GetString("groupBox11.ToolTip"));
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.errorProvider1.SetError(this.label35, resources.GetString("label35.Error"));
            this.errorProvider1.SetIconAlignment(this.label35, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label35.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label35, ((int)(resources.GetObject("label35.IconPadding"))));
            this.label35.Name = "label35";
            this.MyToolTip.SetToolTip(this.label35, resources.GetString("label35.ToolTip"));
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.errorProvider1.SetError(this.label34, resources.GetString("label34.Error"));
            this.errorProvider1.SetIconAlignment(this.label34, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label34.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label34, ((int)(resources.GetObject("label34.IconPadding"))));
            this.label34.Name = "label34";
            this.MyToolTip.SetToolTip(this.label34, resources.GetString("label34.ToolTip"));
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.errorProvider1.SetError(this.label31, resources.GetString("label31.Error"));
            this.errorProvider1.SetIconAlignment(this.label31, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label31.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label31, ((int)(resources.GetObject("label31.IconPadding"))));
            this.label31.Name = "label31";
            this.MyToolTip.SetToolTip(this.label31, resources.GetString("label31.ToolTip"));
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.errorProvider1.SetError(this.label33, resources.GetString("label33.Error"));
            this.errorProvider1.SetIconAlignment(this.label33, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label33.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label33, ((int)(resources.GetObject("label33.IconPadding"))));
            this.label33.Name = "label33";
            this.MyToolTip.SetToolTip(this.label33, resources.GetString("label33.ToolTip"));
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.errorProvider1.SetError(this.label30, resources.GetString("label30.Error"));
            this.errorProvider1.SetIconAlignment(this.label30, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label30.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label30, ((int)(resources.GetObject("label30.IconPadding"))));
            this.label30.Name = "label30";
            this.MyToolTip.SetToolTip(this.label30, resources.GetString("label30.ToolTip"));
            // 
            // txtRefreshNarodmonInterval
            // 
            resources.ApplyResources(this.txtRefreshNarodmonInterval, "txtRefreshNarodmonInterval");
            this.txtRefreshNarodmonInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshNarodmonInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtRefreshNarodmonInterval, resources.GetString("txtRefreshNarodmonInterval.Error"));
            this.errorProvider1.SetIconAlignment(this.txtRefreshNarodmonInterval, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtRefreshNarodmonInterval.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtRefreshNarodmonInterval, ((int)(resources.GetObject("txtRefreshNarodmonInterval.IconPadding"))));
            this.txtRefreshNarodmonInterval.Name = "txtRefreshNarodmonInterval";
            this.txtRefreshNarodmonInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshNarodmonInterval;
            this.MyToolTip.SetToolTip(this.txtRefreshNarodmonInterval, resources.GetString("txtRefreshNarodmonInterval.ToolTip"));
            this.txtRefreshNarodmonInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // btnGenerateMac
            // 
            resources.ApplyResources(this.btnGenerateMac, "btnGenerateMac");
            this.errorProvider1.SetError(this.btnGenerateMac, resources.GetString("btnGenerateMac.Error"));
            this.errorProvider1.SetIconAlignment(this.btnGenerateMac, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnGenerateMac.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnGenerateMac, ((int)(resources.GetObject("btnGenerateMac.IconPadding"))));
            this.btnGenerateMac.Name = "btnGenerateMac";
            this.MyToolTip.SetToolTip(this.btnGenerateMac, resources.GetString("btnGenerateMac.ToolTip"));
            this.btnGenerateMac.UseVisualStyleBackColor = true;
            this.btnGenerateMac.Click += new System.EventHandler(this.btnGenerateMac_Click_1);
            // 
            // txtRefreshWebDataInterval
            // 
            resources.ApplyResources(this.txtRefreshWebDataInterval, "txtRefreshWebDataInterval");
            this.txtRefreshWebDataInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshWebInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtRefreshWebDataInterval, resources.GetString("txtRefreshWebDataInterval.Error"));
            this.errorProvider1.SetIconAlignment(this.txtRefreshWebDataInterval, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtRefreshWebDataInterval.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtRefreshWebDataInterval, ((int)(resources.GetObject("txtRefreshWebDataInterval.IconPadding"))));
            this.txtRefreshWebDataInterval.Name = "txtRefreshWebDataInterval";
            this.txtRefreshWebDataInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshWebInterval;
            this.MyToolTip.SetToolTip(this.txtRefreshWebDataInterval, resources.GetString("txtRefreshWebDataInterval.ToolTip"));
            this.txtRefreshWebDataInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtNarodmonMAC
            // 
            resources.ApplyResources(this.txtNarodmonMAC, "txtNarodmonMAC");
            this.txtNarodmonMAC.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Narodmon_MAC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtNarodmonMAC, resources.GetString("txtNarodmonMAC.Error"));
            this.errorProvider1.SetIconAlignment(this.txtNarodmonMAC, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNarodmonMAC.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtNarodmonMAC, ((int)(resources.GetObject("txtNarodmonMAC.IconPadding"))));
            this.txtNarodmonMAC.Name = "txtNarodmonMAC";
            this.txtNarodmonMAC.Text = global::WeatherStation.Properties.Settings.Default.Narodmon_MAC;
            this.MyToolTip.SetToolTip(this.txtNarodmonMAC, resources.GetString("txtNarodmonMAC.ToolTip"));
            // 
            // txtWebDataURL
            // 
            resources.ApplyResources(this.txtWebDataURL, "txtWebDataURL");
            this.txtWebDataURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WebDataURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtWebDataURL, resources.GetString("txtWebDataURL.Error"));
            this.errorProvider1.SetIconAlignment(this.txtWebDataURL, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtWebDataURL.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtWebDataURL, ((int)(resources.GetObject("txtWebDataURL.IconPadding"))));
            this.txtWebDataURL.Name = "txtWebDataURL";
            this.txtWebDataURL.Text = global::WeatherStation.Properties.Settings.Default.WebDataURL;
            this.MyToolTip.SetToolTip(this.txtWebDataURL, resources.GetString("txtWebDataURL.ToolTip"));
            // 
            // chkNarodMon
            // 
            resources.ApplyResources(this.chkNarodMon, "chkNarodMon");
            this.chkNarodMon.Checked = global::WeatherStation.Properties.Settings.Default.SendToNarodmon;
            this.chkNarodMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNarodMon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "SendToNarodmon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkNarodMon, resources.GetString("chkNarodMon.Error"));
            this.errorProvider1.SetIconAlignment(this.chkNarodMon, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkNarodMon.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkNarodMon, ((int)(resources.GetObject("chkNarodMon.IconPadding"))));
            this.chkNarodMon.Name = "chkNarodMon";
            this.MyToolTip.SetToolTip(this.chkNarodMon, resources.GetString("chkNarodMon.ToolTip"));
            this.chkNarodMon.UseVisualStyleBackColor = true;
            // 
            // chkWebData
            // 
            resources.ApplyResources(this.chkWebData, "chkWebData");
            this.chkWebData.Checked = global::WeatherStation.Properties.Settings.Default.WebDataFlag;
            this.chkWebData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWebData.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "WebDataFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkWebData, resources.GetString("chkWebData.Error"));
            this.errorProvider1.SetIconAlignment(this.chkWebData, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkWebData.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkWebData, ((int)(resources.GetObject("chkWebData.IconPadding"))));
            this.chkWebData.Name = "chkWebData";
            this.MyToolTip.SetToolTip(this.chkWebData, resources.GetString("chkWebData.ToolTip"));
            this.chkWebData.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Controls.Add(this.cmbLang);
            this.groupBox8.Controls.Add(this.chkShowDebugPannels);
            this.groupBox8.Controls.Add(this.chkTrayIcon);
            this.groupBox8.Controls.Add(this.chkMinMode);
            this.errorProvider1.SetError(this.groupBox8, resources.GetString("groupBox8.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox8, ((int)(resources.GetObject("groupBox8.IconPadding"))));
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox8, resources.GetString("groupBox8.ToolTip"));
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.errorProvider1.SetError(this.label38, resources.GetString("label38.Error"));
            this.errorProvider1.SetIconAlignment(this.label38, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label38.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label38, ((int)(resources.GetObject("label38.IconPadding"))));
            this.label38.Name = "label38";
            this.MyToolTip.SetToolTip(this.label38, resources.GetString("label38.ToolTip"));
            // 
            // cmbLang
            // 
            resources.ApplyResources(this.cmbLang, "cmbLang");
            this.errorProvider1.SetError(this.cmbLang, resources.GetString("cmbLang.Error"));
            this.cmbLang.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmbLang, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbLang.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmbLang, ((int)(resources.GetObject("cmbLang.IconPadding"))));
            this.cmbLang.Items.AddRange(new object[] {
            resources.GetString("cmbLang.Items"),
            resources.GetString("cmbLang.Items1")});
            this.cmbLang.Name = "cmbLang";
            this.MyToolTip.SetToolTip(this.cmbLang, resources.GetString("cmbLang.ToolTip"));
            // 
            // chkShowDebugPannels
            // 
            resources.ApplyResources(this.chkShowDebugPannels, "chkShowDebugPannels");
            this.chkShowDebugPannels.Checked = global::WeatherStation.Properties.Settings.Default.ShowDebugPannels;
            this.chkShowDebugPannels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDebugPannels.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "ShowDebugPannels", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkShowDebugPannels, resources.GetString("chkShowDebugPannels.Error"));
            this.errorProvider1.SetIconAlignment(this.chkShowDebugPannels, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkShowDebugPannels.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkShowDebugPannels, ((int)(resources.GetObject("chkShowDebugPannels.IconPadding"))));
            this.chkShowDebugPannels.Name = "chkShowDebugPannels";
            this.MyToolTip.SetToolTip(this.chkShowDebugPannels, resources.GetString("chkShowDebugPannels.ToolTip"));
            this.chkShowDebugPannels.UseVisualStyleBackColor = true;
            // 
            // chkTrayIcon
            // 
            resources.ApplyResources(this.chkTrayIcon, "chkTrayIcon");
            this.chkTrayIcon.Checked = global::WeatherStation.Properties.Settings.Default.MinimizeToSystemTray;
            this.chkTrayIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrayIcon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "MinimizeToSystemTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkTrayIcon, resources.GetString("chkTrayIcon.Error"));
            this.errorProvider1.SetIconAlignment(this.chkTrayIcon, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkTrayIcon.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkTrayIcon, ((int)(resources.GetObject("chkTrayIcon.IconPadding"))));
            this.chkTrayIcon.Name = "chkTrayIcon";
            this.MyToolTip.SetToolTip(this.chkTrayIcon, resources.GetString("chkTrayIcon.ToolTip"));
            this.chkTrayIcon.UseVisualStyleBackColor = true;
            // 
            // chkMinMode
            // 
            resources.ApplyResources(this.chkMinMode, "chkMinMode");
            this.chkMinMode.Checked = global::WeatherStation.Properties.Settings.Default.MinModeEnabled;
            this.chkMinMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "MinModeEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkMinMode, resources.GetString("chkMinMode.Error"));
            this.errorProvider1.SetIconAlignment(this.chkMinMode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkMinMode.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkMinMode, ((int)(resources.GetObject("chkMinMode.IconPadding"))));
            this.chkMinMode.Name = "chkMinMode";
            this.MyToolTip.SetToolTip(this.chkMinMode, resources.GetString("chkMinMode.ToolTip"));
            this.chkMinMode.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbLogLevel);
            this.groupBox3.Controls.Add(this.btnBoltwoodPathBrowse);
            this.groupBox3.Controls.Add(this.btnSerialLogPathBrowse);
            this.groupBox3.Controls.Add(this.btnCSVPathBrowse);
            this.groupBox3.Controls.Add(this.btnLogPathBrowse);
            this.groupBox3.Controls.Add(this.txtBoltwoodFileLocation);
            this.groupBox3.Controls.Add(this.txtLogFileLocation);
            this.groupBox3.Controls.Add(this.txtSerialLogFileLocation);
            this.groupBox3.Controls.Add(this.txtCSVFileLocation);
            this.groupBox3.Controls.Add(this.chkBoltwoodFileFlag);
            this.groupBox3.Controls.Add(this.chkSerialLogFileFlag);
            this.groupBox3.Controls.Add(this.chkCSVFileFlag);
            this.groupBox3.Controls.Add(this.chkLogFileFlag);
            this.errorProvider1.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            this.MyToolTip.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // cmbLogLevel
            // 
            resources.ApplyResources(this.cmbLogLevel, "cmbLogLevel");
            this.errorProvider1.SetError(this.cmbLogLevel, resources.GetString("cmbLogLevel.Error"));
            this.cmbLogLevel.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmbLogLevel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbLogLevel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmbLogLevel, ((int)(resources.GetObject("cmbLogLevel.IconPadding"))));
            this.cmbLogLevel.Items.AddRange(new object[] {
            resources.GetString("cmbLogLevel.Items"),
            resources.GetString("cmbLogLevel.Items1"),
            resources.GetString("cmbLogLevel.Items2")});
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.MyToolTip.SetToolTip(this.cmbLogLevel, resources.GetString("cmbLogLevel.ToolTip"));
            // 
            // btnBoltwoodPathBrowse
            // 
            resources.ApplyResources(this.btnBoltwoodPathBrowse, "btnBoltwoodPathBrowse");
            this.errorProvider1.SetError(this.btnBoltwoodPathBrowse, resources.GetString("btnBoltwoodPathBrowse.Error"));
            this.errorProvider1.SetIconAlignment(this.btnBoltwoodPathBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBoltwoodPathBrowse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnBoltwoodPathBrowse, ((int)(resources.GetObject("btnBoltwoodPathBrowse.IconPadding"))));
            this.btnBoltwoodPathBrowse.Name = "btnBoltwoodPathBrowse";
            this.MyToolTip.SetToolTip(this.btnBoltwoodPathBrowse, resources.GetString("btnBoltwoodPathBrowse.ToolTip"));
            this.btnBoltwoodPathBrowse.UseVisualStyleBackColor = true;
            this.btnBoltwoodPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnSerialLogPathBrowse
            // 
            resources.ApplyResources(this.btnSerialLogPathBrowse, "btnSerialLogPathBrowse");
            this.errorProvider1.SetError(this.btnSerialLogPathBrowse, resources.GetString("btnSerialLogPathBrowse.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSerialLogPathBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSerialLogPathBrowse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSerialLogPathBrowse, ((int)(resources.GetObject("btnSerialLogPathBrowse.IconPadding"))));
            this.btnSerialLogPathBrowse.Name = "btnSerialLogPathBrowse";
            this.MyToolTip.SetToolTip(this.btnSerialLogPathBrowse, resources.GetString("btnSerialLogPathBrowse.ToolTip"));
            this.btnSerialLogPathBrowse.UseVisualStyleBackColor = true;
            this.btnSerialLogPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnCSVPathBrowse
            // 
            resources.ApplyResources(this.btnCSVPathBrowse, "btnCSVPathBrowse");
            this.errorProvider1.SetError(this.btnCSVPathBrowse, resources.GetString("btnCSVPathBrowse.Error"));
            this.errorProvider1.SetIconAlignment(this.btnCSVPathBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCSVPathBrowse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCSVPathBrowse, ((int)(resources.GetObject("btnCSVPathBrowse.IconPadding"))));
            this.btnCSVPathBrowse.Name = "btnCSVPathBrowse";
            this.MyToolTip.SetToolTip(this.btnCSVPathBrowse, resources.GetString("btnCSVPathBrowse.ToolTip"));
            this.btnCSVPathBrowse.UseVisualStyleBackColor = true;
            this.btnCSVPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnLogPathBrowse
            // 
            resources.ApplyResources(this.btnLogPathBrowse, "btnLogPathBrowse");
            this.errorProvider1.SetError(this.btnLogPathBrowse, resources.GetString("btnLogPathBrowse.Error"));
            this.errorProvider1.SetIconAlignment(this.btnLogPathBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnLogPathBrowse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnLogPathBrowse, ((int)(resources.GetObject("btnLogPathBrowse.IconPadding"))));
            this.btnLogPathBrowse.Name = "btnLogPathBrowse";
            this.MyToolTip.SetToolTip(this.btnLogPathBrowse, resources.GetString("btnLogPathBrowse.ToolTip"));
            this.btnLogPathBrowse.UseVisualStyleBackColor = true;
            this.btnLogPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // txtBoltwoodFileLocation
            // 
            resources.ApplyResources(this.txtBoltwoodFileLocation, "txtBoltwoodFileLocation");
            this.txtBoltwoodFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "BoltwoodFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtBoltwoodFileLocation, resources.GetString("txtBoltwoodFileLocation.Error"));
            this.errorProvider1.SetIconAlignment(this.txtBoltwoodFileLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoltwoodFileLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtBoltwoodFileLocation, ((int)(resources.GetObject("txtBoltwoodFileLocation.IconPadding"))));
            this.txtBoltwoodFileLocation.Name = "txtBoltwoodFileLocation";
            this.txtBoltwoodFileLocation.Text = global::WeatherStation.Properties.Settings.Default.BoltwoodFileLocation;
            this.MyToolTip.SetToolTip(this.txtBoltwoodFileLocation, resources.GetString("txtBoltwoodFileLocation.ToolTip"));
            // 
            // txtLogFileLocation
            // 
            resources.ApplyResources(this.txtLogFileLocation, "txtLogFileLocation");
            this.txtLogFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "logFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtLogFileLocation, resources.GetString("txtLogFileLocation.Error"));
            this.errorProvider1.SetIconAlignment(this.txtLogFileLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLogFileLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtLogFileLocation, ((int)(resources.GetObject("txtLogFileLocation.IconPadding"))));
            this.txtLogFileLocation.Name = "txtLogFileLocation";
            this.txtLogFileLocation.Text = global::WeatherStation.Properties.Settings.Default.logFileLocation;
            this.MyToolTip.SetToolTip(this.txtLogFileLocation, resources.GetString("txtLogFileLocation.ToolTip"));
            // 
            // txtSerialLogFileLocation
            // 
            resources.ApplyResources(this.txtSerialLogFileLocation, "txtSerialLogFileLocation");
            this.txtSerialLogFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "SerialLogFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtSerialLogFileLocation, resources.GetString("txtSerialLogFileLocation.Error"));
            this.errorProvider1.SetIconAlignment(this.txtSerialLogFileLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSerialLogFileLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtSerialLogFileLocation, ((int)(resources.GetObject("txtSerialLogFileLocation.IconPadding"))));
            this.txtSerialLogFileLocation.Name = "txtSerialLogFileLocation";
            this.txtSerialLogFileLocation.Text = global::WeatherStation.Properties.Settings.Default.SerialLogFileLocation;
            this.MyToolTip.SetToolTip(this.txtSerialLogFileLocation, resources.GetString("txtSerialLogFileLocation.ToolTip"));
            // 
            // txtCSVFileLocation
            // 
            resources.ApplyResources(this.txtCSVFileLocation, "txtCSVFileLocation");
            this.txtCSVFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "CSVFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCSVFileLocation, resources.GetString("txtCSVFileLocation.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCSVFileLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCSVFileLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCSVFileLocation, ((int)(resources.GetObject("txtCSVFileLocation.IconPadding"))));
            this.txtCSVFileLocation.Name = "txtCSVFileLocation";
            this.txtCSVFileLocation.Text = global::WeatherStation.Properties.Settings.Default.CSVFileLocation;
            this.MyToolTip.SetToolTip(this.txtCSVFileLocation, resources.GetString("txtCSVFileLocation.ToolTip"));
            // 
            // chkBoltwoodFileFlag
            // 
            resources.ApplyResources(this.chkBoltwoodFileFlag, "chkBoltwoodFileFlag");
            this.chkBoltwoodFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.BoltwoodFileFlag;
            this.chkBoltwoodFileFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoltwoodFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "BoltwoodFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkBoltwoodFileFlag, resources.GetString("chkBoltwoodFileFlag.Error"));
            this.errorProvider1.SetIconAlignment(this.chkBoltwoodFileFlag, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkBoltwoodFileFlag.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkBoltwoodFileFlag, ((int)(resources.GetObject("chkBoltwoodFileFlag.IconPadding"))));
            this.chkBoltwoodFileFlag.Name = "chkBoltwoodFileFlag";
            this.MyToolTip.SetToolTip(this.chkBoltwoodFileFlag, resources.GetString("chkBoltwoodFileFlag.ToolTip"));
            this.chkBoltwoodFileFlag.UseVisualStyleBackColor = true;
            // 
            // chkSerialLogFileFlag
            // 
            resources.ApplyResources(this.chkSerialLogFileFlag, "chkSerialLogFileFlag");
            this.chkSerialLogFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.SerialLogFileFlag;
            this.chkSerialLogFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "SerialLogFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkSerialLogFileFlag, resources.GetString("chkSerialLogFileFlag.Error"));
            this.errorProvider1.SetIconAlignment(this.chkSerialLogFileFlag, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkSerialLogFileFlag.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkSerialLogFileFlag, ((int)(resources.GetObject("chkSerialLogFileFlag.IconPadding"))));
            this.chkSerialLogFileFlag.Name = "chkSerialLogFileFlag";
            this.MyToolTip.SetToolTip(this.chkSerialLogFileFlag, resources.GetString("chkSerialLogFileFlag.ToolTip"));
            this.chkSerialLogFileFlag.UseVisualStyleBackColor = true;
            // 
            // chkCSVFileFlag
            // 
            resources.ApplyResources(this.chkCSVFileFlag, "chkCSVFileFlag");
            this.chkCSVFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.CSVFileFlag;
            this.chkCSVFileFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCSVFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "CSVFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkCSVFileFlag, resources.GetString("chkCSVFileFlag.Error"));
            this.errorProvider1.SetIconAlignment(this.chkCSVFileFlag, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkCSVFileFlag.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkCSVFileFlag, ((int)(resources.GetObject("chkCSVFileFlag.IconPadding"))));
            this.chkCSVFileFlag.Name = "chkCSVFileFlag";
            this.MyToolTip.SetToolTip(this.chkCSVFileFlag, resources.GetString("chkCSVFileFlag.ToolTip"));
            this.chkCSVFileFlag.UseVisualStyleBackColor = true;
            // 
            // chkLogFileFlag
            // 
            resources.ApplyResources(this.chkLogFileFlag, "chkLogFileFlag");
            this.chkLogFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.logFileFlag;
            this.chkLogFileFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "logFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkLogFileFlag, resources.GetString("chkLogFileFlag.Error"));
            this.errorProvider1.SetIconAlignment(this.chkLogFileFlag, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkLogFileFlag.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkLogFileFlag, ((int)(resources.GetObject("chkLogFileFlag.IconPadding"))));
            this.chkLogFileFlag.Name = "chkLogFileFlag";
            this.MyToolTip.SetToolTip(this.chkLogFileFlag, resources.GetString("chkLogFileFlag.ToolTip"));
            this.chkLogFileFlag.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtRefreshInterval);
            this.groupBox6.Controls.Add(this.txtMaxPoints);
            this.errorProvider1.SetError(this.groupBox6, resources.GetString("groupBox6.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox6, ((int)(resources.GetObject("groupBox6.IconPadding"))));
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox6, resources.GetString("groupBox6.ToolTip"));
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.errorProvider1.SetError(this.label32, resources.GetString("label32.Error"));
            this.errorProvider1.SetIconAlignment(this.label32, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label32.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label32, ((int)(resources.GetObject("label32.IconPadding"))));
            this.label32.Name = "label32";
            this.MyToolTip.SetToolTip(this.label32, resources.GetString("label32.ToolTip"));
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.errorProvider1.SetError(this.label14, resources.GetString("label14.Error"));
            this.errorProvider1.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding"))));
            this.label14.Name = "label14";
            this.MyToolTip.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.errorProvider1.SetError(this.label15, resources.GetString("label15.Error"));
            this.errorProvider1.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.label15.Name = "label15";
            this.MyToolTip.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // txtRefreshInterval
            // 
            resources.ApplyResources(this.txtRefreshInterval, "txtRefreshInterval");
            this.txtRefreshInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtRefreshInterval, resources.GetString("txtRefreshInterval.Error"));
            this.errorProvider1.SetIconAlignment(this.txtRefreshInterval, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtRefreshInterval.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtRefreshInterval, ((int)(resources.GetObject("txtRefreshInterval.IconPadding"))));
            this.txtRefreshInterval.Name = "txtRefreshInterval";
            this.txtRefreshInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshInterval;
            this.MyToolTip.SetToolTip(this.txtRefreshInterval, resources.GetString("txtRefreshInterval.ToolTip"));
            this.txtRefreshInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtMaxPoints
            // 
            resources.ApplyResources(this.txtMaxPoints, "txtMaxPoints");
            this.txtMaxPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "MaxPoints", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtMaxPoints, resources.GetString("txtMaxPoints.Error"));
            this.errorProvider1.SetIconAlignment(this.txtMaxPoints, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMaxPoints.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtMaxPoints, ((int)(resources.GetObject("txtMaxPoints.IconPadding"))));
            this.txtMaxPoints.Name = "txtMaxPoints";
            this.txtMaxPoints.Text = global::WeatherStation.Properties.Settings.Default.MaxPoints;
            this.MyToolTip.SetToolTip(this.txtMaxPoints, resources.GetString("txtMaxPoints.ToolTip"));
            this.txtMaxPoints.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.txtSerialFileOut);
            this.groupBox1.Controls.Add(this.txtSerialFileIn);
            this.groupBox1.Controls.Add(this.chkWatchdog);
            this.groupBox1.Controls.Add(this.btnOpenWriteToFile);
            this.groupBox1.Controls.Add(this.btnOpenReadFromFile);
            this.groupBox1.Controls.Add(this.cmbPortList);
            this.errorProvider1.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.errorProvider1.SetError(this.label37, resources.GetString("label37.Error"));
            this.errorProvider1.SetIconAlignment(this.label37, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label37.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label37, ((int)(resources.GetObject("label37.IconPadding"))));
            this.label37.Name = "label37";
            this.MyToolTip.SetToolTip(this.label37, resources.GetString("label37.ToolTip"));
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.errorProvider1.SetError(this.label36, resources.GetString("label36.Error"));
            this.errorProvider1.SetIconAlignment(this.label36, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label36.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label36, ((int)(resources.GetObject("label36.IconPadding"))));
            this.label36.Name = "label36";
            this.MyToolTip.SetToolTip(this.label36, resources.GetString("label36.ToolTip"));
            // 
            // txtSerialFileOut
            // 
            resources.ApplyResources(this.txtSerialFileOut, "txtSerialFileOut");
            this.txtSerialFileOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "SerialFileOut", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtSerialFileOut, resources.GetString("txtSerialFileOut.Error"));
            this.errorProvider1.SetIconAlignment(this.txtSerialFileOut, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSerialFileOut.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtSerialFileOut, ((int)(resources.GetObject("txtSerialFileOut.IconPadding"))));
            this.txtSerialFileOut.Name = "txtSerialFileOut";
            this.txtSerialFileOut.Text = global::WeatherStation.Properties.Settings.Default.SerialFileOut;
            this.MyToolTip.SetToolTip(this.txtSerialFileOut, resources.GetString("txtSerialFileOut.ToolTip"));
            // 
            // txtSerialFileIn
            // 
            resources.ApplyResources(this.txtSerialFileIn, "txtSerialFileIn");
            this.txtSerialFileIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "SerialFileIn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtSerialFileIn, resources.GetString("txtSerialFileIn.Error"));
            this.errorProvider1.SetIconAlignment(this.txtSerialFileIn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSerialFileIn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtSerialFileIn, ((int)(resources.GetObject("txtSerialFileIn.IconPadding"))));
            this.txtSerialFileIn.Name = "txtSerialFileIn";
            this.txtSerialFileIn.Text = global::WeatherStation.Properties.Settings.Default.SerialFileIn;
            this.MyToolTip.SetToolTip(this.txtSerialFileIn, resources.GetString("txtSerialFileIn.ToolTip"));
            // 
            // chkWatchdog
            // 
            resources.ApplyResources(this.chkWatchdog, "chkWatchdog");
            this.chkWatchdog.Checked = global::WeatherStation.Properties.Settings.Default.ComWatchdog;
            this.chkWatchdog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWatchdog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "ComWatchdog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.chkWatchdog, resources.GetString("chkWatchdog.Error"));
            this.errorProvider1.SetIconAlignment(this.chkWatchdog, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chkWatchdog.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chkWatchdog, ((int)(resources.GetObject("chkWatchdog.IconPadding"))));
            this.chkWatchdog.Name = "chkWatchdog";
            this.MyToolTip.SetToolTip(this.chkWatchdog, resources.GetString("chkWatchdog.ToolTip"));
            this.chkWatchdog.UseVisualStyleBackColor = true;
            // 
            // btnOpenWriteToFile
            // 
            resources.ApplyResources(this.btnOpenWriteToFile, "btnOpenWriteToFile");
            this.errorProvider1.SetError(this.btnOpenWriteToFile, resources.GetString("btnOpenWriteToFile.Error"));
            this.errorProvider1.SetIconAlignment(this.btnOpenWriteToFile, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOpenWriteToFile.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnOpenWriteToFile, ((int)(resources.GetObject("btnOpenWriteToFile.IconPadding"))));
            this.btnOpenWriteToFile.Name = "btnOpenWriteToFile";
            this.MyToolTip.SetToolTip(this.btnOpenWriteToFile, resources.GetString("btnOpenWriteToFile.ToolTip"));
            this.btnOpenWriteToFile.UseVisualStyleBackColor = true;
            this.btnOpenWriteToFile.Click += new System.EventHandler(this.btnOpenReadFromFile_Click);
            // 
            // btnOpenReadFromFile
            // 
            resources.ApplyResources(this.btnOpenReadFromFile, "btnOpenReadFromFile");
            this.errorProvider1.SetError(this.btnOpenReadFromFile, resources.GetString("btnOpenReadFromFile.Error"));
            this.errorProvider1.SetIconAlignment(this.btnOpenReadFromFile, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOpenReadFromFile.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnOpenReadFromFile, ((int)(resources.GetObject("btnOpenReadFromFile.IconPadding"))));
            this.btnOpenReadFromFile.Name = "btnOpenReadFromFile";
            this.MyToolTip.SetToolTip(this.btnOpenReadFromFile, resources.GetString("btnOpenReadFromFile.ToolTip"));
            this.btnOpenReadFromFile.UseVisualStyleBackColor = true;
            this.btnOpenReadFromFile.Click += new System.EventHandler(this.btnOpenReadFromFile_Click);
            // 
            // cmbPortList
            // 
            resources.ApplyResources(this.cmbPortList, "cmbPortList");
            this.cmbPortList.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "comport", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.cmbPortList, resources.GetString("cmbPortList.Error"));
            this.cmbPortList.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmbPortList, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbPortList.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmbPortList, ((int)(resources.GetObject("cmbPortList.IconPadding"))));
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Text = global::WeatherStation.Properties.Settings.Default.comport;
            this.MyToolTip.SetToolTip(this.cmbPortList, resources.GetString("cmbPortList.ToolTip"));
            this.cmbPortList.SelectedIndexChanged += new System.EventHandler(this.cmbPortList_SelectedIndexChanged);
            // 
            // tabModeling
            // 
            resources.ApplyResources(this.tabModeling, "tabModeling");
            this.tabModeling.Controls.Add(this.groupBox12);
            this.tabModeling.Controls.Add(this.groupBox10);
            this.tabModeling.Controls.Add(this.groupBox5);
            this.tabModeling.Controls.Add(this.groupBox2);
            this.errorProvider1.SetError(this.tabModeling, resources.GetString("tabModeling.Error"));
            this.errorProvider1.SetIconAlignment(this.tabModeling, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabModeling.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabModeling, ((int)(resources.GetObject("tabModeling.IconPadding"))));
            this.tabModeling.Name = "tabModeling";
            this.MyToolTip.SetToolTip(this.tabModeling, resources.GetString("tabModeling.ToolTip"));
            this.tabModeling.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Controls.Add(this.label28);
            this.groupBox12.Controls.Add(this.label29);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.label26);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.txtWSpeedZero);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.txtVeryWindyLimit);
            this.groupBox12.Controls.Add(this.txtWindyLimit);
            this.errorProvider1.SetError(this.groupBox12, resources.GetString("groupBox12.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox12, ((int)(resources.GetObject("groupBox12.IconPadding"))));
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox12, resources.GetString("groupBox12.ToolTip"));
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.errorProvider1.SetError(this.label28, resources.GetString("label28.Error"));
            this.errorProvider1.SetIconAlignment(this.label28, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label28.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label28, ((int)(resources.GetObject("label28.IconPadding"))));
            this.label28.Name = "label28";
            this.MyToolTip.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.errorProvider1.SetError(this.label29, resources.GetString("label29.Error"));
            this.errorProvider1.SetIconAlignment(this.label29, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label29.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label29, ((int)(resources.GetObject("label29.IconPadding"))));
            this.label29.Name = "label29";
            this.MyToolTip.SetToolTip(this.label29, resources.GetString("label29.ToolTip"));
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.errorProvider1.SetError(this.label27, resources.GetString("label27.Error"));
            this.errorProvider1.SetIconAlignment(this.label27, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label27.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label27, ((int)(resources.GetObject("label27.IconPadding"))));
            this.label27.Name = "label27";
            this.MyToolTip.SetToolTip(this.label27, resources.GetString("label27.ToolTip"));
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.errorProvider1.SetError(this.label26, resources.GetString("label26.Error"));
            this.errorProvider1.SetIconAlignment(this.label26, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label26.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label26, ((int)(resources.GetObject("label26.IconPadding"))));
            this.label26.Name = "label26";
            this.MyToolTip.SetToolTip(this.label26, resources.GetString("label26.ToolTip"));
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.errorProvider1.SetError(this.label21, resources.GetString("label21.Error"));
            this.errorProvider1.SetIconAlignment(this.label21, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label21.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label21, ((int)(resources.GetObject("label21.IconPadding"))));
            this.label21.Name = "label21";
            this.MyToolTip.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
            // 
            // txtWSpeedZero
            // 
            resources.ApplyResources(this.txtWSpeedZero, "txtWSpeedZero");
            this.txtWSpeedZero.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WindSpeed_Zero", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtWSpeedZero, resources.GetString("txtWSpeedZero.Error"));
            this.errorProvider1.SetIconAlignment(this.txtWSpeedZero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtWSpeedZero.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtWSpeedZero, ((int)(resources.GetObject("txtWSpeedZero.IconPadding"))));
            this.txtWSpeedZero.Name = "txtWSpeedZero";
            this.txtWSpeedZero.Text = global::WeatherStation.Properties.Settings.Default.WindSpeed_Zero;
            this.MyToolTip.SetToolTip(this.txtWSpeedZero, resources.GetString("txtWSpeedZero.ToolTip"));
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.errorProvider1.SetError(this.label23, resources.GetString("label23.Error"));
            this.errorProvider1.SetIconAlignment(this.label23, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label23.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label23, ((int)(resources.GetObject("label23.IconPadding"))));
            this.label23.Name = "label23";
            this.MyToolTip.SetToolTip(this.label23, resources.GetString("label23.ToolTip"));
            // 
            // txtVeryWindyLimit
            // 
            resources.ApplyResources(this.txtVeryWindyLimit, "txtVeryWindyLimit");
            this.txtVeryWindyLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "VeryWindyLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtVeryWindyLimit, resources.GetString("txtVeryWindyLimit.Error"));
            this.errorProvider1.SetIconAlignment(this.txtVeryWindyLimit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtVeryWindyLimit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtVeryWindyLimit, ((int)(resources.GetObject("txtVeryWindyLimit.IconPadding"))));
            this.txtVeryWindyLimit.Name = "txtVeryWindyLimit";
            this.txtVeryWindyLimit.Text = global::WeatherStation.Properties.Settings.Default.VeryWindyLimit;
            this.MyToolTip.SetToolTip(this.txtVeryWindyLimit, resources.GetString("txtVeryWindyLimit.ToolTip"));
            this.txtVeryWindyLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtWindyLimit
            // 
            resources.ApplyResources(this.txtWindyLimit, "txtWindyLimit");
            this.txtWindyLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WindyLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtWindyLimit, resources.GetString("txtWindyLimit.Error"));
            this.errorProvider1.SetIconAlignment(this.txtWindyLimit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtWindyLimit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtWindyLimit, ((int)(resources.GetObject("txtWindyLimit.IconPadding"))));
            this.txtWindyLimit.Name = "txtWindyLimit";
            this.txtWindyLimit.Text = global::WeatherStation.Properties.Settings.Default.WindyLimit;
            this.MyToolTip.SetToolTip(this.txtWindyLimit, resources.GetString("txtWindyLimit.ToolTip"));
            this.txtWindyLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // groupBox10
            // 
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Controls.Add(this.K7);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.txtK1);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.txtK2);
            this.groupBox10.Controls.Add(this.txtK7);
            this.groupBox10.Controls.Add(this.txtK3);
            this.groupBox10.Controls.Add(this.txtK6);
            this.groupBox10.Controls.Add(this.txtK4);
            this.groupBox10.Controls.Add(this.txtK5);
            this.errorProvider1.SetError(this.groupBox10, resources.GetString("groupBox10.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox10, ((int)(resources.GetObject("groupBox10.IconPadding"))));
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox10, resources.GetString("groupBox10.ToolTip"));
            // 
            // K7
            // 
            resources.ApplyResources(this.K7, "K7");
            this.errorProvider1.SetError(this.K7, resources.GetString("K7.Error"));
            this.errorProvider1.SetIconAlignment(this.K7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("K7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.K7, ((int)(resources.GetObject("K7.IconPadding"))));
            this.K7.Name = "K7";
            this.MyToolTip.SetToolTip(this.K7, resources.GetString("K7.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            this.MyToolTip.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            this.MyToolTip.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            this.MyToolTip.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            this.MyToolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            this.MyToolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // txtK1
            // 
            resources.ApplyResources(this.txtK1, "txtK1");
            this.txtK1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK1, resources.GetString("txtK1.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK1, ((int)(resources.GetObject("txtK1.IconPadding"))));
            this.txtK1.Name = "txtK1";
            this.txtK1.Text = global::WeatherStation.Properties.Settings.Default.K1;
            this.MyToolTip.SetToolTip(this.txtK1, resources.GetString("txtK1.ToolTip"));
            this.txtK1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            this.MyToolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // txtK2
            // 
            resources.ApplyResources(this.txtK2, "txtK2");
            this.txtK2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK2, resources.GetString("txtK2.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK2, ((int)(resources.GetObject("txtK2.IconPadding"))));
            this.txtK2.Name = "txtK2";
            this.txtK2.Text = global::WeatherStation.Properties.Settings.Default.K2;
            this.MyToolTip.SetToolTip(this.txtK2, resources.GetString("txtK2.ToolTip"));
            this.txtK2.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK7
            // 
            resources.ApplyResources(this.txtK7, "txtK7");
            this.txtK7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK7, resources.GetString("txtK7.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK7, ((int)(resources.GetObject("txtK7.IconPadding"))));
            this.txtK7.Name = "txtK7";
            this.txtK7.Text = global::WeatherStation.Properties.Settings.Default.K7;
            this.MyToolTip.SetToolTip(this.txtK7, resources.GetString("txtK7.ToolTip"));
            this.txtK7.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK3
            // 
            resources.ApplyResources(this.txtK3, "txtK3");
            this.txtK3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK3, resources.GetString("txtK3.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK3, ((int)(resources.GetObject("txtK3.IconPadding"))));
            this.txtK3.Name = "txtK3";
            this.txtK3.Text = global::WeatherStation.Properties.Settings.Default.K3;
            this.MyToolTip.SetToolTip(this.txtK3, resources.GetString("txtK3.ToolTip"));
            this.txtK3.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK6
            // 
            resources.ApplyResources(this.txtK6, "txtK6");
            this.txtK6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK6, resources.GetString("txtK6.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK6, ((int)(resources.GetObject("txtK6.IconPadding"))));
            this.txtK6.Name = "txtK6";
            this.txtK6.Text = global::WeatherStation.Properties.Settings.Default.K6;
            this.MyToolTip.SetToolTip(this.txtK6, resources.GetString("txtK6.ToolTip"));
            this.txtK6.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK4
            // 
            resources.ApplyResources(this.txtK4, "txtK4");
            this.txtK4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK4, resources.GetString("txtK4.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK4, ((int)(resources.GetObject("txtK4.IconPadding"))));
            this.txtK4.Name = "txtK4";
            this.txtK4.Text = global::WeatherStation.Properties.Settings.Default.K4;
            this.MyToolTip.SetToolTip(this.txtK4, resources.GetString("txtK4.ToolTip"));
            this.txtK4.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK5
            // 
            resources.ApplyResources(this.txtK5, "txtK5");
            this.txtK5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtK5, resources.GetString("txtK5.Error"));
            this.errorProvider1.SetIconAlignment(this.txtK5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtK5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtK5, ((int)(resources.GetObject("txtK5.IconPadding"))));
            this.txtK5.Name = "txtK5";
            this.txtK5.Text = global::WeatherStation.Properties.Settings.Default.K5;
            this.MyToolTip.SetToolTip(this.txtK5, resources.GetString("txtK5.ToolTip"));
            this.txtK5.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cmbWetMode);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtWetLimit);
            this.groupBox5.Controls.Add(this.txtRainLimit);
            this.errorProvider1.SetError(this.groupBox5, resources.GetString("groupBox5.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox5, ((int)(resources.GetObject("groupBox5.IconPadding"))));
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.errorProvider1.SetError(this.label12, resources.GetString("label12.Error"));
            this.errorProvider1.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            this.MyToolTip.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // cmbWetMode
            // 
            resources.ApplyResources(this.cmbWetMode, "cmbWetMode");
            this.errorProvider1.SetError(this.cmbWetMode, resources.GetString("cmbWetMode.Error"));
            this.cmbWetMode.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmbWetMode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbWetMode.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmbWetMode, ((int)(resources.GetObject("cmbWetMode.IconPadding"))));
            this.cmbWetMode.Items.AddRange(new object[] {
            resources.GetString("cmbWetMode.Items"),
            resources.GetString("cmbWetMode.Items1"),
            resources.GetString("cmbWetMode.Items2")});
            this.cmbWetMode.Name = "cmbWetMode";
            this.MyToolTip.SetToolTip(this.cmbWetMode, resources.GetString("cmbWetMode.ToolTip"));
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.errorProvider1.SetError(this.label19, resources.GetString("label19.Error"));
            this.errorProvider1.SetIconAlignment(this.label19, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label19.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label19, ((int)(resources.GetObject("label19.IconPadding"))));
            this.label19.Name = "label19";
            this.MyToolTip.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.errorProvider1.SetError(this.label13, resources.GetString("label13.Error"));
            this.errorProvider1.SetIconAlignment(this.label13, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label13.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label13, ((int)(resources.GetObject("label13.IconPadding"))));
            this.label13.Name = "label13";
            this.MyToolTip.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // txtWetLimit
            // 
            resources.ApplyResources(this.txtWetLimit, "txtWetLimit");
            this.txtWetLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WetLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtWetLimit, resources.GetString("txtWetLimit.Error"));
            this.errorProvider1.SetIconAlignment(this.txtWetLimit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtWetLimit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtWetLimit, ((int)(resources.GetObject("txtWetLimit.IconPadding"))));
            this.txtWetLimit.Name = "txtWetLimit";
            this.txtWetLimit.Text = global::WeatherStation.Properties.Settings.Default.WetLimit;
            this.MyToolTip.SetToolTip(this.txtWetLimit, resources.GetString("txtWetLimit.ToolTip"));
            this.txtWetLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtRainLimit
            // 
            resources.ApplyResources(this.txtRainLimit, "txtRainLimit");
            this.txtRainLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RainLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtRainLimit, resources.GetString("txtRainLimit.Error"));
            this.errorProvider1.SetIconAlignment(this.txtRainLimit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtRainLimit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtRainLimit, ((int)(resources.GetObject("txtRainLimit.IconPadding"))));
            this.txtRainLimit.Name = "txtRainLimit";
            this.txtRainLimit.Text = global::WeatherStation.Properties.Settings.Default.RainLimit;
            this.MyToolTip.SetToolTip(this.txtRainLimit, resources.GetString("txtRainLimit.ToolTip"));
            this.txtRainLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCloudysky);
            this.groupBox2.Controls.Add(this.txtClearsky);
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            this.MyToolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            this.MyToolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // txtCloudysky
            // 
            resources.ApplyResources(this.txtCloudysky, "txtCloudysky");
            this.txtCloudysky.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Cloudysky", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCloudysky, resources.GetString("txtCloudysky.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCloudysky, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCloudysky.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCloudysky, ((int)(resources.GetObject("txtCloudysky.IconPadding"))));
            this.txtCloudysky.Name = "txtCloudysky";
            this.txtCloudysky.Text = global::WeatherStation.Properties.Settings.Default.Cloudysky;
            this.MyToolTip.SetToolTip(this.txtCloudysky, resources.GetString("txtCloudysky.ToolTip"));
            this.txtCloudysky.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtClearsky
            // 
            resources.ApplyResources(this.txtClearsky, "txtClearsky");
            this.txtClearsky.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Clearsky", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtClearsky, resources.GetString("txtClearsky.Error"));
            this.errorProvider1.SetIconAlignment(this.txtClearsky, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtClearsky.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtClearsky, ((int)(resources.GetObject("txtClearsky.IconPadding"))));
            this.txtClearsky.Name = "txtClearsky";
            this.txtClearsky.Text = global::WeatherStation.Properties.Settings.Default.Clearsky;
            this.MyToolTip.SetToolTip(this.txtClearsky, resources.GetString("txtClearsky.ToolTip"));
            this.txtClearsky.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // tabSensors
            // 
            resources.ApplyResources(this.tabSensors, "tabSensors");
            this.tabSensors.Controls.Add(this.dataGridSensors);
            this.tabSensors.Controls.Add(this.groupBox7);
            this.tabSensors.Controls.Add(this.btnResetSensorList);
            this.tabSensors.Controls.Add(this.btnReadFromSerial);
            this.errorProvider1.SetError(this.tabSensors, resources.GetString("tabSensors.Error"));
            this.errorProvider1.SetIconAlignment(this.tabSensors, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabSensors.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabSensors, ((int)(resources.GetObject("tabSensors.IconPadding"))));
            this.tabSensors.Name = "tabSensors";
            this.MyToolTip.SetToolTip(this.tabSensors, resources.GetString("tabSensors.ToolTip"));
            this.tabSensors.UseVisualStyleBackColor = true;
            // 
            // dataGridSensors
            // 
            resources.ApplyResources(this.dataGridSensors, "dataGridSensors");
            this.dataGridSensors.AllowUserToAddRows = false;
            this.dataGridSensors.AllowUserToDeleteRows = false;
            this.dataGridSensors.AllowUserToOrderColumns = true;
            this.dataGridSensors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSensors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorName,
            this.SensorEnabled,
            this.SensorType,
            this.SendToWeb,
            this.SendToNarodmon,
            this.ArduinoName,
            this.WebCustomName,
            this.FormFieldName});
            this.errorProvider1.SetError(this.dataGridSensors, resources.GetString("dataGridSensors.Error"));
            this.errorProvider1.SetIconAlignment(this.dataGridSensors, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridSensors.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dataGridSensors, ((int)(resources.GetObject("dataGridSensors.IconPadding"))));
            this.dataGridSensors.Name = "dataGridSensors";
            this.dataGridSensors.RowHeadersVisible = false;
            this.MyToolTip.SetToolTip(this.dataGridSensors, resources.GetString("dataGridSensors.ToolTip"));
            // 
            // SensorName
            // 
            resources.ApplyResources(this.SensorName, "SensorName");
            this.SensorName.Name = "SensorName";
            // 
            // SensorEnabled
            // 
            resources.ApplyResources(this.SensorEnabled, "SensorEnabled");
            this.SensorEnabled.Name = "SensorEnabled";
            // 
            // SensorType
            // 
            resources.ApplyResources(this.SensorType, "SensorType");
            this.SensorType.Name = "SensorType";
            // 
            // SendToWeb
            // 
            resources.ApplyResources(this.SendToWeb, "SendToWeb");
            this.SendToWeb.Name = "SendToWeb";
            // 
            // SendToNarodmon
            // 
            resources.ApplyResources(this.SendToNarodmon, "SendToNarodmon");
            this.SendToNarodmon.Name = "SendToNarodmon";
            // 
            // ArduinoName
            // 
            resources.ApplyResources(this.ArduinoName, "ArduinoName");
            this.ArduinoName.Name = "ArduinoName";
            // 
            // WebCustomName
            // 
            resources.ApplyResources(this.WebCustomName, "WebCustomName");
            this.WebCustomName.Name = "WebCustomName";
            // 
            // FormFieldName
            // 
            resources.ApplyResources(this.FormFieldName, "FormFieldName");
            this.FormFieldName.Name = "FormFieldName";
            this.FormFieldName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FormFieldName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.cmbBaseTempSensor);
            this.errorProvider1.SetError(this.groupBox7, resources.GetString("groupBox7.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox7, ((int)(resources.GetObject("groupBox7.IconPadding"))));
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox7, resources.GetString("groupBox7.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            this.MyToolTip.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // cmbBaseTempSensor
            // 
            resources.ApplyResources(this.cmbBaseTempSensor, "cmbBaseTempSensor");
            this.cmbBaseTempSensor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "BaseTempSensor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.cmbBaseTempSensor, resources.GetString("cmbBaseTempSensor.Error"));
            this.cmbBaseTempSensor.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmbBaseTempSensor, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbBaseTempSensor.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmbBaseTempSensor, ((int)(resources.GetObject("cmbBaseTempSensor.IconPadding"))));
            this.cmbBaseTempSensor.Name = "cmbBaseTempSensor";
            this.cmbBaseTempSensor.Text = global::WeatherStation.Properties.Settings.Default.BaseTempSensor;
            this.MyToolTip.SetToolTip(this.cmbBaseTempSensor, resources.GetString("cmbBaseTempSensor.ToolTip"));
            // 
            // btnResetSensorList
            // 
            resources.ApplyResources(this.btnResetSensorList, "btnResetSensorList");
            this.errorProvider1.SetError(this.btnResetSensorList, resources.GetString("btnResetSensorList.Error"));
            this.errorProvider1.SetIconAlignment(this.btnResetSensorList, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnResetSensorList.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnResetSensorList, ((int)(resources.GetObject("btnResetSensorList.IconPadding"))));
            this.btnResetSensorList.Name = "btnResetSensorList";
            this.MyToolTip.SetToolTip(this.btnResetSensorList, resources.GetString("btnResetSensorList.ToolTip"));
            this.btnResetSensorList.UseVisualStyleBackColor = true;
            this.btnResetSensorList.Click += new System.EventHandler(this.btnResetSensorList_Click);
            // 
            // btnReadFromSerial
            // 
            resources.ApplyResources(this.btnReadFromSerial, "btnReadFromSerial");
            this.errorProvider1.SetError(this.btnReadFromSerial, resources.GetString("btnReadFromSerial.Error"));
            this.errorProvider1.SetIconAlignment(this.btnReadFromSerial, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnReadFromSerial.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnReadFromSerial, ((int)(resources.GetObject("btnReadFromSerial.IconPadding"))));
            this.btnReadFromSerial.Name = "btnReadFromSerial";
            this.MyToolTip.SetToolTip(this.btnReadFromSerial, resources.GetString("btnReadFromSerial.ToolTip"));
            this.btnReadFromSerial.UseVisualStyleBackColor = true;
            // 
            // tabHeater
            // 
            resources.ApplyResources(this.tabHeater, "tabHeater");
            this.tabHeater.Controls.Add(this.groupBox9);
            this.tabHeater.Controls.Add(this.groupBox4);
            this.errorProvider1.SetError(this.tabHeater, resources.GetString("tabHeater.Error"));
            this.errorProvider1.SetIconAlignment(this.tabHeater, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabHeater.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabHeater, ((int)(resources.GetObject("tabHeater.IconPadding"))));
            this.tabHeater.Name = "tabHeater";
            this.MyToolTip.SetToolTip(this.tabHeater, resources.GetString("tabHeater.ToolTip"));
            this.tabHeater.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.txtCSHeaterPauseTime);
            this.groupBox9.Controls.Add(this.txtCSDecreasingMaxDelta);
            this.groupBox9.Controls.Add(this.txtCSHeatingMax);
            this.groupBox9.Controls.Add(this.txtCSDecreasingMinDelta);
            this.groupBox9.Controls.Add(this.txtCSHeatingMin);
            this.errorProvider1.SetError(this.groupBox9, resources.GetString("groupBox9.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox9, ((int)(resources.GetObject("groupBox9.IconPadding"))));
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox9, resources.GetString("groupBox9.ToolTip"));
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.errorProvider1.SetError(this.label20, resources.GetString("label20.Error"));
            this.errorProvider1.SetIconAlignment(this.label20, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label20.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label20, ((int)(resources.GetObject("label20.IconPadding"))));
            this.label20.Name = "label20";
            this.MyToolTip.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.errorProvider1.SetError(this.label22, resources.GetString("label22.Error"));
            this.errorProvider1.SetIconAlignment(this.label22, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label22.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label22, ((int)(resources.GetObject("label22.IconPadding"))));
            this.label22.Name = "label22";
            this.MyToolTip.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            this.label22.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.errorProvider1.SetError(this.label24, resources.GetString("label24.Error"));
            this.errorProvider1.SetIconAlignment(this.label24, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label24.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label24, ((int)(resources.GetObject("label24.IconPadding"))));
            this.label24.Name = "label24";
            this.MyToolTip.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.errorProvider1.SetError(this.label18, resources.GetString("label18.Error"));
            this.errorProvider1.SetIconAlignment(this.label18, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label18.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label18, ((int)(resources.GetObject("label18.IconPadding"))));
            this.label18.Name = "label18";
            this.MyToolTip.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.errorProvider1.SetError(this.label25, resources.GetString("label25.Error"));
            this.errorProvider1.SetIconAlignment(this.label25, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label25.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label25, ((int)(resources.GetObject("label25.IconPadding"))));
            this.label25.Name = "label25";
            this.MyToolTip.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
            // 
            // txtCSHeaterPauseTime
            // 
            resources.ApplyResources(this.txtCSHeaterPauseTime, "txtCSHeaterPauseTime");
            this.txtCSHeaterPauseTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingPauseTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCSHeaterPauseTime, resources.GetString("txtCSHeaterPauseTime.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCSHeaterPauseTime, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCSHeaterPauseTime.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCSHeaterPauseTime, ((int)(resources.GetObject("txtCSHeaterPauseTime.IconPadding"))));
            this.txtCSHeaterPauseTime.Name = "txtCSHeaterPauseTime";
            this.txtCSHeaterPauseTime.Text = global::WeatherStation.Properties.Settings.Default.HeatingPauseTime;
            this.MyToolTip.SetToolTip(this.txtCSHeaterPauseTime, resources.GetString("txtCSHeaterPauseTime.ToolTip"));
            this.txtCSHeaterPauseTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCSDecreasingMaxDelta
            // 
            resources.ApplyResources(this.txtCSDecreasingMaxDelta, "txtCSDecreasingMaxDelta");
            this.txtCSDecreasingMaxDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCS_MaxDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCSDecreasingMaxDelta, resources.GetString("txtCSDecreasingMaxDelta.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCSDecreasingMaxDelta, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCSDecreasingMaxDelta.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCSDecreasingMaxDelta, ((int)(resources.GetObject("txtCSDecreasingMaxDelta.IconPadding"))));
            this.txtCSDecreasingMaxDelta.Name = "txtCSDecreasingMaxDelta";
            this.txtCSDecreasingMaxDelta.Text = global::WeatherStation.Properties.Settings.Default.HeatingCS_MaxDelta;
            this.MyToolTip.SetToolTip(this.txtCSDecreasingMaxDelta, resources.GetString("txtCSDecreasingMaxDelta.ToolTip"));
            this.txtCSDecreasingMaxDelta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtCSHeatingMax
            // 
            resources.ApplyResources(this.txtCSHeatingMax, "txtCSHeatingMax");
            this.txtCSHeatingMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCSThresholdMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCSHeatingMax, resources.GetString("txtCSHeatingMax.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCSHeatingMax, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCSHeatingMax.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCSHeatingMax, ((int)(resources.GetObject("txtCSHeatingMax.IconPadding"))));
            this.txtCSHeatingMax.Name = "txtCSHeatingMax";
            this.txtCSHeatingMax.Text = global::WeatherStation.Properties.Settings.Default.HeatingCSThresholdMax;
            this.MyToolTip.SetToolTip(this.txtCSHeatingMax, resources.GetString("txtCSHeatingMax.ToolTip"));
            this.txtCSHeatingMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCSDecreasingMinDelta
            // 
            resources.ApplyResources(this.txtCSDecreasingMinDelta, "txtCSDecreasingMinDelta");
            this.txtCSDecreasingMinDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCS_MinDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCSDecreasingMinDelta, resources.GetString("txtCSDecreasingMinDelta.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCSDecreasingMinDelta, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCSDecreasingMinDelta.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCSDecreasingMinDelta, ((int)(resources.GetObject("txtCSDecreasingMinDelta.IconPadding"))));
            this.txtCSDecreasingMinDelta.Name = "txtCSDecreasingMinDelta";
            this.txtCSDecreasingMinDelta.Text = global::WeatherStation.Properties.Settings.Default.HeatingCS_MinDelta;
            this.MyToolTip.SetToolTip(this.txtCSDecreasingMinDelta, resources.GetString("txtCSDecreasingMinDelta.ToolTip"));
            this.txtCSDecreasingMinDelta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtCSHeatingMin
            // 
            resources.ApplyResources(this.txtCSHeatingMin, "txtCSHeatingMin");
            this.txtCSHeatingMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCSThresholdMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtCSHeatingMin, resources.GetString("txtCSHeatingMin.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCSHeatingMin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCSHeatingMin.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCSHeatingMin, ((int)(resources.GetObject("txtCSHeatingMin.IconPadding"))));
            this.txtCSHeatingMin.Name = "txtCSHeatingMin";
            this.txtCSHeatingMin.Text = global::WeatherStation.Properties.Settings.Default.HeatingCSThresholdMin;
            this.MyToolTip.SetToolTip(this.txtCSHeatingMin, resources.GetString("txtCSHeatingMin.ToolTip"));
            this.txtCSHeatingMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtHeaterWetThreshold);
            this.groupBox4.Controls.Add(this.txtHeaterMaxTemp);
            this.groupBox4.Controls.Add(this.txtHeaterMaxDuration);
            this.errorProvider1.SetError(this.groupBox4, resources.GetString("groupBox4.Error"));
            this.errorProvider1.SetIconAlignment(this.groupBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox4, ((int)(resources.GetObject("groupBox4.IconPadding"))));
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.MyToolTip.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error"));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            this.MyToolTip.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.errorProvider1.SetError(this.label17, resources.GetString("label17.Error"));
            this.errorProvider1.SetIconAlignment(this.label17, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label17.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label17, ((int)(resources.GetObject("label17.IconPadding"))));
            this.label17.Name = "label17";
            this.MyToolTip.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.errorProvider1.SetError(this.label16, resources.GetString("label16.Error"));
            this.errorProvider1.SetIconAlignment(this.label16, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label16.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label16, ((int)(resources.GetObject("label16.IconPadding"))));
            this.label16.Name = "label16";
            this.MyToolTip.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // txtHeaterWetThreshold
            // 
            resources.ApplyResources(this.txtHeaterWetThreshold, "txtHeaterWetThreshold");
            this.txtHeaterWetThreshold.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterWetThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingWetThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtHeaterWetThreshold, resources.GetString("txtHeaterWetThreshold.Error"));
            this.errorProvider1.SetIconAlignment(this.txtHeaterWetThreshold, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtHeaterWetThreshold.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtHeaterWetThreshold, ((int)(resources.GetObject("txtHeaterWetThreshold.IconPadding"))));
            this.txtHeaterWetThreshold.Name = "txtHeaterWetThreshold";
            this.txtHeaterWetThreshold.Text = global::WeatherStation.Properties.Settings.Default.HeatingWetThreshold;
            this.MyToolTip.SetToolTip(this.txtHeaterWetThreshold, resources.GetString("txtHeaterWetThreshold.ToolTip"));
            this.txtHeaterWetThreshold.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterMaxTemp
            // 
            resources.ApplyResources(this.txtHeaterMaxTemp, "txtHeaterMaxTemp");
            this.txtHeaterMaxTemp.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterMaxTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingMaxTemp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtHeaterMaxTemp, resources.GetString("txtHeaterMaxTemp.Error"));
            this.errorProvider1.SetIconAlignment(this.txtHeaterMaxTemp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtHeaterMaxTemp.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtHeaterMaxTemp, ((int)(resources.GetObject("txtHeaterMaxTemp.IconPadding"))));
            this.txtHeaterMaxTemp.Name = "txtHeaterMaxTemp";
            this.txtHeaterMaxTemp.Text = global::WeatherStation.Properties.Settings.Default.HeatingMaxTemp;
            this.MyToolTip.SetToolTip(this.txtHeaterMaxTemp, resources.GetString("txtHeaterMaxTemp.ToolTip"));
            this.txtHeaterMaxTemp.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterMaxDuration
            // 
            resources.ApplyResources(this.txtHeaterMaxDuration, "txtHeaterMaxDuration");
            this.txtHeaterMaxDuration.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterMaxDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingMaxDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txtHeaterMaxDuration, resources.GetString("txtHeaterMaxDuration.Error"));
            this.errorProvider1.SetIconAlignment(this.txtHeaterMaxDuration, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtHeaterMaxDuration.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtHeaterMaxDuration, ((int)(resources.GetObject("txtHeaterMaxDuration.IconPadding"))));
            this.txtHeaterMaxDuration.Name = "txtHeaterMaxDuration";
            this.txtHeaterMaxDuration.Text = global::WeatherStation.Properties.Settings.Default.HeatingMaxDuration;
            this.MyToolTip.SetToolTip(this.txtHeaterMaxDuration, resources.GetString("txtHeaterMaxDuration.ToolTip"));
            this.txtHeaterMaxDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.errorProvider1.SetError(this.btnOk, resources.GetString("btnOk.Error"));
            this.errorProvider1.SetIconAlignment(this.btnOk, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOk.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnOk, ((int)(resources.GetObject("btnOk.IconPadding"))));
            this.btnOk.Name = "btnOk";
            this.MyToolTip.SetToolTip(this.btnOk, resources.GetString("btnOk.ToolTip"));
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.MyToolTip.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.errorProvider1.SetError(this.btnReset, resources.GetString("btnReset.Error"));
            this.errorProvider1.SetIconAlignment(this.btnReset, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnReset.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnReset, ((int)(resources.GetObject("btnReset.IconPadding"))));
            this.btnReset.Name = "btnReset";
            this.MyToolTip.SetToolTip(this.btnReset, resources.GetString("btnReset.ToolTip"));
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // fileChooseDialog
            // 
            resources.ApplyResources(this.fileChooseDialog, "fileChooseDialog");
            this.fileChooseDialog.InitialDirectory = "MyComputer";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.MyToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabModeling.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSensors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSensors)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabHeater.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabSensors;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabModeling;
        private System.Windows.Forms.TabPage tabHeater;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCSHeaterPauseTime;
        private System.Windows.Forms.TextBox txtCSDecreasingMaxDelta;
        private System.Windows.Forms.TextBox txtCSHeatingMax;
        private System.Windows.Forms.TextBox txtCSDecreasingMinDelta;
        private System.Windows.Forms.TextBox txtCSHeatingMin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHeaterWetThreshold;
        private System.Windows.Forms.TextBox txtHeaterMaxTemp;
        private System.Windows.Forms.TextBox txtHeaterMaxDuration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.Button btnBoltwoodPathBrowse;
        private System.Windows.Forms.Button btnSerialLogPathBrowse;
        private System.Windows.Forms.Button btnCSVPathBrowse;
        private System.Windows.Forms.Button btnLogPathBrowse;
        private System.Windows.Forms.TextBox txtBoltwoodFileLocation;
        private System.Windows.Forms.TextBox txtLogFileLocation;
        private System.Windows.Forms.TextBox txtSerialLogFileLocation;
        private System.Windows.Forms.TextBox txtCSVFileLocation;
        private System.Windows.Forms.CheckBox chkBoltwoodFileFlag;
        private System.Windows.Forms.CheckBox chkSerialLogFileFlag;
        private System.Windows.Forms.CheckBox chkCSVFileFlag;
        private System.Windows.Forms.CheckBox chkLogFileFlag;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRefreshInterval;
        private System.Windows.Forms.TextBox txtMaxPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkWatchdog;
        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbWetMode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWetLimit;
        private System.Windows.Forms.TextBox txtRainLimit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCloudysky;
        private System.Windows.Forms.TextBox txtClearsky;
        private System.Windows.Forms.DataGridView dataGridSensors;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBaseTempSensor;
        private System.Windows.Forms.Button btnResetSensorList;
        private System.Windows.Forms.Button btnReadFromSerial;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkTrayIcon;
        private System.Windows.Forms.CheckBox chkMinMode;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label K7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtK1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtK2;
        private System.Windows.Forms.TextBox txtK7;
        private System.Windows.Forms.TextBox txtK3;
        private System.Windows.Forms.TextBox txtK6;
        private System.Windows.Forms.TextBox txtK4;
        private System.Windows.Forms.TextBox txtK5;
        private System.Windows.Forms.CheckBox chkShowDebugPannels;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnGenerateMac;
        private System.Windows.Forms.TextBox txtNarodmonMAC;
        private System.Windows.Forms.TextBox txtWebDataURL;
        private System.Windows.Forms.CheckBox chkNarodMon;
        private System.Windows.Forms.CheckBox chkWebData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtWSpeedZero;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVeryWindyLimit;
        private System.Windows.Forms.TextBox txtWindyLimit;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtRefreshWebDataInterval;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtRefreshNarodmonInterval;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtSerialFileOut;
        private System.Windows.Forms.TextBox txtSerialFileIn;
        private System.Windows.Forms.Button btnOpenWriteToFile;
        private System.Windows.Forms.Button btnOpenReadFromFile;
        private System.Windows.Forms.SaveFileDialog fileChooseDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SensorEnabled;
        private System.Windows.Forms.DataGridViewComboBoxColumn SensorType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendToWeb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendToNarodmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArduinoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebCustomName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FormFieldName;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cmbLang;
    }
}