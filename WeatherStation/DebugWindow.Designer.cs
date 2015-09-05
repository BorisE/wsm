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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtAutoCallibrationLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Calibrate";
            // 
            // chkHitCount_Greater
            // 
            this.chkHitCount_Greater.AutoSize = true;
            this.chkHitCount_Greater.Location = new System.Drawing.Point(487, 146);
            this.chkHitCount_Greater.Name = "chkHitCount_Greater";
            this.chkHitCount_Greater.Size = new System.Drawing.Size(87, 21);
            this.chkHitCount_Greater.TabIndex = 2;
            this.chkHitCount_Greater.Text = "Greater?";
            this.chkHitCount_Greater.UseVisualStyleBackColor = true;
            // 
            // chkMaxPassedFromHitGreaterFlag
            // 
            this.chkMaxPassedFromHitGreaterFlag.AutoSize = true;
            this.chkMaxPassedFromHitGreaterFlag.Location = new System.Drawing.Point(487, 118);
            this.chkMaxPassedFromHitGreaterFlag.Name = "chkMaxPassedFromHitGreaterFlag";
            this.chkMaxPassedFromHitGreaterFlag.Size = new System.Drawing.Size(87, 21);
            this.chkMaxPassedFromHitGreaterFlag.TabIndex = 2;
            this.chkMaxPassedFromHitGreaterFlag.Text = "Greater?";
            this.chkMaxPassedFromHitGreaterFlag.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "txtWS_HitCount_Threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "autoCalWS_maxPassedFromHit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Passed from last min hit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passed from min set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current Val";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current zero speed calibration value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "MinVal HitCount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MinVal";
            // 
            // txtWS_HitCount_Threshold
            // 
            this.txtWS_HitCount_Threshold.Location = new System.Drawing.Point(381, 144);
            this.txtWS_HitCount_Threshold.Name = "txtWS_HitCount_Threshold";
            this.txtWS_HitCount_Threshold.ReadOnly = true;
            this.txtWS_HitCount_Threshold.Size = new System.Drawing.Size(100, 22);
            this.txtWS_HitCount_Threshold.TabIndex = 0;
            // 
            // txtautoCalWS_maxPassedFromHit
            // 
            this.txtautoCalWS_maxPassedFromHit.Location = new System.Drawing.Point(381, 116);
            this.txtautoCalWS_maxPassedFromHit.Name = "txtautoCalWS_maxPassedFromHit";
            this.txtautoCalWS_maxPassedFromHit.ReadOnly = true;
            this.txtautoCalWS_maxPassedFromHit.Size = new System.Drawing.Size(100, 22);
            this.txtautoCalWS_maxPassedFromHit.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtautoCalWS_maxPassedFromHit, "Maimum time in sec allowed to not hit min value. \r\n\r\nI.e. if min value wouldn\'t b" +
        "e hit for some time, then it will be erased ");
            // 
            // txtPassedFromMinHit
            // 
            this.txtPassedFromMinHit.Location = new System.Drawing.Point(410, 83);
            this.txtPassedFromMinHit.Name = "txtPassedFromMinHit";
            this.txtPassedFromMinHit.Size = new System.Drawing.Size(100, 22);
            this.txtPassedFromMinHit.TabIndex = 0;
            // 
            // txtPassedFromMinSet
            // 
            this.txtPassedFromMinSet.Location = new System.Drawing.Point(410, 53);
            this.txtPassedFromMinSet.Name = "txtPassedFromMinSet";
            this.txtPassedFromMinSet.Size = new System.Drawing.Size(100, 22);
            this.txtPassedFromMinSet.TabIndex = 0;
            // 
            // txtcurVal
            // 
            this.txtcurVal.Location = new System.Drawing.Point(116, 27);
            this.txtcurVal.Name = "txtcurVal";
            this.txtcurVal.Size = new System.Drawing.Size(100, 22);
            this.txtcurVal.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtcurVal, "Curent value");
            // 
            // txtWS_Calibraion_ZeroSpeedAnalogValue
            // 
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Location = new System.Drawing.Point(43, 199);
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Name = "txtWS_Calibraion_ZeroSpeedAnalogValue";
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.Size = new System.Drawing.Size(149, 22);
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtWS_Calibraion_ZeroSpeedAnalogValue, "Current zero speed calibration value");
            this.txtWS_Calibraion_ZeroSpeedAnalogValue.TextChanged += new System.EventHandler(this.txtWS_Calibraion_ZeroSpeedAnalogValue_TextChanged);
            // 
            // txtWS_MinValue_HitCount
            // 
            this.txtWS_MinValue_HitCount.Location = new System.Drawing.Point(116, 83);
            this.txtWS_MinValue_HitCount.Name = "txtWS_MinValue_HitCount";
            this.txtWS_MinValue_HitCount.Size = new System.Drawing.Size(100, 22);
            this.txtWS_MinValue_HitCount.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtWS_MinValue_HitCount, "How many times min value was hit");
            this.txtWS_MinValue_HitCount.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            // 
            // txtLastMinVal
            // 
            this.txtLastMinVal.Location = new System.Drawing.Point(116, 55);
            this.txtLastMinVal.Name = "txtLastMinVal";
            this.txtLastMinVal.Size = new System.Drawing.Size(100, 22);
            this.txtLastMinVal.TabIndex = 0;
            this.txtLastMinVal.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            // 
            // txtAutoCallibrationLog
            // 
            this.txtAutoCallibrationLog.Location = new System.Drawing.Point(293, 177);
            this.txtAutoCallibrationLog.Multiline = true;
            this.txtAutoCallibrationLog.Name = "txtAutoCallibrationLog";
            this.txtAutoCallibrationLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAutoCallibrationLog.Size = new System.Drawing.Size(270, 76);
            this.txtAutoCallibrationLog.TabIndex = 3;
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "DebugWindow";
            this.Text = "Debug Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugWindow_FormClosing);
            this.Load += new System.EventHandler(this.DebugWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}