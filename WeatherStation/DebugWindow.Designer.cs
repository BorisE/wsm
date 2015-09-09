namespace WeatherStation
{
    partial class DebugWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAutoCallibrationLog = new System.Windows.Forms.TextBox();
            this.chkHitCount_Greater = new System.Windows.Forms.CheckBox();
            this.chkMaxPassedFromHitGreaterFlag = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWS_HitCount_Threshold = new System.Windows.Forms.TextBox();
            this.txtautoCalWS_maxPassedFromHit = new System.Windows.Forms.TextBox();
            this.txtPassedFromMinHit = new System.Windows.Forms.TextBox();
            this.txtPassedFromMinSet = new System.Windows.Forms.TextBox();
            this.txtcurVal = new System.Windows.Forms.TextBox();
            this.txtWS_Calibraion_ZeroSpeedAnalogValue = new System.Windows.Forms.TextBox();
            this.txtWS_MinValue_HitCount = new System.Windows.Forms.TextBox();
            this.txtLastMinVal = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkCSNeedsHeating_RelayOffNow = new System.Windows.Forms.CheckBox();
            this.chkCSNeedsHeating_HumidityMet = new System.Windows.Forms.CheckBox();
            this.chkCSNeedsHeating_NotRainingMet = new System.Windows.Forms.CheckBox();
            this.chkCSNeedsHeating_DarknessMet = new System.Windows.Forms.CheckBox();
            this.chkCSNeedsHeating_CSIntervalMet = new System.Windows.Forms.CheckBox();
            this.chkCSNeedsHeating_CSDecreasingTempMet = new System.Windows.Forms.CheckBox();
            this.txtRGC_log = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAutoheatingLog = new System.Windows.Forms.TextBox();
            this.chkWetSesorIsWet = new System.Windows.Forms.CheckBox();
            this.chkCSNeedsHeating_SinceLastHeatingMet = new System.Windows.Forms.CheckBox();
            this.chkCloudSensorNeedHeatingFlag = new System.Windows.Forms.CheckBox();
            this.txt20min = new System.Windows.Forms.TextBox();
            this.txt15min = new System.Windows.Forms.TextBox();
            this.txt10min = new System.Windows.Forms.TextBox();
            this.txt5min = new System.Windows.Forms.TextBox();
            this.txt0min = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtAutoCallibrationLog);
            this.groupBox1.Controls.Add(this.chkHitCount_Greater);
            this.groupBox1.Controls.Add(this.chkMaxPassedFromHitGreaterFlag);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWS_HitCount_Threshold);
            this.groupBox1.Controls.Add(this.txtautoCalWS_maxPassedFromHit);
            this.groupBox1.Controls.Add(this.txtPassedFromMinHit);
            this.groupBox1.Controls.Add(this.txtPassedFromMinSet);
            this.groupBox1.Controls.Add(this.txtcurVal);
            this.groupBox1.Controls.Add(this.txtWS_Calibraion_ZeroSpeedAnalogValue);
            this.groupBox1.Controls.Add(this.txtWS_MinValue_HitCount);
            this.groupBox1.Controls.Add(this.txtLastMinVal);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(435, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Calibrate";
            // 
            // txtAutoCallibrationLog
            // 
            this.txtAutoCallibrationLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutoCallibrationLog.Location = new System.Drawing.Point(220, 144);
            this.txtAutoCallibrationLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutoCallibrationLog.Multiline = true;
            this.txtAutoCallibrationLog.Name = "txtAutoCallibrationLog";
            this.txtAutoCallibrationLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAutoCallibrationLog.Size = new System.Drawing.Size(204, 62);
            this.txtAutoCallibrationLog.TabIndex = 3;
            // 
            // chkHitCount_Greater
            // 
            this.chkHitCount_Greater.AutoSize = true;
            this.chkHitCount_Greater.Location = new System.Drawing.Point(365, 119);
            this.chkHitCount_Greater.Margin = new System.Windows.Forms.Padding(2);
            this.chkHitCount_Greater.Name = "chkHitCount_Greater";
            this.chkHitCount_Greater.Size = new System.Drawing.Size(67, 17);
            this.chkHitCount_Greater.TabIndex = 2;
            this.chkHitCount_Greater.Text = "Greater?";
            this.chkHitCount_Greater.UseVisualStyleBackColor = true;
            // 
            // chkMaxPassedFromHitGreaterFlag
            // 
            this.chkMaxPassedFromHitGreaterFlag.AutoSize = true;
            this.chkMaxPassedFromHitGreaterFlag.Location = new System.Drawing.Point(365, 96);
            this.chkMaxPassedFromHitGreaterFlag.Margin = new System.Windows.Forms.Padding(2);
            this.chkMaxPassedFromHitGreaterFlag.Name = "chkMaxPassedFromHitGreaterFlag";
            this.chkMaxPassedFromHitGreaterFlag.Size = new System.Drawing.Size(67, 17);
            this.chkMaxPassedFromHitGreaterFlag.TabIndex = 2;
            this.chkMaxPassedFromHitGreaterFlag.Text = "Greater?";
            this.chkMaxPassedFromHitGreaterFlag.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "txtWS_HitCount_Threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "autoCalWS_maxPassedFromHit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Passed from last min hit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passed from min set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current Val";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current zero speed calibration value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "MinVal HitCount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MinVal";
            // 
            // txtWS_HitCount_Threshold
            // 
            this.txtWS_HitCount_Threshold.Location = new System.Drawing.Point(286, 117);
            this.txtWS_HitCount_Threshold.Margin = new System.Windows.Forms.Padding(2);
            this.txtWS_HitCount_Threshold.Name = "txtWS_HitCount_Threshold";
            this.txtWS_HitCount_Threshold.ReadOnly = true;
            this.txtWS_HitCount_Threshold.Size = new System.Drawing.Size(76, 20);
            this.txtWS_HitCount_Threshold.TabIndex = 0;
            // 
            // txtautoCalWS_maxPassedFromHit
            // 
            this.txtautoCalWS_maxPassedFromHit.Location = new System.Drawing.Point(286, 94);
            this.txtautoCalWS_maxPassedFromHit.Margin = new System.Windows.Forms.Padding(2);
            this.txtautoCalWS_maxPassedFromHit.Name = "txtautoCalWS_maxPassedFromHit";
            this.txtautoCalWS_maxPassedFromHit.ReadOnly = true;
            this.txtautoCalWS_maxPassedFromHit.Size = new System.Drawing.Size(76, 20);
            this.txtautoCalWS_maxPassedFromHit.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtautoCalWS_maxPassedFromHit, "Maimum time in sec allowed to not hit min value. \r\n\r\nI.e. if min value wouldn\'t b" +
        "e hit for some time, then it will be erased ");
            // 
            // txtPassedFromMinHit
            // 
            this.txtPassedFromMinHit.Location = new System.Drawing.Point(308, 67);
            this.txtPassedFromMinHit.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassedFromMinHit.Name = "txtPassedFromMinHit";
            this.txtPassedFromMinHit.Size = new System.Drawing.Size(76, 20);
            this.txtPassedFromMinHit.TabIndex = 0;
            // 
            // txtPassedFromMinSet
            // 
            this.txtPassedFromMinSet.Location = new System.Drawing.Point(308, 43);
            this.txtPassedFromMinSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassedFromMinSet.Name = "txtPassedFromMinSet";
            this.txtPassedFromMinSet.Size = new System.Drawing.Size(76, 20);
            this.txtPassedFromMinSet.TabIndex = 0;
            // 
            // txtcurVal
            // 
            this.txtcurVal.Location = new System.Drawing.Point(87, 22);
            this.txtcurVal.Margin = new System.Windows.Forms.Padding(2);
            this.txtcurVal.Name = "txtcurVal";
            this.txtcurVal.Size = new System.Drawing.Size(76, 20);
            this.txtcurVal.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtcurVal, "Curent value");
            // 
            // txtWS_Calibraion_ZeroSpeedAnalogValue
            // 
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Location = new System.Drawing.Point(32, 162);
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Name = "txtWS_Calibraion_ZeroSpeedAnalogValue";
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Size = new System.Drawing.Size(113, 20);
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtWS_Calibraion_ZeroSpeedAnalogValue, "Current zero speed calibration value");
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.TextChanged += new System.EventHandler(this.txtWS_Calibraion_ZeroSpeedAnalogValue_TextChanged);
            // 
            // txtWS_MinValue_HitCount
            // 
            this.txtWS_MinValue_HitCount.Location = new System.Drawing.Point(87, 67);
            this.txtWS_MinValue_HitCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtWS_MinValue_HitCount.Name = "txtWS_MinValue_HitCount";
            this.txtWS_MinValue_HitCount.Size = new System.Drawing.Size(76, 20);
            this.txtWS_MinValue_HitCount.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtWS_MinValue_HitCount, "How many times min value was hit");
            this.txtWS_MinValue_HitCount.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            // 
            // txtLastMinVal
            // 
            this.txtLastMinVal.Location = new System.Drawing.Point(87, 45);
            this.txtLastMinVal.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastMinVal.Name = "txtLastMinVal";
            this.txtLastMinVal.Size = new System.Drawing.Size(76, 20);
            this.txtLastMinVal.TabIndex = 0;
            this.txtLastMinVal.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            // 
            // chkCSNeedsHeating_RelayOffNow
            // 
            this.chkCSNeedsHeating_RelayOffNow.AutoSize = true;
            this.chkCSNeedsHeating_RelayOffNow.Location = new System.Drawing.Point(5, 102);
            this.chkCSNeedsHeating_RelayOffNow.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_RelayOffNow.Name = "chkCSNeedsHeating_RelayOffNow";
            this.chkCSNeedsHeating_RelayOffNow.Size = new System.Drawing.Size(177, 17);
            this.chkCSNeedsHeating_RelayOffNow.TabIndex = 2;
            this.chkCSNeedsHeating_RelayOffNow.Text = "CSNeedsHeating_RelayOffNow";
            this.toolTip1.SetToolTip(this.chkCSNeedsHeating_RelayOffNow, "Relay off now? (heating not engaged already)");
            this.chkCSNeedsHeating_RelayOffNow.UseVisualStyleBackColor = true;
            // 
            // chkCSNeedsHeating_HumidityMet
            // 
            this.chkCSNeedsHeating_HumidityMet.AutoSize = true;
            this.chkCSNeedsHeating_HumidityMet.Location = new System.Drawing.Point(5, 123);
            this.chkCSNeedsHeating_HumidityMet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_HumidityMet.Name = "chkCSNeedsHeating_HumidityMet";
            this.chkCSNeedsHeating_HumidityMet.Size = new System.Drawing.Size(172, 17);
            this.chkCSNeedsHeating_HumidityMet.TabIndex = 2;
            this.chkCSNeedsHeating_HumidityMet.Text = "CSNeedsHeating_HumidityMet";
            this.toolTip1.SetToolTip(this.chkCSNeedsHeating_HumidityMet, "Check - humidity is high?");
            this.chkCSNeedsHeating_HumidityMet.UseVisualStyleBackColor = true;
            // 
            // chkCSNeedsHeating_NotRainingMet
            // 
            this.chkCSNeedsHeating_NotRainingMet.AutoSize = true;
            this.chkCSNeedsHeating_NotRainingMet.Location = new System.Drawing.Point(5, 144);
            this.chkCSNeedsHeating_NotRainingMet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_NotRainingMet.Name = "chkCSNeedsHeating_NotRainingMet";
            this.chkCSNeedsHeating_NotRainingMet.Size = new System.Drawing.Size(185, 17);
            this.chkCSNeedsHeating_NotRainingMet.TabIndex = 2;
            this.chkCSNeedsHeating_NotRainingMet.Text = "CSNeedsHeating_NotRainingMet";
            this.toolTip1.SetToolTip(this.chkCSNeedsHeating_NotRainingMet, "Check - is it raining now? Only if no engage");
            this.chkCSNeedsHeating_NotRainingMet.UseVisualStyleBackColor = true;
            // 
            // chkCSNeedsHeating_DarknessMet
            // 
            this.chkCSNeedsHeating_DarknessMet.AutoSize = true;
            this.chkCSNeedsHeating_DarknessMet.Location = new System.Drawing.Point(5, 165);
            this.chkCSNeedsHeating_DarknessMet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_DarknessMet.Name = "chkCSNeedsHeating_DarknessMet";
            this.chkCSNeedsHeating_DarknessMet.Size = new System.Drawing.Size(177, 17);
            this.chkCSNeedsHeating_DarknessMet.TabIndex = 2;
            this.chkCSNeedsHeating_DarknessMet.Text = "CSNeedsHeating_DarknessMet";
            this.toolTip1.SetToolTip(this.chkCSNeedsHeating_DarknessMet, "Check - is it dark?");
            this.chkCSNeedsHeating_DarknessMet.UseVisualStyleBackColor = true;
            // 
            // chkCSNeedsHeating_CSIntervalMet
            // 
            this.chkCSNeedsHeating_CSIntervalMet.AutoSize = true;
            this.chkCSNeedsHeating_CSIntervalMet.Location = new System.Drawing.Point(21, 39);
            this.chkCSNeedsHeating_CSIntervalMet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_CSIntervalMet.Name = "chkCSNeedsHeating_CSIntervalMet";
            this.chkCSNeedsHeating_CSIntervalMet.Size = new System.Drawing.Size(181, 17);
            this.chkCSNeedsHeating_CSIntervalMet.TabIndex = 2;
            this.chkCSNeedsHeating_CSIntervalMet.Text = "CSNeedsHeating_CSIntervalMet";
            this.toolTip1.SetToolTip(this.chkCSNeedsHeating_CSIntervalMet, "Check - if cloud sensor values are in given interval?");
            this.chkCSNeedsHeating_CSIntervalMet.UseVisualStyleBackColor = true;
            // 
            // chkCSNeedsHeating_CSDecreasingTempMet
            // 
            this.chkCSNeedsHeating_CSDecreasingTempMet.AutoSize = true;
            this.chkCSNeedsHeating_CSDecreasingTempMet.Location = new System.Drawing.Point(21, 60);
            this.chkCSNeedsHeating_CSDecreasingTempMet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_CSDecreasingTempMet.Name = "chkCSNeedsHeating_CSDecreasingTempMet";
            this.chkCSNeedsHeating_CSDecreasingTempMet.Size = new System.Drawing.Size(227, 17);
            this.chkCSNeedsHeating_CSDecreasingTempMet.TabIndex = 2;
            this.chkCSNeedsHeating_CSDecreasingTempMet.Text = "CSNeedsHeating_CSDecreasingTempMet";
            this.toolTip1.SetToolTip(this.chkCSNeedsHeating_CSDecreasingTempMet, "Ckeck - if CS temp monotonous decreasing");
            this.chkCSNeedsHeating_CSDecreasingTempMet.UseVisualStyleBackColor = true;
            // 
            // txtRGC_log
            // 
            this.txtRGC_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRGC_log.Location = new System.Drawing.Point(9, 513);
            this.txtRGC_log.Margin = new System.Windows.Forms.Padding(2);
            this.txtRGC_log.Multiline = true;
            this.txtRGC_log.Name = "txtRGC_log";
            this.txtRGC_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRGC_log.Size = new System.Drawing.Size(435, 55);
            this.txtRGC_log.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt20min);
            this.groupBox2.Controls.Add(this.txt15min);
            this.groupBox2.Controls.Add(this.txt10min);
            this.groupBox2.Controls.Add(this.txt5min);
            this.groupBox2.Controls.Add(this.txt0min);
            this.groupBox2.Controls.Add(this.txtAutoheatingLog);
            this.groupBox2.Controls.Add(this.chkWetSesorIsWet);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_DarknessMet);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_NotRainingMet);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_HumidityMet);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_RelayOffNow);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_SinceLastHeatingMet);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_CSDecreasingTempMet);
            this.groupBox2.Controls.Add(this.chkCSNeedsHeating_CSIntervalMet);
            this.groupBox2.Controls.Add(this.chkCloudSensorNeedHeatingFlag);
            this.groupBox2.Location = new System.Drawing.Point(9, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autoheating";
            // 
            // txtAutoheatingLog
            // 
            this.txtAutoheatingLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutoheatingLog.Location = new System.Drawing.Point(220, 18);
            this.txtAutoheatingLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutoheatingLog.Multiline = true;
            this.txtAutoheatingLog.Name = "txtAutoheatingLog";
            this.txtAutoheatingLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAutoheatingLog.Size = new System.Drawing.Size(204, 203);
            this.txtAutoheatingLog.TabIndex = 3;
            // 
            // chkWetSesorIsWet
            // 
            this.chkWetSesorIsWet.AutoSize = true;
            this.chkWetSesorIsWet.Location = new System.Drawing.Point(5, 204);
            this.chkWetSesorIsWet.Margin = new System.Windows.Forms.Padding(2);
            this.chkWetSesorIsWet.Name = "chkWetSesorIsWet";
            this.chkWetSesorIsWet.Size = new System.Drawing.Size(101, 17);
            this.chkWetSesorIsWet.TabIndex = 2;
            this.chkWetSesorIsWet.Text = "WetSesorIsWet";
            this.chkWetSesorIsWet.UseVisualStyleBackColor = true;
            // 
            // chkCSNeedsHeating_SinceLastHeatingMet
            // 
            this.chkCSNeedsHeating_SinceLastHeatingMet.AutoSize = true;
            this.chkCSNeedsHeating_SinceLastHeatingMet.Location = new System.Drawing.Point(5, 81);
            this.chkCSNeedsHeating_SinceLastHeatingMet.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSNeedsHeating_SinceLastHeatingMet.Name = "chkCSNeedsHeating_SinceLastHeatingMet";
            this.chkCSNeedsHeating_SinceLastHeatingMet.Size = new System.Drawing.Size(216, 17);
            this.chkCSNeedsHeating_SinceLastHeatingMet.TabIndex = 2;
            this.chkCSNeedsHeating_SinceLastHeatingMet.Text = "CSNeedsHeating_SinceLastHeatingMet";
            this.chkCSNeedsHeating_SinceLastHeatingMet.UseVisualStyleBackColor = true;
            // 
            // chkCloudSensorNeedHeatingFlag
            // 
            this.chkCloudSensorNeedHeatingFlag.AutoSize = true;
            this.chkCloudSensorNeedHeatingFlag.Location = new System.Drawing.Point(5, 18);
            this.chkCloudSensorNeedHeatingFlag.Margin = new System.Windows.Forms.Padding(2);
            this.chkCloudSensorNeedHeatingFlag.Name = "chkCloudSensorNeedHeatingFlag";
            this.chkCloudSensorNeedHeatingFlag.Size = new System.Drawing.Size(169, 17);
            this.chkCloudSensorNeedHeatingFlag.TabIndex = 2;
            this.chkCloudSensorNeedHeatingFlag.Text = "CloudSensorNeedHeatingFlag";
            this.chkCloudSensorNeedHeatingFlag.UseVisualStyleBackColor = true;
            // 
            // txt20min
            // 
            this.txt20min.Location = new System.Drawing.Point(192, 235);
            this.txt20min.Margin = new System.Windows.Forms.Padding(2);
            this.txt20min.Name = "txt20min";
            this.txt20min.ReadOnly = true;
            this.txt20min.Size = new System.Drawing.Size(43, 20);
            this.txt20min.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txt20min, resources.GetString("txt20min.ToolTip"));
            // 
            // txt15min
            // 
            this.txt15min.Location = new System.Drawing.Point(146, 235);
            this.txt15min.Margin = new System.Windows.Forms.Padding(2);
            this.txt15min.Name = "txt15min";
            this.txt15min.ReadOnly = true;
            this.txt15min.Size = new System.Drawing.Size(43, 20);
            this.txt15min.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txt15min, resources.GetString("txt15min.ToolTip"));
            // 
            // txt10min
            // 
            this.txt10min.Location = new System.Drawing.Point(99, 235);
            this.txt10min.Margin = new System.Windows.Forms.Padding(2);
            this.txt10min.Name = "txt10min";
            this.txt10min.ReadOnly = true;
            this.txt10min.Size = new System.Drawing.Size(43, 20);
            this.txt10min.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txt10min, resources.GetString("txt10min.ToolTip"));
            // 
            // txt5min
            // 
            this.txt5min.Location = new System.Drawing.Point(53, 235);
            this.txt5min.Margin = new System.Windows.Forms.Padding(2);
            this.txt5min.Name = "txt5min";
            this.txt5min.ReadOnly = true;
            this.txt5min.Size = new System.Drawing.Size(43, 20);
            this.txt5min.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txt5min, resources.GetString("txt5min.ToolTip"));
            // 
            // txt0min
            // 
            this.txt0min.Location = new System.Drawing.Point(6, 235);
            this.txt0min.Margin = new System.Windows.Forms.Padding(2);
            this.txt0min.Name = "txt0min";
            this.txt0min.ReadOnly = true;
            this.txt0min.Size = new System.Drawing.Size(43, 20);
            this.txt0min.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txt0min, resources.GetString("txt0min.ToolTip"));
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtRGC_log);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DebugWindow";
            this.Text = "Debug Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugWindow_FormClosing);
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastMinVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassedFromMinSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcurVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassedFromMinHit;
        private System.Windows.Forms.TextBox txtWS_MinValue_HitCount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkMaxPassedFromHitGreaterFlag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtautoCalWS_maxPassedFromHit;
        private System.Windows.Forms.CheckBox chkHitCount_Greater;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWS_HitCount_Threshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWS_Calibraion_ZeroSpeedAnalogValue;
        private System.Windows.Forms.TextBox txtAutoCallibrationLog;
        public System.Windows.Forms.TextBox txtRGC_log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAutoheatingLog;
        private System.Windows.Forms.CheckBox chkCloudSensorNeedHeatingFlag;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_SinceLastHeatingMet;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_HumidityMet;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_RelayOffNow;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_NotRainingMet;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_DarknessMet;
        private System.Windows.Forms.CheckBox chkWetSesorIsWet;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_CSIntervalMet;
        private System.Windows.Forms.CheckBox chkCSNeedsHeating_CSDecreasingTempMet;
        private System.Windows.Forms.TextBox txt20min;
        private System.Windows.Forms.TextBox txt15min;
        private System.Windows.Forms.TextBox txt10min;
        private System.Windows.Forms.TextBox txt5min;
        private System.Windows.Forms.TextBox txt0min;
    }
}