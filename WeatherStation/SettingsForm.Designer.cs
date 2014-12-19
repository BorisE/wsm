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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnGenerateMac = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBoltwoodPathBrowse = new System.Windows.Forms.Button();
            this.btnSerialLogPathBrowse = new System.Windows.Forms.Button();
            this.btnCSVPathBrowse = new System.Windows.Forms.Button();
            this.btnLogPathBrowse = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabModeling = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.K7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnResetSensorList = new System.Windows.Forms.Button();
            this.btnReadFromSerial = new System.Windows.Forms.Button();
            this.tabHeater = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.txtRefreshNarodmonInterval = new System.Windows.Forms.TextBox();
            this.txtRefreshWebDataInterval = new System.Windows.Forms.TextBox();
            this.txtNarodmonMAC = new System.Windows.Forms.TextBox();
            this.txtWebDataURL = new System.Windows.Forms.TextBox();
            this.chkNarodMon = new System.Windows.Forms.CheckBox();
            this.chkWebData = new System.Windows.Forms.CheckBox();
            this.chkShowDebugPannels = new System.Windows.Forms.CheckBox();
            this.chkTrayIcon = new System.Windows.Forms.CheckBox();
            this.chkMinMode = new System.Windows.Forms.CheckBox();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.txtBoltwoodFileLocation = new System.Windows.Forms.TextBox();
            this.txtLogFileLocation = new System.Windows.Forms.TextBox();
            this.txtSerialLogFileLocation = new System.Windows.Forms.TextBox();
            this.txtCSVFileLocation = new System.Windows.Forms.TextBox();
            this.chkBoltwoodFileFlag = new System.Windows.Forms.CheckBox();
            this.chkSerialLogFileFlag = new System.Windows.Forms.CheckBox();
            this.chkCSVFileFlag = new System.Windows.Forms.CheckBox();
            this.chkLogFileFlag = new System.Windows.Forms.CheckBox();
            this.txtRefreshInterval = new System.Windows.Forms.TextBox();
            this.txtMaxPoints = new System.Windows.Forms.TextBox();
            this.chkWatchdog = new System.Windows.Forms.CheckBox();
            this.chkResetArduino = new System.Windows.Forms.CheckBox();
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.txtWSpeedZero = new System.Windows.Forms.TextBox();
            this.txtVeryWindyLimit = new System.Windows.Forms.TextBox();
            this.txtWindyLimit = new System.Windows.Forms.TextBox();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.txtK7 = new System.Windows.Forms.TextBox();
            this.txtK3 = new System.Windows.Forms.TextBox();
            this.txtK6 = new System.Windows.Forms.TextBox();
            this.txtK4 = new System.Windows.Forms.TextBox();
            this.txtK5 = new System.Windows.Forms.TextBox();
            this.cmbWetMode = new System.Windows.Forms.ComboBox();
            this.txtWetLimit = new System.Windows.Forms.TextBox();
            this.txtRainLimit = new System.Windows.Forms.TextBox();
            this.txtCloudysky = new System.Windows.Forms.TextBox();
            this.txtClearsky = new System.Windows.Forms.TextBox();
            this.cmbBaseTempSensor = new System.Windows.Forms.ComboBox();
            this.txtCSHeaterPauseTime = new System.Windows.Forms.TextBox();
            this.txtCSDecreasingMaxDelta = new System.Windows.Forms.TextBox();
            this.txtCSHeatingMax = new System.Windows.Forms.TextBox();
            this.txtCSDecreasingMinDelta = new System.Windows.Forms.TextBox();
            this.txtCSHeatingMin = new System.Windows.Forms.TextBox();
            this.txtHeaterWetThreshold = new System.Windows.Forms.TextBox();
            this.txtHeaterMaxTemp = new System.Windows.Forms.TextBox();
            this.txtHeaterMaxDuration = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabModeling);
            this.tabControl1.Controls.Add(this.tabSensors);
            this.tabControl1.Controls.Add(this.tabHeater);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox11);
            this.tabGeneral.Controls.Add(this.groupBox8);
            this.tabGeneral.Controls.Add(this.groupBox3);
            this.tabGeneral.Controls.Add(this.groupBox6);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGeneral.Size = new System.Drawing.Size(828, 410);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
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
            this.groupBox11.Location = new System.Drawing.Point(428, 153);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox11.Size = new System.Drawing.Size(387, 220);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Web server";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 154);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(21, 17);
            this.label35.TabIndex = 11;
            this.label35.Text = "ID";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(288, 185);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(30, 17);
            this.label34.TabIndex = 10;
            this.label34.Text = "sec";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(288, 82);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(30, 17);
            this.label31.TabIndex = 10;
            this.label31.Text = "sec";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 185);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(200, 17);
            this.label33.TabIndex = 10;
            this.label33.Text = "Send data to narodmon every ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(161, 17);
            this.label30.TabIndex = 10;
            this.label30.Text = "Send data to web every ";
            // 
            // btnGenerateMac
            // 
            this.btnGenerateMac.Location = new System.Drawing.Point(212, 146);
            this.btnGenerateMac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateMac.Name = "btnGenerateMac";
            this.btnGenerateMac.Size = new System.Drawing.Size(79, 28);
            this.btnGenerateMac.TabIndex = 2;
            this.btnGenerateMac.Text = "Generate";
            this.MyToolTip.SetToolTip(this.btnGenerateMac, "Press to generate ID based on computer MAC address");
            this.btnGenerateMac.UseVisualStyleBackColor = true;
            this.btnGenerateMac.Click += new System.EventHandler(this.btnGenerateMac_Click_1);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkShowDebugPannels);
            this.groupBox8.Controls.Add(this.chkTrayIcon);
            this.groupBox8.Controls.Add(this.chkMinMode);
            this.groupBox8.Location = new System.Drawing.Point(428, 4);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(387, 138);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Interface options";
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(11, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(409, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Logging level";
            // 
            // btnBoltwoodPathBrowse
            // 
            this.btnBoltwoodPathBrowse.Location = new System.Drawing.Point(365, 140);
            this.btnBoltwoodPathBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBoltwoodPathBrowse.Name = "btnBoltwoodPathBrowse";
            this.btnBoltwoodPathBrowse.Size = new System.Drawing.Size(36, 25);
            this.btnBoltwoodPathBrowse.TabIndex = 12;
            this.btnBoltwoodPathBrowse.Text = "...";
            this.btnBoltwoodPathBrowse.UseVisualStyleBackColor = true;
            this.btnBoltwoodPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnSerialLogPathBrowse
            // 
            this.btnSerialLogPathBrowse.Location = new System.Drawing.Point(365, 82);
            this.btnSerialLogPathBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialLogPathBrowse.Name = "btnSerialLogPathBrowse";
            this.btnSerialLogPathBrowse.Size = new System.Drawing.Size(36, 25);
            this.btnSerialLogPathBrowse.TabIndex = 6;
            this.btnSerialLogPathBrowse.Text = "...";
            this.btnSerialLogPathBrowse.UseVisualStyleBackColor = true;
            this.btnSerialLogPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnCSVPathBrowse
            // 
            this.btnCSVPathBrowse.Location = new System.Drawing.Point(365, 110);
            this.btnCSVPathBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSVPathBrowse.Name = "btnCSVPathBrowse";
            this.btnCSVPathBrowse.Size = new System.Drawing.Size(36, 25);
            this.btnCSVPathBrowse.TabIndex = 9;
            this.btnCSVPathBrowse.Text = "...";
            this.btnCSVPathBrowse.UseVisualStyleBackColor = true;
            this.btnCSVPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnLogPathBrowse
            // 
            this.btnLogPathBrowse.Location = new System.Drawing.Point(365, 23);
            this.btnLogPathBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogPathBrowse.Name = "btnLogPathBrowse";
            this.btnLogPathBrowse.Size = new System.Drawing.Size(36, 25);
            this.btnLogPathBrowse.TabIndex = 2;
            this.btnLogPathBrowse.Text = "...";
            this.btnLogPathBrowse.UseVisualStyleBackColor = true;
            this.btnLogPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtRefreshInterval);
            this.groupBox6.Controls.Add(this.txtMaxPoints);
            this.groupBox6.Location = new System.Drawing.Point(11, 286);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(409, 86);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gragh settings";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(273, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 17);
            this.label32.TabIndex = 10;
            this.label32.Text = "millisec";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(8, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Refresh interval";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(9, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Max points on graph";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWatchdog);
            this.groupBox1.Controls.Add(this.chkResetArduino);
            this.groupBox1.Controls.Add(this.cmbPortList);
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(409, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial port";
            // 
            // tabModeling
            // 
            this.tabModeling.Controls.Add(this.groupBox12);
            this.tabModeling.Controls.Add(this.groupBox10);
            this.tabModeling.Controls.Add(this.groupBox5);
            this.tabModeling.Controls.Add(this.groupBox2);
            this.tabModeling.Location = new System.Drawing.Point(4, 25);
            this.tabModeling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabModeling.Name = "tabModeling";
            this.tabModeling.Size = new System.Drawing.Size(828, 410);
            this.tabModeling.TabIndex = 3;
            this.tabModeling.Text = "Modeling";
            this.tabModeling.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label28);
            this.groupBox12.Controls.Add(this.label29);
            this.groupBox12.Controls.Add(this.label27);
            this.groupBox12.Controls.Add(this.label26);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.txtWSpeedZero);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.txtVeryWindyLimit);
            this.groupBox12.Controls.Add(this.txtWindyLimit);
            this.groupBox12.Location = new System.Drawing.Point(428, 4);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Size = new System.Drawing.Size(391, 116);
            this.groupBox12.TabIndex = 11;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Wind Speed Sensor model";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(280, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 17);
            this.label28.TabIndex = 4;
            this.label28.Text = "m/s";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(280, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 17);
            this.label29.TabIndex = 4;
            this.label29.Text = "m/s";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(280, 53);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 17);
            this.label27.TabIndex = 4;
            this.label27.Text = "m/s";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(9, 53);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Windy threshold";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(9, 23);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(182, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Zero wind speed calibration";
            this.MyToolTip.SetToolTip(this.label21, "Calibration value for zero wind speed\r\n\r\nStop wind speed sensor and enter value w" +
        "hich would lead to 0 speed value. Default 83, may be different for different sen" +
        "sors");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(9, 82);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 17);
            this.label23.TabIndex = 1;
            this.label23.Text = "Very windy threshold";
            // 
            // groupBox10
            // 
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
            this.groupBox10.Location = new System.Drawing.Point(11, 103);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(409, 87);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "AAG Cloud Sensor model";
            // 
            // K7
            // 
            this.K7.AutoSize = true;
            this.K7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.K7.Location = new System.Drawing.Point(263, 20);
            this.K7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.K7.Name = "K7";
            this.K7.Size = new System.Drawing.Size(25, 17);
            this.K7.TabIndex = 9;
            this.K7.Text = "K7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(223, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "K6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(183, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "K5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(143, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "K4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(103, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "K3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(63, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "K2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "K1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cmbWetMode);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtWetLimit);
            this.groupBox5.Controls.Add(this.txtRainLimit);
            this.groupBox5.Location = new System.Drawing.Point(11, 198);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(409, 122);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rain sensor model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(8, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Wet threshold";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(9, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Rain sensors mode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(9, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Rain threshold";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCloudysky);
            this.groupBox2.Controls.Add(this.txtClearsky);
            this.groupBox2.Location = new System.Drawing.Point(11, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(409, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cloud sensor model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cloudy sky threshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clear sky threshold";
            // 
            // tabSensors
            // 
            this.tabSensors.Controls.Add(this.dataGridSensors);
            this.tabSensors.Controls.Add(this.groupBox7);
            this.tabSensors.Controls.Add(this.btnResetSensorList);
            this.tabSensors.Controls.Add(this.btnReadFromSerial);
            this.tabSensors.Location = new System.Drawing.Point(4, 25);
            this.tabSensors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSensors.Name = "tabSensors";
            this.tabSensors.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSensors.Size = new System.Drawing.Size(828, 410);
            this.tabSensors.TabIndex = 1;
            this.tabSensors.Text = "Sensors";
            this.tabSensors.UseVisualStyleBackColor = true;
            // 
            // dataGridSensors
            // 
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
            this.dataGridSensors.Location = new System.Drawing.Point(8, 7);
            this.dataGridSensors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridSensors.Name = "dataGridSensors";
            this.dataGridSensors.RowHeadersVisible = false;
            this.dataGridSensors.Size = new System.Drawing.Size(805, 327);
            this.dataGridSensors.TabIndex = 19;
            // 
            // SensorName
            // 
            this.SensorName.HeaderText = "Sensor";
            this.SensorName.MinimumWidth = 50;
            this.SensorName.Name = "SensorName";
            this.SensorName.Width = 120;
            // 
            // SensorEnabled
            // 
            this.SensorEnabled.HeaderText = "Enabled";
            this.SensorEnabled.MinimumWidth = 10;
            this.SensorEnabled.Name = "SensorEnabled";
            this.SensorEnabled.Width = 50;
            // 
            // SensorType
            // 
            this.SensorType.HeaderText = "Type";
            this.SensorType.MinimumWidth = 50;
            this.SensorType.Name = "SensorType";
            this.SensorType.Width = 80;
            // 
            // SendToWeb
            // 
            this.SendToWeb.HeaderText = "Send to Web";
            this.SendToWeb.Name = "SendToWeb";
            // 
            // SendToNarodmon
            // 
            this.SendToNarodmon.HeaderText = "Send to Narodmon";
            this.SendToNarodmon.Name = "SendToNarodmon";
            // 
            // ArduinoName
            // 
            this.ArduinoName.HeaderText = "Arduino Name";
            this.ArduinoName.Name = "ArduinoName";
            this.ArduinoName.Width = 80;
            // 
            // WebCustomName
            // 
            this.WebCustomName.HeaderText = "Web VAR name";
            this.WebCustomName.Name = "WebCustomName";
            // 
            // FormFieldName
            // 
            this.FormFieldName.HeaderText = "TextField name";
            this.FormFieldName.Name = "FormFieldName";
            this.FormFieldName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FormFieldName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.cmbBaseTempSensor);
            this.groupBox7.Location = new System.Drawing.Point(8, 342);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(355, 60);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Base temp sensor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Base temp sensor";
            // 
            // btnResetSensorList
            // 
            this.btnResetSensorList.Location = new System.Drawing.Point(628, 359);
            this.btnResetSensorList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetSensorList.Name = "btnResetSensorList";
            this.btnResetSensorList.Size = new System.Drawing.Size(185, 28);
            this.btnResetSensorList.TabIndex = 16;
            this.btnResetSensorList.Text = "Reset sensor list to default";
            this.MyToolTip.SetToolTip(this.btnResetSensorList, "Will delete all your entries in sensor list and fill with default values");
            this.btnResetSensorList.UseVisualStyleBackColor = true;
            this.btnResetSensorList.Click += new System.EventHandler(this.btnResetSensorList_Click);
            // 
            // btnReadFromSerial
            // 
            this.btnReadFromSerial.Location = new System.Drawing.Point(404, 359);
            this.btnReadFromSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadFromSerial.Name = "btnReadFromSerial";
            this.btnReadFromSerial.Size = new System.Drawing.Size(185, 28);
            this.btnReadFromSerial.TabIndex = 17;
            this.btnReadFromSerial.Text = "Read from serial port";
            this.MyToolTip.SetToolTip(this.btnReadFromSerial, "Not implemented yet");
            this.btnReadFromSerial.UseVisualStyleBackColor = true;
            // 
            // tabHeater
            // 
            this.tabHeater.Controls.Add(this.groupBox9);
            this.tabHeater.Controls.Add(this.groupBox4);
            this.tabHeater.Location = new System.Drawing.Point(4, 25);
            this.tabHeater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHeater.Name = "tabHeater";
            this.tabHeater.Size = new System.Drawing.Size(828, 410);
            this.tabHeater.TabIndex = 4;
            this.tabHeater.Text = "Heater";
            this.tabHeater.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
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
            this.groupBox9.Location = new System.Drawing.Point(11, 123);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(409, 123);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "CS auto heater settings";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(273, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(273, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 17);
            this.label22.TabIndex = 13;
            this.label22.Text = "-";
            this.label22.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(8, 57);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Heater pause time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(9, 86);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "CS decreasing threshold";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(8, 27);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(170, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "CS threshold switching on";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtHeaterWetThreshold);
            this.groupBox4.Controls.Add(this.txtHeaterMaxTemp);
            this.groupBox4.Controls.Add(this.txtHeaterMaxDuration);
            this.groupBox4.Location = new System.Drawing.Point(11, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(409, 112);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Heater settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(8, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Max temperature delta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(9, 82);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Wet threshold switching on";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(9, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Max cycle duration";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(568, 453);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 30);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(715, 453);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(9, 453);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset to Defaults";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtRefreshNarodmonInterval
            // 
            this.txtRefreshNarodmonInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshNarodmonInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefreshNarodmonInterval.Location = new System.Drawing.Point(212, 181);
            this.txtRefreshNarodmonInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefreshNarodmonInterval.Name = "txtRefreshNarodmonInterval";
            this.txtRefreshNarodmonInterval.Size = new System.Drawing.Size(69, 22);
            this.txtRefreshNarodmonInterval.TabIndex = 0;
            this.txtRefreshNarodmonInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshNarodmonInterval;
            this.txtRefreshNarodmonInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtRefreshNarodmonInterval, "Specify how ofter data should be sent to narodmon.ru\r\n\r\nService demand that it sh" +
        "ould be at least 5 min for free accounts.\r\nNote that data would be sent only in " +
        "multiples of Refresh interval settings");
            this.txtRefreshNarodmonInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtRefreshWebDataInterval
            // 
            this.txtRefreshWebDataInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshWebInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefreshWebDataInterval.Location = new System.Drawing.Point(212, 79);
            this.txtRefreshWebDataInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefreshWebDataInterval.Name = "txtRefreshWebDataInterval";
            this.txtRefreshWebDataInterval.Size = new System.Drawing.Size(69, 22);
            this.txtRefreshWebDataInterval.TabIndex = 0;
            this.txtRefreshWebDataInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshWebInterval;
            this.txtRefreshWebDataInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtRefreshWebDataInterval, resources.GetString("txtRefreshWebDataInterval.ToolTip"));
            this.txtRefreshWebDataInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtNarodmonMAC
            // 
            this.txtNarodmonMAC.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Narodmon_MAC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNarodmonMAC.Location = new System.Drawing.Point(45, 150);
            this.txtNarodmonMAC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNarodmonMAC.Name = "txtNarodmonMAC";
            this.txtNarodmonMAC.Size = new System.Drawing.Size(157, 22);
            this.txtNarodmonMAC.TabIndex = 1;
            this.txtNarodmonMAC.Text = global::WeatherStation.Properties.Settings.Default.Narodmon_MAC;
            this.MyToolTip.SetToolTip(this.txtNarodmonMAC, "ID for Narodmon, must be unique\r\n\r\nThe service recommend to use Ethernet MAC addr" +
        "ess. Pressing \"Genereate\" button will put use your default Ethernet adapter MAC " +
        "address.");
            // 
            // txtWebDataURL
            // 
            this.txtWebDataURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WebDataURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWebDataURL.Location = new System.Drawing.Point(9, 47);
            this.txtWebDataURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebDataURL.Name = "txtWebDataURL";
            this.txtWebDataURL.Size = new System.Drawing.Size(368, 22);
            this.txtWebDataURL.TabIndex = 0;
            this.txtWebDataURL.Text = global::WeatherStation.Properties.Settings.Default.WebDataURL;
            this.MyToolTip.SetToolTip(this.txtWebDataURL, "Full URL for script, which handle GET query with data");
            // 
            // chkNarodMon
            // 
            this.chkNarodMon.AutoSize = true;
            this.chkNarodMon.Checked = global::WeatherStation.Properties.Settings.Default.SendToNarodmon;
            this.chkNarodMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNarodMon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "SendToNarodmon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNarodMon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkNarodMon.Location = new System.Drawing.Point(9, 122);
            this.chkNarodMon.Margin = new System.Windows.Forms.Padding(4);
            this.chkNarodMon.Name = "chkNarodMon";
            this.chkNarodMon.Size = new System.Drawing.Size(221, 21);
            this.chkNarodMon.TabIndex = 9;
            this.chkNarodMon.Text = "Send data to NARODMON.RU";
            this.MyToolTip.SetToolTip(this.chkNarodMon, "Send data to NARODMON.RU service flag.\r\nThis is happened not often then 5 minutes" +
        " (narodmon limitation)");
            this.chkNarodMon.UseVisualStyleBackColor = true;
            // 
            // chkWebData
            // 
            this.chkWebData.AutoSize = true;
            this.chkWebData.Checked = global::WeatherStation.Properties.Settings.Default.WebDataFlag;
            this.chkWebData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWebData.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "WebDataFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWebData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkWebData.Location = new System.Drawing.Point(9, 25);
            this.chkWebData.Margin = new System.Windows.Forms.Padding(4);
            this.chkWebData.Name = "chkWebData";
            this.chkWebData.Size = new System.Drawing.Size(184, 21);
            this.chkWebData.TabIndex = 9;
            this.chkWebData.Text = "Send data to web server";
            this.chkWebData.UseVisualStyleBackColor = true;
            // 
            // chkShowDebugPannels
            // 
            this.chkShowDebugPannels.AutoSize = true;
            this.chkShowDebugPannels.Checked = global::WeatherStation.Properties.Settings.Default.ShowDebugPannels;
            this.chkShowDebugPannels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDebugPannels.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "ShowDebugPannels", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShowDebugPannels.Location = new System.Drawing.Point(8, 90);
            this.chkShowDebugPannels.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowDebugPannels.Name = "chkShowDebugPannels";
            this.chkShowDebugPannels.Size = new System.Drawing.Size(169, 21);
            this.chkShowDebugPannels.TabIndex = 0;
            this.chkShowDebugPannels.Text = "Show debug elements";
            this.MyToolTip.SetToolTip(this.chkShowDebugPannels, "Requires restart");
            this.chkShowDebugPannels.UseVisualStyleBackColor = true;
            // 
            // chkTrayIcon
            // 
            this.chkTrayIcon.AutoSize = true;
            this.chkTrayIcon.Checked = global::WeatherStation.Properties.Settings.Default.MinimizeToSystemTray;
            this.chkTrayIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrayIcon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "MinimizeToSystemTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTrayIcon.Location = new System.Drawing.Point(8, 57);
            this.chkTrayIcon.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrayIcon.Name = "chkTrayIcon";
            this.chkTrayIcon.Size = new System.Drawing.Size(176, 21);
            this.chkTrayIcon.TabIndex = 0;
            this.chkTrayIcon.Text = "Minimize to system tray";
            this.chkTrayIcon.UseVisualStyleBackColor = true;
            // 
            // chkMinMode
            // 
            this.chkMinMode.AutoSize = true;
            this.chkMinMode.Checked = global::WeatherStation.Properties.Settings.Default.MinModeEnabled;
            this.chkMinMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "MinModeEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMinMode.Location = new System.Drawing.Point(8, 26);
            this.chkMinMode.Margin = new System.Windows.Forms.Padding(4);
            this.chkMinMode.Name = "chkMinMode";
            this.chkMinMode.Size = new System.Drawing.Size(316, 21);
            this.chkMinMode.TabIndex = 0;
            this.chkMinMode.Text = "Minimize button switch program to MIN MODE";
            this.chkMinMode.UseVisualStyleBackColor = true;
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Items.AddRange(new object[] {
            "1 - Common messages",
            "2 - Prog activity",
            "3 - All debug info"});
            this.cmbLogLevel.Location = new System.Drawing.Point(149, 55);
            this.cmbLogLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(171, 24);
            this.cmbLogLevel.TabIndex = 3;
            this.cmbLogLevel.Text = "1 - Common messages";
            this.MyToolTip.SetToolTip(this.cmbLogLevel, "Logging level. 1 - recomended");
            // 
            // txtBoltwoodFileLocation
            // 
            this.txtBoltwoodFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "BoltwoodFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoltwoodFileLocation.Location = new System.Drawing.Point(148, 142);
            this.txtBoltwoodFileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoltwoodFileLocation.Name = "txtBoltwoodFileLocation";
            this.txtBoltwoodFileLocation.Size = new System.Drawing.Size(207, 22);
            this.txtBoltwoodFileLocation.TabIndex = 11;
            this.txtBoltwoodFileLocation.Text = global::WeatherStation.Properties.Settings.Default.BoltwoodFileLocation;
            this.MyToolTip.SetToolTip(this.txtBoltwoodFileLocation, "Path for boltwood cloud sensor II format data file. If left empty - program direc" +
        "tory");
            // 
            // txtLogFileLocation
            // 
            this.txtLogFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "logFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLogFileLocation.Location = new System.Drawing.Point(148, 25);
            this.txtLogFileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogFileLocation.Name = "txtLogFileLocation";
            this.txtLogFileLocation.Size = new System.Drawing.Size(207, 22);
            this.txtLogFileLocation.TabIndex = 1;
            this.txtLogFileLocation.Text = global::WeatherStation.Properties.Settings.Default.logFileLocation;
            this.MyToolTip.SetToolTip(this.txtLogFileLocation, "Path to program log file. If left empty - program directory");
            // 
            // txtSerialLogFileLocation
            // 
            this.txtSerialLogFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "SerialLogFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSerialLogFileLocation.Location = new System.Drawing.Point(149, 82);
            this.txtSerialLogFileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerialLogFileLocation.Name = "txtSerialLogFileLocation";
            this.txtSerialLogFileLocation.Size = new System.Drawing.Size(207, 22);
            this.txtSerialLogFileLocation.TabIndex = 5;
            this.txtSerialLogFileLocation.Text = global::WeatherStation.Properties.Settings.Default.SerialLogFileLocation;
            this.MyToolTip.SetToolTip(this.txtSerialLogFileLocation, "Path to serial data exchange with Arduino log file. If left empty - program direc" +
        "tory");
            // 
            // txtCSVFileLocation
            // 
            this.txtCSVFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "CSVFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSVFileLocation.Location = new System.Drawing.Point(149, 111);
            this.txtCSVFileLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSVFileLocation.Name = "txtCSVFileLocation";
            this.txtCSVFileLocation.Size = new System.Drawing.Size(207, 22);
            this.txtCSVFileLocation.TabIndex = 8;
            this.txtCSVFileLocation.Text = global::WeatherStation.Properties.Settings.Default.CSVFileLocation;
            this.MyToolTip.SetToolTip(this.txtCSVFileLocation, "Storage path for data files. If left empty - program directory");
            // 
            // chkBoltwoodFileFlag
            // 
            this.chkBoltwoodFileFlag.AutoSize = true;
            this.chkBoltwoodFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.BoltwoodFileFlag;
            this.chkBoltwoodFileFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoltwoodFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "BoltwoodFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkBoltwoodFileFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBoltwoodFileFlag.Location = new System.Drawing.Point(9, 144);
            this.chkBoltwoodFileFlag.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoltwoodFileFlag.Name = "chkBoltwoodFileFlag";
            this.chkBoltwoodFileFlag.Size = new System.Drawing.Size(131, 21);
            this.chkBoltwoodFileFlag.TabIndex = 10;
            this.chkBoltwoodFileFlag.Text = "Boltwood CS file";
            this.MyToolTip.SetToolTip(this.chkBoltwoodFileFlag, "Path for boltwood cloud sensor II format data file. If left empty - program direc" +
        "tory");
            this.chkBoltwoodFileFlag.UseVisualStyleBackColor = true;
            // 
            // chkSerialLogFileFlag
            // 
            this.chkSerialLogFileFlag.AutoSize = true;
            this.chkSerialLogFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.SerialLogFileFlag;
            this.chkSerialLogFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "SerialLogFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkSerialLogFileFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSerialLogFileFlag.Location = new System.Drawing.Point(9, 86);
            this.chkSerialLogFileFlag.Margin = new System.Windows.Forms.Padding(4);
            this.chkSerialLogFileFlag.Name = "chkSerialLogFileFlag";
            this.chkSerialLogFileFlag.Size = new System.Drawing.Size(111, 21);
            this.chkSerialLogFileFlag.TabIndex = 4;
            this.chkSerialLogFileFlag.Text = "Serial log file";
            this.MyToolTip.SetToolTip(this.chkSerialLogFileFlag, "Path to serial data exchange with Arduino log file. If left empty - program direc" +
        "tory");
            this.chkSerialLogFileFlag.UseVisualStyleBackColor = true;
            // 
            // chkCSVFileFlag
            // 
            this.chkCSVFileFlag.AutoSize = true;
            this.chkCSVFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.CSVFileFlag;
            this.chkCSVFileFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCSVFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "CSVFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCSVFileFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCSVFileFlag.Location = new System.Drawing.Point(9, 114);
            this.chkCSVFileFlag.Margin = new System.Windows.Forms.Padding(4);
            this.chkCSVFileFlag.Name = "chkCSVFileFlag";
            this.chkCSVFileFlag.Size = new System.Drawing.Size(113, 21);
            this.chkCSVFileFlag.TabIndex = 7;
            this.chkCSVFileFlag.Text = "Data CSV file";
            this.chkCSVFileFlag.UseVisualStyleBackColor = true;
            // 
            // chkLogFileFlag
            // 
            this.chkLogFileFlag.AutoSize = true;
            this.chkLogFileFlag.Checked = global::WeatherStation.Properties.Settings.Default.logFileFlag;
            this.chkLogFileFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogFileFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "logFileFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkLogFileFlag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkLogFileFlag.Location = new System.Drawing.Point(9, 27);
            this.chkLogFileFlag.Margin = new System.Windows.Forms.Padding(4);
            this.chkLogFileFlag.Name = "chkLogFileFlag";
            this.chkLogFileFlag.Size = new System.Drawing.Size(129, 21);
            this.chkLogFileFlag.TabIndex = 0;
            this.chkLogFileFlag.Text = "Program log file";
            this.MyToolTip.SetToolTip(this.chkLogFileFlag, "Path to program log file. If left empty - program directory");
            this.chkLogFileFlag.UseVisualStyleBackColor = true;
            // 
            // txtRefreshInterval
            // 
            this.txtRefreshInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefreshInterval.Location = new System.Drawing.Point(197, 20);
            this.txtRefreshInterval.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefreshInterval.Name = "txtRefreshInterval";
            this.txtRefreshInterval.Size = new System.Drawing.Size(69, 22);
            this.txtRefreshInterval.TabIndex = 0;
            this.txtRefreshInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshInterval;
            this.txtRefreshInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtRefreshInterval, resources.GetString("txtRefreshInterval.ToolTip"));
            this.txtRefreshInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtMaxPoints
            // 
            this.txtMaxPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "MaxPoints", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxPoints.Location = new System.Drawing.Point(197, 47);
            this.txtMaxPoints.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxPoints.Name = "txtMaxPoints";
            this.txtMaxPoints.Size = new System.Drawing.Size(69, 22);
            this.txtMaxPoints.TabIndex = 1;
            this.txtMaxPoints.Text = global::WeatherStation.Properties.Settings.Default.MaxPoints;
            this.txtMaxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtMaxPoints, "Max number of points displaying on charts. Too big values will leed to large memo" +
        "ry consumption");
            this.txtMaxPoints.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // chkWatchdog
            // 
            this.chkWatchdog.AutoSize = true;
            this.chkWatchdog.Checked = global::WeatherStation.Properties.Settings.Default.ComWatchdog;
            this.chkWatchdog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWatchdog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "ComWatchdog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWatchdog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkWatchdog.Location = new System.Drawing.Point(9, 57);
            this.chkWatchdog.Margin = new System.Windows.Forms.Padding(4);
            this.chkWatchdog.Name = "chkWatchdog";
            this.chkWatchdog.Size = new System.Drawing.Size(165, 21);
            this.chkWatchdog.TabIndex = 2;
            this.chkWatchdog.Text = "Connection watchdog";
            this.chkWatchdog.UseVisualStyleBackColor = true;
            // 
            // chkResetArduino
            // 
            this.chkResetArduino.AutoSize = true;
            this.chkResetArduino.Checked = global::WeatherStation.Properties.Settings.Default.resetArduino;
            this.chkResetArduino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResetArduino.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "resetArduino", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkResetArduino.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkResetArduino.Location = new System.Drawing.Point(137, 26);
            this.chkResetArduino.Margin = new System.Windows.Forms.Padding(4);
            this.chkResetArduino.Name = "chkResetArduino";
            this.chkResetArduino.Size = new System.Drawing.Size(254, 21);
            this.chkResetArduino.TabIndex = 1;
            this.chkResetArduino.Text = "Reset Arduino board on connection";
            this.MyToolTip.SetToolTip(this.chkResetArduino, "If set, will restart Arduino board on connection.\r\nHighly recomended to leave it " +
        "enabled");
            this.chkResetArduino.UseVisualStyleBackColor = true;
            // 
            // cmbPortList
            // 
            this.cmbPortList.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "comport", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(9, 23);
            this.cmbPortList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(120, 24);
            this.cmbPortList.TabIndex = 0;
            this.cmbPortList.Text = global::WeatherStation.Properties.Settings.Default.comport;
            // 
            // txtWSpeedZero
            // 
            this.txtWSpeedZero.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WindSpeed_Zero", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWSpeedZero.Location = new System.Drawing.Point(197, 20);
            this.txtWSpeedZero.Margin = new System.Windows.Forms.Padding(4);
            this.txtWSpeedZero.Name = "txtWSpeedZero";
            this.txtWSpeedZero.Size = new System.Drawing.Size(69, 22);
            this.txtWSpeedZero.TabIndex = 2;
            this.txtWSpeedZero.Text = global::WeatherStation.Properties.Settings.Default.WindSpeed_Zero;
            this.txtWSpeedZero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtWSpeedZero, resources.GetString("txtWSpeedZero.ToolTip"));
            // 
            // txtVeryWindyLimit
            // 
            this.txtVeryWindyLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "VeryWindyLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtVeryWindyLimit.Location = new System.Drawing.Point(197, 80);
            this.txtVeryWindyLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeryWindyLimit.Name = "txtVeryWindyLimit";
            this.txtVeryWindyLimit.Size = new System.Drawing.Size(69, 22);
            this.txtVeryWindyLimit.TabIndex = 1;
            this.txtVeryWindyLimit.Text = global::WeatherStation.Properties.Settings.Default.VeryWindyLimit;
            this.txtVeryWindyLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtVeryWindyLimit, "Subjective value, usually 8-9 m/s\r\nYou can use Beaufort Scale (see https://en.wik" +
        "ipedia.org/wiki/Beaufort_scale) for a reference\r\n");
            this.txtVeryWindyLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtWindyLimit
            // 
            this.txtWindyLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WindyLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWindyLimit.Location = new System.Drawing.Point(197, 50);
            this.txtWindyLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtWindyLimit.Name = "txtWindyLimit";
            this.txtWindyLimit.Size = new System.Drawing.Size(69, 22);
            this.txtWindyLimit.TabIndex = 0;
            this.txtWindyLimit.Text = global::WeatherStation.Properties.Settings.Default.WindyLimit;
            this.txtWindyLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtWindyLimit, "Subjective value, usually 4..5 m/s\r\nYou can use Beaufort Scale (see https://en.wi" +
        "kipedia.org/wiki/Beaufort_scale) for a reference");
            this.txtWindyLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtK1
            // 
            this.txtK1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK1.Location = new System.Drawing.Point(15, 39);
            this.txtK1.Margin = new System.Windows.Forms.Padding(4);
            this.txtK1.Name = "txtK1";
            this.txtK1.Size = new System.Drawing.Size(33, 22);
            this.txtK1.TabIndex = 16;
            this.txtK1.Text = global::WeatherStation.Properties.Settings.Default.K1;
            this.txtK1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK1, resources.GetString("txtK1.ToolTip"));
            this.txtK1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK2
            // 
            this.txtK2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK2.Location = new System.Drawing.Point(57, 39);
            this.txtK2.Margin = new System.Windows.Forms.Padding(4);
            this.txtK2.Name = "txtK2";
            this.txtK2.Size = new System.Drawing.Size(31, 22);
            this.txtK2.TabIndex = 17;
            this.txtK2.Text = global::WeatherStation.Properties.Settings.Default.K2;
            this.txtK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK2, resources.GetString("txtK2.ToolTip"));
            this.txtK2.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK7
            // 
            this.txtK7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK7.Location = new System.Drawing.Point(257, 39);
            this.txtK7.Margin = new System.Windows.Forms.Padding(4);
            this.txtK7.Name = "txtK7";
            this.txtK7.Size = new System.Drawing.Size(31, 22);
            this.txtK7.TabIndex = 22;
            this.txtK7.Text = global::WeatherStation.Properties.Settings.Default.K7;
            this.txtK7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK7, resources.GetString("txtK7.ToolTip"));
            this.txtK7.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK3
            // 
            this.txtK3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK3.Location = new System.Drawing.Point(97, 39);
            this.txtK3.Margin = new System.Windows.Forms.Padding(4);
            this.txtK3.Name = "txtK3";
            this.txtK3.Size = new System.Drawing.Size(31, 22);
            this.txtK3.TabIndex = 18;
            this.txtK3.Text = global::WeatherStation.Properties.Settings.Default.K3;
            this.txtK3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK3, resources.GetString("txtK3.ToolTip"));
            this.txtK3.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK6
            // 
            this.txtK6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK6.Location = new System.Drawing.Point(217, 39);
            this.txtK6.Margin = new System.Windows.Forms.Padding(4);
            this.txtK6.Name = "txtK6";
            this.txtK6.Size = new System.Drawing.Size(31, 22);
            this.txtK6.TabIndex = 21;
            this.txtK6.Text = global::WeatherStation.Properties.Settings.Default.K6;
            this.txtK6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK6, resources.GetString("txtK6.ToolTip"));
            this.txtK6.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK4
            // 
            this.txtK4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK4.Location = new System.Drawing.Point(137, 39);
            this.txtK4.Margin = new System.Windows.Forms.Padding(4);
            this.txtK4.Name = "txtK4";
            this.txtK4.Size = new System.Drawing.Size(31, 22);
            this.txtK4.TabIndex = 19;
            this.txtK4.Text = global::WeatherStation.Properties.Settings.Default.K4;
            this.txtK4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK4, resources.GetString("txtK4.ToolTip"));
            this.txtK4.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK5
            // 
            this.txtK5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK5.Location = new System.Drawing.Point(177, 39);
            this.txtK5.Margin = new System.Windows.Forms.Padding(4);
            this.txtK5.Name = "txtK5";
            this.txtK5.Size = new System.Drawing.Size(31, 22);
            this.txtK5.TabIndex = 20;
            this.txtK5.Text = global::WeatherStation.Properties.Settings.Default.K5;
            this.txtK5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK5, resources.GetString("txtK5.ToolTip"));
            this.txtK5.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // cmbWetMode
            // 
            this.cmbWetMode.FormattingEnabled = true;
            this.cmbWetMode.Items.AddRange(new object[] {
            "Use both",
            "Wet only",
            "RGC only"});
            this.cmbWetMode.Location = new System.Drawing.Point(197, 75);
            this.cmbWetMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbWetMode.Name = "cmbWetMode";
            this.cmbWetMode.Size = new System.Drawing.Size(171, 24);
            this.cmbWetMode.TabIndex = 2;
            this.cmbWetMode.Text = "Use both";
            this.MyToolTip.SetToolTip(this.cmbWetMode, "Which sensor program should use to measure rain condition if more then one presen" +
        "t (wet sensor and optical rain gauge counter)\r\nIf you have two of them - use \"Bo" +
        "th\" unless you face problems");
            // 
            // txtWetLimit
            // 
            this.txtWetLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WetLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWetLimit.Location = new System.Drawing.Point(197, 20);
            this.txtWetLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtWetLimit.Name = "txtWetLimit";
            this.txtWetLimit.Size = new System.Drawing.Size(69, 22);
            this.txtWetLimit.TabIndex = 0;
            this.txtWetLimit.Text = global::WeatherStation.Properties.Settings.Default.WetLimit;
            this.txtWetLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtWetLimit, resources.GetString("txtWetLimit.ToolTip"));
            this.txtWetLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtRainLimit
            // 
            this.txtRainLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RainLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRainLimit.Location = new System.Drawing.Point(197, 47);
            this.txtRainLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtRainLimit.Name = "txtRainLimit";
            this.txtRainLimit.Size = new System.Drawing.Size(69, 22);
            this.txtRainLimit.TabIndex = 1;
            this.txtRainLimit.Text = global::WeatherStation.Properties.Settings.Default.RainLimit;
            this.txtRainLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtRainLimit, "Rain threshold limit. All values higher then this will be treated as a wet condit" +
        "ion, and lower as a rain condition");
            this.txtRainLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCloudysky
            // 
            this.txtCloudysky.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Cloudysky", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCloudysky.Location = new System.Drawing.Point(197, 50);
            this.txtCloudysky.Margin = new System.Windows.Forms.Padding(4);
            this.txtCloudysky.Name = "txtCloudysky";
            this.txtCloudysky.Size = new System.Drawing.Size(69, 22);
            this.txtCloudysky.TabIndex = 1;
            this.txtCloudysky.Text = global::WeatherStation.Properties.Settings.Default.Cloudysky;
            this.txtCloudysky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCloudysky, "Cloudy sky threshold limit. All values higher then this will be treated as a clou" +
        "dy sky and lower - as a very cloudy");
            this.txtCloudysky.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtClearsky
            // 
            this.txtClearsky.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Clearsky", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtClearsky.Location = new System.Drawing.Point(197, 20);
            this.txtClearsky.Margin = new System.Windows.Forms.Padding(4);
            this.txtClearsky.Name = "txtClearsky";
            this.txtClearsky.Size = new System.Drawing.Size(69, 22);
            this.txtClearsky.TabIndex = 0;
            this.txtClearsky.Text = global::WeatherStation.Properties.Settings.Default.Clearsky;
            this.txtClearsky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtClearsky, "Clear sky threshold limit. All values higher then this will be treated as a clear" +
        " sky");
            this.txtClearsky.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // cmbBaseTempSensor
            // 
            this.cmbBaseTempSensor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "BaseTempSensor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbBaseTempSensor.FormattingEnabled = true;
            this.cmbBaseTempSensor.Location = new System.Drawing.Point(177, 26);
            this.cmbBaseTempSensor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaseTempSensor.Name = "cmbBaseTempSensor";
            this.cmbBaseTempSensor.Size = new System.Drawing.Size(160, 24);
            this.cmbBaseTempSensor.TabIndex = 16;
            this.cmbBaseTempSensor.Text = global::WeatherStation.Properties.Settings.Default.BaseTempSensor;
            // 
            // txtCSHeaterPauseTime
            // 
            this.txtCSHeaterPauseTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingPauseTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSHeaterPauseTime.Location = new System.Drawing.Point(197, 53);
            this.txtCSHeaterPauseTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSHeaterPauseTime.Name = "txtCSHeaterPauseTime";
            this.txtCSHeaterPauseTime.Size = new System.Drawing.Size(69, 22);
            this.txtCSHeaterPauseTime.TabIndex = 2;
            this.txtCSHeaterPauseTime.Text = global::WeatherStation.Properties.Settings.Default.HeatingPauseTime;
            this.txtCSHeaterPauseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSHeaterPauseTime, "Interval between two autoheating cycles, seconds\r\n");
            this.txtCSHeaterPauseTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCSDecreasingMaxDelta
            // 
            this.txtCSDecreasingMaxDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCS_MaxDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSDecreasingMaxDelta.Location = new System.Drawing.Point(287, 82);
            this.txtCSDecreasingMaxDelta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSDecreasingMaxDelta.Name = "txtCSDecreasingMaxDelta";
            this.txtCSDecreasingMaxDelta.Size = new System.Drawing.Size(69, 22);
            this.txtCSDecreasingMaxDelta.TabIndex = 4;
            this.txtCSDecreasingMaxDelta.Text = global::WeatherStation.Properties.Settings.Default.HeatingCS_MaxDelta;
            this.txtCSDecreasingMaxDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSDecreasingMaxDelta, resources.GetString("txtCSDecreasingMaxDelta.ToolTip"));
            this.txtCSDecreasingMaxDelta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtCSHeatingMax
            // 
            this.txtCSHeatingMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCSThresholdMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSHeatingMax.Location = new System.Drawing.Point(287, 23);
            this.txtCSHeatingMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSHeatingMax.Name = "txtCSHeatingMax";
            this.txtCSHeatingMax.Size = new System.Drawing.Size(69, 22);
            this.txtCSHeatingMax.TabIndex = 1;
            this.txtCSHeatingMax.Text = global::WeatherStation.Properties.Settings.Default.HeatingCSThresholdMax;
            this.txtCSHeatingMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSHeatingMax, "Maximum cloud sensor value, when auto heating could be switched on\r\n");
            this.txtCSHeatingMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCSDecreasingMinDelta
            // 
            this.txtCSDecreasingMinDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCS_MinDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSDecreasingMinDelta.Location = new System.Drawing.Point(197, 82);
            this.txtCSDecreasingMinDelta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSDecreasingMinDelta.Name = "txtCSDecreasingMinDelta";
            this.txtCSDecreasingMinDelta.Size = new System.Drawing.Size(69, 22);
            this.txtCSDecreasingMinDelta.TabIndex = 3;
            this.txtCSDecreasingMinDelta.Text = global::WeatherStation.Properties.Settings.Default.HeatingCS_MinDelta;
            this.txtCSDecreasingMinDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSDecreasingMinDelta, resources.GetString("txtCSDecreasingMinDelta.ToolTip"));
            this.txtCSDecreasingMinDelta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtCSHeatingMin
            // 
            this.txtCSHeatingMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCSThresholdMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSHeatingMin.Location = new System.Drawing.Point(197, 23);
            this.txtCSHeatingMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSHeatingMin.Name = "txtCSHeatingMin";
            this.txtCSHeatingMin.Size = new System.Drawing.Size(69, 22);
            this.txtCSHeatingMin.TabIndex = 0;
            this.txtCSHeatingMin.Text = global::WeatherStation.Properties.Settings.Default.HeatingCSThresholdMin;
            this.txtCSHeatingMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSHeatingMin, "Minimum cloud sensor value, when auto heating could be switched on");
            this.txtCSHeatingMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterWetThreshold
            // 
            this.txtHeaterWetThreshold.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterWetThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingWetThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHeaterWetThreshold.Location = new System.Drawing.Point(197, 80);
            this.txtHeaterWetThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeaterWetThreshold.Name = "txtHeaterWetThreshold";
            this.txtHeaterWetThreshold.Size = new System.Drawing.Size(69, 22);
            this.txtHeaterWetThreshold.TabIndex = 2;
            this.txtHeaterWetThreshold.Text = global::WeatherStation.Properties.Settings.Default.HeatingWetThreshold;
            this.txtHeaterWetThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtHeaterWetThreshold, "Wet sensor value after reaching which heating started automaticaly. \r\nSet 0 to di" +
        "sable");
            this.txtHeaterWetThreshold.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterMaxTemp
            // 
            this.txtHeaterMaxTemp.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterMaxTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingMaxTemp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHeaterMaxTemp.Location = new System.Drawing.Point(197, 20);
            this.txtHeaterMaxTemp.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeaterMaxTemp.Name = "txtHeaterMaxTemp";
            this.txtHeaterMaxTemp.Size = new System.Drawing.Size(69, 22);
            this.txtHeaterMaxTemp.TabIndex = 0;
            this.txtHeaterMaxTemp.Text = global::WeatherStation.Properties.Settings.Default.HeatingMaxTemp;
            this.txtHeaterMaxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtHeaterMaxTemp, "Maximum temperature delta which can be reached during heating. Measured by MLX te" +
        "mperature sensor (ATemp) minus \"Base temp sensor\" value");
            this.txtHeaterMaxTemp.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterMaxDuration
            // 
            this.txtHeaterMaxDuration.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterMaxDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingMaxDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHeaterMaxDuration.Location = new System.Drawing.Point(197, 50);
            this.txtHeaterMaxDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeaterMaxDuration.Name = "txtHeaterMaxDuration";
            this.txtHeaterMaxDuration.Size = new System.Drawing.Size(69, 22);
            this.txtHeaterMaxDuration.TabIndex = 1;
            this.txtHeaterMaxDuration.Text = global::WeatherStation.Properties.Settings.Default.HeatingMaxDuration;
            this.txtHeaterMaxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtHeaterMaxDuration, "Maximum heating cycle duration, sec");
            this.txtHeaterMaxDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(836, 491);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
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
        private System.Windows.Forms.CheckBox chkResetArduino;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SensorEnabled;
        private System.Windows.Forms.DataGridViewComboBoxColumn SensorType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendToWeb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendToNarodmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArduinoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebCustomName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FormFieldName;
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
    }
}