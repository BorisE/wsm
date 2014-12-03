namespace WeatherStation
{
    partial class PreferencesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.K7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBoltwoodPathBrowse = new System.Windows.Forms.Button();
            this.btnSerialLogPathBrowse = new System.Windows.Forms.Button();
            this.btnCSVPathBrowse = new System.Windows.Forms.Button();
            this.btnLogPathBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbWetMode = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnGenerateMac = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnResetSensorList = new System.Windows.Forms.Button();
            this.btnReadFromSerial = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridSensors = new System.Windows.Forms.DataGridView();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SensorType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SendToWeb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SendToNarodmon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ArduinoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebCustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormFieldName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbBaseTempSensor = new System.Windows.Forms.ComboBox();
            this.txtNarodmonMAC = new System.Windows.Forms.TextBox();
            this.txtWebDataURL = new System.Windows.Forms.TextBox();
            this.chkNarodMon = new System.Windows.Forms.CheckBox();
            this.chkWebData = new System.Windows.Forms.CheckBox();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.txtBoltwoodFileLocation = new System.Windows.Forms.TextBox();
            this.txtLogFileLocation = new System.Windows.Forms.TextBox();
            this.txtSerialLogFileLocation = new System.Windows.Forms.TextBox();
            this.txtCSVFileLocation = new System.Windows.Forms.TextBox();
            this.chkBoltwoodFileFlag = new System.Windows.Forms.CheckBox();
            this.chkSerialLogFileFlag = new System.Windows.Forms.CheckBox();
            this.chkCSVFileFlag = new System.Windows.Forms.CheckBox();
            this.chkLogFileFlag = new System.Windows.Forms.CheckBox();
            this.txtCSHeaterPauseTime = new System.Windows.Forms.TextBox();
            this.txtCSDecreasingMaxDelta = new System.Windows.Forms.TextBox();
            this.txtCSHeatingMax = new System.Windows.Forms.TextBox();
            this.txtCSDecreasingMinDelta = new System.Windows.Forms.TextBox();
            this.txtCSHeatingMin = new System.Windows.Forms.TextBox();
            this.txtHeaterWetThreshold = new System.Windows.Forms.TextBox();
            this.txtHeaterMaxTemp = new System.Windows.Forms.TextBox();
            this.txtHeaterMaxDuration = new System.Windows.Forms.TextBox();
            this.txtRefreshInterval = new System.Windows.Forms.TextBox();
            this.txtMaxPoints = new System.Windows.Forms.TextBox();
            this.txtWetLimit = new System.Windows.Forms.TextBox();
            this.txtRainLimit = new System.Windows.Forms.TextBox();
            this.txtCloudysky = new System.Windows.Forms.TextBox();
            this.txtClearsky = new System.Windows.Forms.TextBox();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.txtK7 = new System.Windows.Forms.TextBox();
            this.txtK3 = new System.Windows.Forms.TextBox();
            this.txtK6 = new System.Windows.Forms.TextBox();
            this.txtK4 = new System.Windows.Forms.TextBox();
            this.txtK5 = new System.Windows.Forms.TextBox();
            this.chkWatchdog = new System.Windows.Forms.CheckBox();
            this.chkResetArduino = new System.Windows.Forms.CheckBox();
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSensors)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(540, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 24);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWatchdog);
            this.groupBox1.Controls.Add(this.chkResetArduino);
            this.groupBox1.Controls.Add(this.cmbPortList);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.K7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCloudysky);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtClearsky);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtK1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtK2);
            this.groupBox2.Controls.Add(this.txtK7);
            this.groupBox2.Controls.Add(this.txtK3);
            this.groupBox2.Controls.Add(this.txtK6);
            this.groupBox2.Controls.Add(this.txtK4);
            this.groupBox2.Controls.Add(this.txtK5);
            this.groupBox2.Location = new System.Drawing.Point(318, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cloud sensor model";
            // 
            // K7
            // 
            this.K7.AutoSize = true;
            this.K7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.K7.Location = new System.Drawing.Point(195, 74);
            this.K7.Name = "K7";
            this.K7.Size = new System.Drawing.Size(20, 13);
            this.K7.TabIndex = 1;
            this.K7.Text = "K7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cloudy sky threshold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(165, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "K6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clear sky threshold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(135, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "K5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(105, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "K4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(75, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "K3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(45, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "K2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "K1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.groupBox3.Location = new System.Drawing.Point(5, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 139);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Logging level";
            // 
            // btnBoltwoodPathBrowse
            // 
            this.btnBoltwoodPathBrowse.Location = new System.Drawing.Point(274, 114);
            this.btnBoltwoodPathBrowse.Name = "btnBoltwoodPathBrowse";
            this.btnBoltwoodPathBrowse.Size = new System.Drawing.Size(27, 20);
            this.btnBoltwoodPathBrowse.TabIndex = 12;
            this.btnBoltwoodPathBrowse.Text = "...";
            this.btnBoltwoodPathBrowse.UseVisualStyleBackColor = true;
            this.btnBoltwoodPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnSerialLogPathBrowse
            // 
            this.btnSerialLogPathBrowse.Location = new System.Drawing.Point(274, 67);
            this.btnSerialLogPathBrowse.Name = "btnSerialLogPathBrowse";
            this.btnSerialLogPathBrowse.Size = new System.Drawing.Size(27, 20);
            this.btnSerialLogPathBrowse.TabIndex = 6;
            this.btnSerialLogPathBrowse.Text = "...";
            this.btnSerialLogPathBrowse.UseVisualStyleBackColor = true;
            this.btnSerialLogPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnCSVPathBrowse
            // 
            this.btnCSVPathBrowse.Location = new System.Drawing.Point(274, 89);
            this.btnCSVPathBrowse.Name = "btnCSVPathBrowse";
            this.btnCSVPathBrowse.Size = new System.Drawing.Size(27, 20);
            this.btnCSVPathBrowse.TabIndex = 9;
            this.btnCSVPathBrowse.Text = "...";
            this.btnCSVPathBrowse.UseVisualStyleBackColor = true;
            this.btnCSVPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnLogPathBrowse
            // 
            this.btnLogPathBrowse.Location = new System.Drawing.Point(274, 19);
            this.btnLogPathBrowse.Name = "btnLogPathBrowse";
            this.btnLogPathBrowse.Size = new System.Drawing.Size(27, 20);
            this.btnLogPathBrowse.TabIndex = 2;
            this.btnLogPathBrowse.Text = "...";
            this.btnLogPathBrowse.UseVisualStyleBackColor = true;
            this.btnLogPathBrowse.Click += new System.EventHandler(this.btnLogPathBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(540, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 24);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cmbWetMode);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtWetLimit);
            this.groupBox5.Controls.Add(this.txtRainLimit);
            this.groupBox5.Location = new System.Drawing.Point(318, 347);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 123);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rain sensor model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Wet threshold";
            // 
            // cmbWetMode
            // 
            this.cmbWetMode.FormattingEnabled = true;
            this.cmbWetMode.Items.AddRange(new object[] {
            "Use both",
            "Wet only",
            "RGC only"});
            this.cmbWetMode.Location = new System.Drawing.Point(148, 61);
            this.cmbWetMode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWetMode.Name = "cmbWetMode";
            this.cmbWetMode.Size = new System.Drawing.Size(129, 21);
            this.cmbWetMode.TabIndex = 2;
            this.cmbWetMode.Text = "Use both";
            this.MyToolTip.SetToolTip(this.cmbWetMode, "Which sensor program should use to measure rain condition if more then one presen" +
        "t (wet sensor and optical rain gauge counter)\r\nIf you have two of them - use \"Bo" +
        "th\" unless you face problems");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(7, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Rain sensors mode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(7, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Rain threshold";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtRefreshInterval);
            this.groupBox6.Controls.Add(this.txtMaxPoints);
            this.groupBox6.Location = new System.Drawing.Point(5, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 62);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gragh settings";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(6, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Refresh interval";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(7, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Max points on graph";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnGenerateMac);
            this.groupBox7.Controls.Add(this.txtNarodmonMAC);
            this.groupBox7.Controls.Add(this.txtWebDataURL);
            this.groupBox7.Controls.Add(this.chkNarodMon);
            this.groupBox7.Controls.Add(this.chkWebData);
            this.groupBox7.Location = new System.Drawing.Point(318, 80);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(307, 139);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Web server";
            // 
            // btnGenerateMac
            // 
            this.btnGenerateMac.Location = new System.Drawing.Point(132, 93);
            this.btnGenerateMac.Name = "btnGenerateMac";
            this.btnGenerateMac.Size = new System.Drawing.Size(59, 23);
            this.btnGenerateMac.TabIndex = 2;
            this.btnGenerateMac.Text = "Generate";
            this.MyToolTip.SetToolTip(this.btnGenerateMac, "Press to generate ID based on computer MAC address");
            this.btnGenerateMac.UseVisualStyleBackColor = true;
            this.btnGenerateMac.Click += new System.EventHandler(this.btnGenerateMac_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MyToolTip
            // 
            this.MyToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnResetSensorList
            // 
            this.btnResetSensorList.Location = new System.Drawing.Point(475, 224);
            this.btnResetSensorList.Name = "btnResetSensorList";
            this.btnResetSensorList.Size = new System.Drawing.Size(139, 23);
            this.btnResetSensorList.TabIndex = 16;
            this.btnResetSensorList.Text = "Reset sensor list to default";
            this.MyToolTip.SetToolTip(this.btnResetSensorList, "Will delete all your entries in sensor list and fill with default values");
            this.btnResetSensorList.UseVisualStyleBackColor = true;
            this.btnResetSensorList.Click += new System.EventHandler(this.btnResetSensorList_Click);
            // 
            // btnReadFromSerial
            // 
            this.btnReadFromSerial.Location = new System.Drawing.Point(332, 224);
            this.btnReadFromSerial.Name = "btnReadFromSerial";
            this.btnReadFromSerial.Size = new System.Drawing.Size(139, 23);
            this.btnReadFromSerial.TabIndex = 16;
            this.btnReadFromSerial.Text = "Read from serial port";
            this.MyToolTip.SetToolTip(this.btnReadFromSerial, "Not implemented yet");
            this.btnReadFromSerial.UseVisualStyleBackColor = true;
            this.btnReadFromSerial.Click += new System.EventHandler(this.btnReadFromSerial_Click);
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
            this.groupBox9.Location = new System.Drawing.Point(5, 385);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(307, 85);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "CS auto heater settings";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(205, 64);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "-";
            this.label20.TextChanged += new System.EventHandler(this.txtCheckFloatPos_TextChanged);
            this.label20.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(205, 16);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "-";
            this.label22.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.label22.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(6, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Heater pause time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(7, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "CS decreasing threshold";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(6, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "CS threshold switching on";
            // 
            // dataGridSensors
            // 
            this.dataGridSensors.AllowUserToAddRows = false;
            this.dataGridSensors.AllowUserToDeleteRows = false;
            this.dataGridSensors.AllowUserToOrderColumns = true;
            this.dataGridSensors.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSensors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridSensors.Location = new System.Drawing.Point(9, 19);
            this.dataGridSensors.Name = "dataGridSensors";
            this.dataGridSensors.RowHeadersVisible = false;
            this.dataGridSensors.Size = new System.Drawing.Size(604, 201);
            this.dataGridSensors.TabIndex = 13;
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnReadFromSerial);
            this.groupBox8.Controls.Add(this.btnResetSensorList);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.cmbBaseTempSensor);
            this.groupBox8.Controls.Add(this.dataGridSensors);
            this.groupBox8.Location = new System.Drawing.Point(5, 470);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(620, 252);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sensors";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Base temp sensor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtHeaterWetThreshold);
            this.groupBox4.Controls.Add(this.txtHeaterMaxTemp);
            this.groupBox4.Controls.Add(this.txtHeaterMaxDuration);
            this.groupBox4.Location = new System.Drawing.Point(5, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 91);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Heater settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Max temperature delta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(7, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Wet threshold switching on";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(7, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Max cycle duration";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbBaseTempSensor
            // 
            this.cmbBaseTempSensor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "BaseTempSensor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbBaseTempSensor.FormattingEnabled = true;
            this.cmbBaseTempSensor.Location = new System.Drawing.Point(145, 226);
            this.cmbBaseTempSensor.Name = "cmbBaseTempSensor";
            this.cmbBaseTempSensor.Size = new System.Drawing.Size(121, 21);
            this.cmbBaseTempSensor.TabIndex = 14;
            this.cmbBaseTempSensor.Text = global::WeatherStation.Properties.Settings.Default.BaseTempSensor;
            // 
            // txtNarodmonMAC
            // 
            this.txtNarodmonMAC.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Narodmon_MAC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNarodmonMAC.Location = new System.Drawing.Point(7, 95);
            this.txtNarodmonMAC.Name = "txtNarodmonMAC";
            this.txtNarodmonMAC.Size = new System.Drawing.Size(119, 20);
            this.txtNarodmonMAC.TabIndex = 1;
            this.txtNarodmonMAC.Text = global::WeatherStation.Properties.Settings.Default.Narodmon_MAC;
            // 
            // txtWebDataURL
            // 
            this.txtWebDataURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WebDataURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWebDataURL.Location = new System.Drawing.Point(7, 38);
            this.txtWebDataURL.Name = "txtWebDataURL";
            this.txtWebDataURL.Size = new System.Drawing.Size(294, 20);
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
            this.chkNarodMon.Location = new System.Drawing.Point(7, 72);
            this.chkNarodMon.Name = "chkNarodMon";
            this.chkNarodMon.Size = new System.Drawing.Size(173, 17);
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
            this.chkWebData.Location = new System.Drawing.Point(7, 20);
            this.chkWebData.Name = "chkWebData";
            this.chkWebData.Size = new System.Drawing.Size(142, 17);
            this.chkWebData.TabIndex = 9;
            this.chkWebData.Text = "Send data to web server";
            this.chkWebData.UseVisualStyleBackColor = true;
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "LogLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Items.AddRange(new object[] {
            "1 - Common messages",
            "2 - Prog activity",
            "3 - All debug info"});
            this.cmbLogLevel.Location = new System.Drawing.Point(112, 45);
            this.cmbLogLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(129, 21);
            this.cmbLogLevel.TabIndex = 3;
            this.cmbLogLevel.Text = global::WeatherStation.Properties.Settings.Default.LogLevel;
            this.MyToolTip.SetToolTip(this.cmbLogLevel, "Logging level. 1 - recomended");
            // 
            // txtBoltwoodFileLocation
            // 
            this.txtBoltwoodFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "BoltwoodFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoltwoodFileLocation.Location = new System.Drawing.Point(111, 115);
            this.txtBoltwoodFileLocation.Name = "txtBoltwoodFileLocation";
            this.txtBoltwoodFileLocation.Size = new System.Drawing.Size(156, 20);
            this.txtBoltwoodFileLocation.TabIndex = 11;
            this.txtBoltwoodFileLocation.Text = global::WeatherStation.Properties.Settings.Default.BoltwoodFileLocation;
            this.MyToolTip.SetToolTip(this.txtBoltwoodFileLocation, "Path for boltwood cloud sensor II format data file. If left empty - program direc" +
        "tory");
            // 
            // txtLogFileLocation
            // 
            this.txtLogFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "logFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLogFileLocation.Location = new System.Drawing.Point(111, 20);
            this.txtLogFileLocation.Name = "txtLogFileLocation";
            this.txtLogFileLocation.Size = new System.Drawing.Size(156, 20);
            this.txtLogFileLocation.TabIndex = 1;
            this.txtLogFileLocation.Text = global::WeatherStation.Properties.Settings.Default.logFileLocation;
            this.MyToolTip.SetToolTip(this.txtLogFileLocation, "Path to program log file. If left empty - program directory");
            // 
            // txtSerialLogFileLocation
            // 
            this.txtSerialLogFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "SerialLogFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSerialLogFileLocation.Location = new System.Drawing.Point(112, 67);
            this.txtSerialLogFileLocation.Name = "txtSerialLogFileLocation";
            this.txtSerialLogFileLocation.Size = new System.Drawing.Size(156, 20);
            this.txtSerialLogFileLocation.TabIndex = 5;
            this.txtSerialLogFileLocation.Text = global::WeatherStation.Properties.Settings.Default.SerialLogFileLocation;
            this.MyToolTip.SetToolTip(this.txtSerialLogFileLocation, "Path to serial data exchange with Arduino log file. If left empty - program direc" +
        "tory");
            // 
            // txtCSVFileLocation
            // 
            this.txtCSVFileLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "CSVFileLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSVFileLocation.Location = new System.Drawing.Point(112, 90);
            this.txtCSVFileLocation.Name = "txtCSVFileLocation";
            this.txtCSVFileLocation.Size = new System.Drawing.Size(156, 20);
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
            this.chkBoltwoodFileFlag.Location = new System.Drawing.Point(7, 117);
            this.chkBoltwoodFileFlag.Name = "chkBoltwoodFileFlag";
            this.chkBoltwoodFileFlag.Size = new System.Drawing.Size(103, 17);
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
            this.chkSerialLogFileFlag.Location = new System.Drawing.Point(7, 70);
            this.chkSerialLogFileFlag.Name = "chkSerialLogFileFlag";
            this.chkSerialLogFileFlag.Size = new System.Drawing.Size(85, 17);
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
            this.chkCSVFileFlag.Location = new System.Drawing.Point(7, 93);
            this.chkCSVFileFlag.Name = "chkCSVFileFlag";
            this.chkCSVFileFlag.Size = new System.Drawing.Size(89, 17);
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
            this.chkLogFileFlag.Location = new System.Drawing.Point(7, 22);
            this.chkLogFileFlag.Name = "chkLogFileFlag";
            this.chkLogFileFlag.Size = new System.Drawing.Size(98, 17);
            this.chkLogFileFlag.TabIndex = 0;
            this.chkLogFileFlag.Text = "Program log file";
            this.MyToolTip.SetToolTip(this.chkLogFileFlag, "Path to program log file. If left empty - program directory");
            this.chkLogFileFlag.UseVisualStyleBackColor = true;
            // 
            // txtCSHeaterPauseTime
            // 
            this.txtCSHeaterPauseTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingPauseTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSHeaterPauseTime.Location = new System.Drawing.Point(148, 37);
            this.txtCSHeaterPauseTime.Name = "txtCSHeaterPauseTime";
            this.txtCSHeaterPauseTime.Size = new System.Drawing.Size(53, 20);
            this.txtCSHeaterPauseTime.TabIndex = 2;
            this.txtCSHeaterPauseTime.Text = global::WeatherStation.Properties.Settings.Default.HeatingPauseTime;
            this.txtCSHeaterPauseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSHeaterPauseTime, "Interval between two autoheating cycles, seconds\r\n");
            this.txtCSHeaterPauseTime.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtCSHeaterPauseTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCSDecreasingMaxDelta
            // 
            this.txtCSDecreasingMaxDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCS_MaxDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSDecreasingMaxDelta.Location = new System.Drawing.Point(215, 61);
            this.txtCSDecreasingMaxDelta.Name = "txtCSDecreasingMaxDelta";
            this.txtCSDecreasingMaxDelta.Size = new System.Drawing.Size(53, 20);
            this.txtCSDecreasingMaxDelta.TabIndex = 4;
            this.txtCSDecreasingMaxDelta.Text = global::WeatherStation.Properties.Settings.Default.HeatingCS_MaxDelta;
            this.txtCSDecreasingMaxDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSDecreasingMaxDelta, resources.GetString("txtCSDecreasingMaxDelta.ToolTip"));
            this.txtCSDecreasingMaxDelta.TextChanged += new System.EventHandler(this.txtCheckFloatPos_TextChanged);
            this.txtCSDecreasingMaxDelta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtCSHeatingMax
            // 
            this.txtCSHeatingMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCSThresholdMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSHeatingMax.Location = new System.Drawing.Point(215, 13);
            this.txtCSHeatingMax.Name = "txtCSHeatingMax";
            this.txtCSHeatingMax.Size = new System.Drawing.Size(53, 20);
            this.txtCSHeatingMax.TabIndex = 1;
            this.txtCSHeatingMax.Text = global::WeatherStation.Properties.Settings.Default.HeatingCSThresholdMax;
            this.txtCSHeatingMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSHeatingMax, "Maximum cloud sensor value, when auto heating could be switched on\r\n");
            this.txtCSHeatingMax.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtCSHeatingMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCSDecreasingMinDelta
            // 
            this.txtCSDecreasingMinDelta.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCS_MinDelta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSDecreasingMinDelta.Location = new System.Drawing.Point(148, 61);
            this.txtCSDecreasingMinDelta.Name = "txtCSDecreasingMinDelta";
            this.txtCSDecreasingMinDelta.Size = new System.Drawing.Size(53, 20);
            this.txtCSDecreasingMinDelta.TabIndex = 3;
            this.txtCSDecreasingMinDelta.Text = global::WeatherStation.Properties.Settings.Default.HeatingCS_MinDelta;
            this.txtCSDecreasingMinDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSDecreasingMinDelta, resources.GetString("txtCSDecreasingMinDelta.ToolTip"));
            this.txtCSDecreasingMinDelta.TextChanged += new System.EventHandler(this.txtCheckFloatPos_TextChanged);
            this.txtCSDecreasingMinDelta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckFloatPos_Validating);
            // 
            // txtCSHeatingMin
            // 
            this.txtCSHeatingMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingCSThresholdMin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCSHeatingMin.Location = new System.Drawing.Point(148, 13);
            this.txtCSHeatingMin.Name = "txtCSHeatingMin";
            this.txtCSHeatingMin.Size = new System.Drawing.Size(53, 20);
            this.txtCSHeatingMin.TabIndex = 0;
            this.txtCSHeatingMin.Text = global::WeatherStation.Properties.Settings.Default.HeatingCSThresholdMin;
            this.txtCSHeatingMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCSHeatingMin, "Minimum cloud sensor value, when auto heating could be switched on");
            this.txtCSHeatingMin.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtCSHeatingMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterWetThreshold
            // 
            this.txtHeaterWetThreshold.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterWetThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingWetThreshold", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHeaterWetThreshold.Location = new System.Drawing.Point(148, 65);
            this.txtHeaterWetThreshold.Name = "txtHeaterWetThreshold";
            this.txtHeaterWetThreshold.Size = new System.Drawing.Size(53, 20);
            this.txtHeaterWetThreshold.TabIndex = 2;
            this.txtHeaterWetThreshold.Text = global::WeatherStation.Properties.Settings.Default.HeatingWetThreshold;
            this.txtHeaterWetThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtHeaterWetThreshold, "Wet sensor value after reaching which heating started automaticaly. \r\nSet 0 to di" +
        "sable");
            this.txtHeaterWetThreshold.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtHeaterWetThreshold.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterMaxTemp
            // 
            this.txtHeaterMaxTemp.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterMaxTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingMaxTemp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHeaterMaxTemp.Location = new System.Drawing.Point(148, 16);
            this.txtHeaterMaxTemp.Name = "txtHeaterMaxTemp";
            this.txtHeaterMaxTemp.Size = new System.Drawing.Size(53, 20);
            this.txtHeaterMaxTemp.TabIndex = 0;
            this.txtHeaterMaxTemp.Text = global::WeatherStation.Properties.Settings.Default.HeatingMaxTemp;
            this.txtHeaterMaxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtHeaterMaxTemp, "Maximum temperature delta which can be reached during heating. Measured by MLX te" +
        "mperature sensor (ATemp) minus \"Base temp sensor\" value");
            this.txtHeaterMaxTemp.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtHeaterMaxTemp.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtHeaterMaxDuration
            // 
            this.txtHeaterMaxDuration.BackColor = System.Drawing.SystemColors.Info;
            this.txtHeaterMaxDuration.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "HeatingMaxDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtHeaterMaxDuration.Location = new System.Drawing.Point(148, 41);
            this.txtHeaterMaxDuration.Name = "txtHeaterMaxDuration";
            this.txtHeaterMaxDuration.Size = new System.Drawing.Size(53, 20);
            this.txtHeaterMaxDuration.TabIndex = 1;
            this.txtHeaterMaxDuration.Text = global::WeatherStation.Properties.Settings.Default.HeatingMaxDuration;
            this.txtHeaterMaxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtHeaterMaxDuration, "Maximum heating cycle duration, sec");
            this.txtHeaterMaxDuration.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtHeaterMaxDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtRefreshInterval
            // 
            this.txtRefreshInterval.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RefreshInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRefreshInterval.Location = new System.Drawing.Point(148, 16);
            this.txtRefreshInterval.Name = "txtRefreshInterval";
            this.txtRefreshInterval.Size = new System.Drawing.Size(53, 20);
            this.txtRefreshInterval.TabIndex = 0;
            this.txtRefreshInterval.Text = global::WeatherStation.Properties.Settings.Default.RefreshInterval;
            this.txtRefreshInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtRefreshInterval, resources.GetString("txtRefreshInterval.ToolTip"));
            this.txtRefreshInterval.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtRefreshInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtMaxPoints
            // 
            this.txtMaxPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "MaxPoints", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxPoints.Location = new System.Drawing.Point(148, 38);
            this.txtMaxPoints.Name = "txtMaxPoints";
            this.txtMaxPoints.Size = new System.Drawing.Size(53, 20);
            this.txtMaxPoints.TabIndex = 1;
            this.txtMaxPoints.Text = global::WeatherStation.Properties.Settings.Default.MaxPoints;
            this.txtMaxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtMaxPoints, "Max number of points displaying on charts. Too big values will leed to large memo" +
        "ry consumption");
            this.txtMaxPoints.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtMaxPoints.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtWetLimit
            // 
            this.txtWetLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "WetLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWetLimit.Location = new System.Drawing.Point(148, 16);
            this.txtWetLimit.Name = "txtWetLimit";
            this.txtWetLimit.Size = new System.Drawing.Size(53, 20);
            this.txtWetLimit.TabIndex = 0;
            this.txtWetLimit.Text = global::WeatherStation.Properties.Settings.Default.WetLimit;
            this.txtWetLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtWetLimit, "Wet threshold limit. All values higher then this will be treated as a dry conditi" +
        "on");
            this.txtWetLimit.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtWetLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtRainLimit
            // 
            this.txtRainLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "RainLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRainLimit.Location = new System.Drawing.Point(148, 38);
            this.txtRainLimit.Name = "txtRainLimit";
            this.txtRainLimit.Size = new System.Drawing.Size(53, 20);
            this.txtRainLimit.TabIndex = 1;
            this.txtRainLimit.Text = global::WeatherStation.Properties.Settings.Default.RainLimit;
            this.txtRainLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtRainLimit, "Rain threshold limit. All values higher then this will be treated as a wet condit" +
        "ion, and lower as a rain condition");
            this.txtRainLimit.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtRainLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtCloudysky
            // 
            this.txtCloudysky.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Cloudysky", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCloudysky.Location = new System.Drawing.Point(148, 39);
            this.txtCloudysky.Name = "txtCloudysky";
            this.txtCloudysky.Size = new System.Drawing.Size(53, 20);
            this.txtCloudysky.TabIndex = 1;
            this.txtCloudysky.Text = global::WeatherStation.Properties.Settings.Default.Cloudysky;
            this.txtCloudysky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtCloudysky, "Cloudy sky threshold limit. All values higher then this will be treated as a clou" +
        "dy sky and lower - as a very cloudy");
            this.txtCloudysky.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtCloudysky.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtClearsky
            // 
            this.txtClearsky.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "Clearsky", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtClearsky.Location = new System.Drawing.Point(148, 16);
            this.txtClearsky.Name = "txtClearsky";
            this.txtClearsky.Size = new System.Drawing.Size(53, 20);
            this.txtClearsky.TabIndex = 0;
            this.txtClearsky.Text = global::WeatherStation.Properties.Settings.Default.Clearsky;
            this.txtClearsky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtClearsky, "Clear sky threshold limit. All values higher then this will be treated as a clear" +
        " sky");
            this.txtClearsky.TextChanged += new System.EventHandler(this.txtCheckIntPos_TextChanged);
            this.txtClearsky.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckIntPos_Validating);
            // 
            // txtK1
            // 
            this.txtK1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK1.Location = new System.Drawing.Point(9, 90);
            this.txtK1.Name = "txtK1";
            this.txtK1.Size = new System.Drawing.Size(26, 20);
            this.txtK1.TabIndex = 2;
            this.txtK1.Text = global::WeatherStation.Properties.Settings.Default.K1;
            this.txtK1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK1, resources.GetString("txtK1.ToolTip"));
            this.txtK1.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK2
            // 
            this.txtK2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK2.Location = new System.Drawing.Point(41, 90);
            this.txtK2.Name = "txtK2";
            this.txtK2.Size = new System.Drawing.Size(24, 20);
            this.txtK2.TabIndex = 3;
            this.txtK2.Text = global::WeatherStation.Properties.Settings.Default.K2;
            this.txtK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK2, resources.GetString("txtK2.ToolTip"));
            this.txtK2.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK2.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK7
            // 
            this.txtK7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK7.Location = new System.Drawing.Point(191, 90);
            this.txtK7.Name = "txtK7";
            this.txtK7.Size = new System.Drawing.Size(24, 20);
            this.txtK7.TabIndex = 8;
            this.txtK7.Text = global::WeatherStation.Properties.Settings.Default.K7;
            this.txtK7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK7, resources.GetString("txtK7.ToolTip"));
            this.txtK7.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK7.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK3
            // 
            this.txtK3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK3.Location = new System.Drawing.Point(71, 90);
            this.txtK3.Name = "txtK3";
            this.txtK3.Size = new System.Drawing.Size(24, 20);
            this.txtK3.TabIndex = 4;
            this.txtK3.Text = global::WeatherStation.Properties.Settings.Default.K3;
            this.txtK3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK3, resources.GetString("txtK3.ToolTip"));
            this.txtK3.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK3.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK6
            // 
            this.txtK6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK6.Location = new System.Drawing.Point(161, 90);
            this.txtK6.Name = "txtK6";
            this.txtK6.Size = new System.Drawing.Size(24, 20);
            this.txtK6.TabIndex = 7;
            this.txtK6.Text = global::WeatherStation.Properties.Settings.Default.K6;
            this.txtK6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK6, resources.GetString("txtK6.ToolTip"));
            this.txtK6.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK6.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK4
            // 
            this.txtK4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK4.Location = new System.Drawing.Point(101, 90);
            this.txtK4.Name = "txtK4";
            this.txtK4.Size = new System.Drawing.Size(24, 20);
            this.txtK4.TabIndex = 5;
            this.txtK4.Text = global::WeatherStation.Properties.Settings.Default.K4;
            this.txtK4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK4, resources.GetString("txtK4.ToolTip"));
            this.txtK4.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK4.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // txtK5
            // 
            this.txtK5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WeatherStation.Properties.Settings.Default, "K5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtK5.Location = new System.Drawing.Point(131, 90);
            this.txtK5.Name = "txtK5";
            this.txtK5.Size = new System.Drawing.Size(24, 20);
            this.txtK5.TabIndex = 6;
            this.txtK5.Text = global::WeatherStation.Properties.Settings.Default.K5;
            this.txtK5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyToolTip.SetToolTip(this.txtK5, resources.GetString("txtK5.ToolTip"));
            this.txtK5.TextChanged += new System.EventHandler(this.txtCheckInt_TextChanged);
            this.txtK5.Validating += new System.ComponentModel.CancelEventHandler(this.txtCheckInt_Validating);
            // 
            // chkWatchdog
            // 
            this.chkWatchdog.AutoSize = true;
            this.chkWatchdog.Checked = global::WeatherStation.Properties.Settings.Default.ComWatchdog;
            this.chkWatchdog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWatchdog.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WeatherStation.Properties.Settings.Default, "ComWatchdog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkWatchdog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkWatchdog.Location = new System.Drawing.Point(7, 46);
            this.chkWatchdog.Name = "chkWatchdog";
            this.chkWatchdog.Size = new System.Drawing.Size(130, 17);
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
            this.chkResetArduino.Location = new System.Drawing.Point(103, 21);
            this.chkResetArduino.Name = "chkResetArduino";
            this.chkResetArduino.Size = new System.Drawing.Size(194, 17);
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
            this.cmbPortList.Location = new System.Drawing.Point(7, 19);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(91, 21);
            this.cmbPortList.TabIndex = 0;
            this.cmbPortList.Text = global::WeatherStation.Properties.Settings.Default.comport;
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(634, 726);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 734);
            this.Name = "PreferencesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSensors)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkResetArduino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoltwoodFileLocation;
        private System.Windows.Forms.TextBox txtLogFileLocation;
        private System.Windows.Forms.TextBox txtCSVFileLocation;
        private System.Windows.Forms.CheckBox chkBoltwoodFileFlag;
        private System.Windows.Forms.CheckBox chkCSVFileFlag;
        private System.Windows.Forms.CheckBox chkLogFileFlag;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCloudysky;
        private System.Windows.Forms.TextBox txtClearsky;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtK6;
        private System.Windows.Forms.TextBox txtK5;
        private System.Windows.Forms.TextBox txtK4;
        private System.Windows.Forms.TextBox txtK3;
        private System.Windows.Forms.TextBox txtK2;
        private System.Windows.Forms.TextBox txtK1;
        private System.Windows.Forms.Label K7;
        private System.Windows.Forms.TextBox txtK7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWetLimit;
        private System.Windows.Forms.TextBox txtRainLimit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRefreshInterval;
        private System.Windows.Forms.TextBox txtMaxPoints;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtWebDataURL;
        private System.Windows.Forms.CheckBox chkWebData;
        private System.Windows.Forms.Button btnLogPathBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnBoltwoodPathBrowse;
        private System.Windows.Forms.Button btnCSVPathBrowse;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.CheckBox chkWatchdog;
        private System.Windows.Forms.CheckBox chkNarodMon;
        private System.Windows.Forms.TextBox txtNarodmonMAC;
        private System.Windows.Forms.Button btnGenerateMac;
        private System.Windows.Forms.DataGridView dataGridSensors;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBaseTempSensor;
        private System.Windows.Forms.Button btnResetSensorList;
        private System.Windows.Forms.Button btnReadFromSerial;
        private System.Windows.Forms.Button btnSerialLogPathBrowse;
        private System.Windows.Forms.TextBox txtSerialLogFileLocation;
        private System.Windows.Forms.CheckBox chkSerialLogFileFlag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SensorEnabled;
        private System.Windows.Forms.DataGridViewComboBoxColumn SensorType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendToWeb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SendToNarodmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArduinoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebCustomName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FormFieldName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHeaterWetThreshold;
        private System.Windows.Forms.TextBox txtHeaterMaxTemp;
        private System.Windows.Forms.TextBox txtHeaterMaxDuration;
        private System.Windows.Forms.ComboBox cmbWetMode;
        private System.Windows.Forms.Label label19;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}