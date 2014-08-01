namespace WeatherStation
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine3 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine4 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBTemp = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHum1 = new System.Windows.Forms.TextBox();
            this.txtDTemp1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtHum2 = new System.Windows.Forms.TextBox();
            this.txtDTemp2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLumWTime = new System.Windows.Forms.TextBox();
            this.txtLumSen = new System.Windows.Forms.TextBox();
            this.txtIllum = new System.Windows.Forms.TextBox();
            this.txtLumRes = new System.Windows.Forms.TextBox();
            this.txtIllumRes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.txtATemp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnLogWindow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRGC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.timer_debug_changetext = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCloudIndex2 = new System.Windows.Forms.TextBox();
            this.txtCloudIndex1 = new System.Windows.Forms.TextBox();
            this.txtRainCond = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtWetflag = new System.Windows.Forms.TextBox();
            this.txtRainflag = new System.Windows.Forms.TextBox();
            this.txtDayCond = new System.Windows.Forms.TextBox();
            this.txtCloudCond = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnRelay = new System.Windows.Forms.Button();
            this.timer_debug_portread = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // main_timer
            // 
            this.main_timer.Interval = 10000;
            this.main_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Press:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BTemp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBTemp);
            this.groupBox2.Controls.Add(this.txtPress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(2, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 73);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PressureSensor";
            // 
            // txtBTemp
            // 
            this.txtBTemp.Location = new System.Drawing.Point(60, 19);
            this.txtBTemp.Name = "txtBTemp";
            this.txtBTemp.Size = new System.Drawing.Size(63, 20);
            this.txtBTemp.TabIndex = 2;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(60, 45);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(63, 20);
            this.txtPress.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHum1);
            this.groupBox3.Controls.Add(this.txtDTemp1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(2, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HumiditySensor";
            // 
            // txtHum1
            // 
            this.txtHum1.Location = new System.Drawing.Point(60, 19);
            this.txtHum1.Name = "txtHum1";
            this.txtHum1.Size = new System.Drawing.Size(63, 20);
            this.txtHum1.TabIndex = 2;
            // 
            // txtDTemp1
            // 
            this.txtDTemp1.Location = new System.Drawing.Point(60, 45);
            this.txtDTemp1.Name = "txtDTemp1";
            this.txtDTemp1.Size = new System.Drawing.Size(63, 20);
            this.txtDTemp1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "DTemp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hum:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtHum2);
            this.groupBox4.Controls.Add(this.txtDTemp2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(2, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HumiditySensor2";
            // 
            // txtHum2
            // 
            this.txtHum2.Location = new System.Drawing.Point(60, 19);
            this.txtHum2.Name = "txtHum2";
            this.txtHum2.Size = new System.Drawing.Size(63, 20);
            this.txtHum2.TabIndex = 2;
            // 
            // txtDTemp2
            // 
            this.txtDTemp2.Location = new System.Drawing.Point(60, 45);
            this.txtDTemp2.Name = "txtDTemp2";
            this.txtDTemp2.Size = new System.Drawing.Size(63, 20);
            this.txtDTemp2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DTemp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hum:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLumWTime);
            this.groupBox5.Controls.Add(this.txtLumSen);
            this.groupBox5.Controls.Add(this.txtIllum);
            this.groupBox5.Controls.Add(this.txtLumRes);
            this.groupBox5.Controls.Add(this.txtIllumRes);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(2, 435);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IlluminanceSensor";
            // 
            // txtLumWTime
            // 
            this.txtLumWTime.Location = new System.Drawing.Point(89, 71);
            this.txtLumWTime.Name = "txtLumWTime";
            this.txtLumWTime.Size = new System.Drawing.Size(34, 20);
            this.txtLumWTime.TabIndex = 5;
            // 
            // txtLumSen
            // 
            this.txtLumSen.Location = new System.Drawing.Point(50, 71);
            this.txtLumSen.Name = "txtLumSen";
            this.txtLumSen.Size = new System.Drawing.Size(34, 20);
            this.txtLumSen.TabIndex = 4;
            // 
            // txtIllum
            // 
            this.txtIllum.Location = new System.Drawing.Point(60, 19);
            this.txtIllum.Name = "txtIllum";
            this.txtIllum.Size = new System.Drawing.Size(63, 20);
            this.txtIllum.TabIndex = 2;
            // 
            // txtLumRes
            // 
            this.txtLumRes.Location = new System.Drawing.Point(11, 71);
            this.txtLumRes.Name = "txtLumRes";
            this.txtLumRes.Size = new System.Drawing.Size(34, 20);
            this.txtLumRes.TabIndex = 2;
            // 
            // txtIllumRes
            // 
            this.txtIllumRes.Location = new System.Drawing.Point(60, 45);
            this.txtIllumRes.Name = "txtIllumRes";
            this.txtIllumRes.Size = new System.Drawing.Size(63, 20);
            this.txtIllumRes.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Res:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Illum:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtObj);
            this.groupBox6.Controls.Add(this.txtATemp);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(2, 120);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 73);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SkySensor";
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(60, 19);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(63, 20);
            this.txtObj.TabIndex = 2;
            // 
            // txtATemp
            // 
            this.txtATemp.Location = new System.Drawing.Point(60, 45);
            this.txtATemp.Name = "txtATemp";
            this.txtATemp.Size = new System.Drawing.Size(63, 20);
            this.txtATemp.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "ATemp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "ObjTemp:";
            // 
            // btnPreferences
            // 
            this.btnPreferences.Location = new System.Drawing.Point(169, 10);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(79, 22);
            this.btnPreferences.TabIndex = 6;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnLogWindow
            // 
            this.btnLogWindow.Location = new System.Drawing.Point(89, 10);
            this.btnLogWindow.Name = "btnLogWindow";
            this.btnLogWindow.Size = new System.Drawing.Size(74, 22);
            this.btnLogWindow.TabIndex = 7;
            this.btnLogWindow.Text = "Show Log";
            this.btnLogWindow.UseVisualStyleBackColor = true;
            this.btnLogWindow.Click += new System.EventHandler(this.btnLogWindow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRGC);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtWet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wet Sensor";
            // 
            // txtRGC
            // 
            this.txtRGC.Location = new System.Drawing.Point(60, 45);
            this.txtRGC.Name = "txtRGC";
            this.txtRGC.Size = new System.Drawing.Size(63, 20);
            this.txtRGC.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "RG";
            // 
            // txtWet
            // 
            this.txtWet.Location = new System.Drawing.Point(60, 19);
            this.txtWet.Name = "txtWet";
            this.txtWet.Size = new System.Drawing.Size(63, 20);
            this.txtWet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wet:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTemp1);
            this.groupBox7.Controls.Add(this.txtTemp2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(2, 623);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(136, 74);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temp sensors";
            // 
            // txtTemp1
            // 
            this.txtTemp1.Location = new System.Drawing.Point(60, 19);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(63, 20);
            this.txtTemp1.TabIndex = 2;
            // 
            // txtTemp2
            // 
            this.txtTemp2.Location = new System.Drawing.Point(60, 45);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.Size = new System.Drawing.Size(63, 20);
            this.txtTemp2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temp2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Temp1:";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(596, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // timer_debug_changetext
            // 
            this.timer_debug_changetext.Interval = 10000;
            this.timer_debug_changetext.Tick += new System.EventHandler(this.timer_debug_Tick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.LightGray;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 7;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Silver;
            stripLine1.BackColor = System.Drawing.Color.White;
            stripLine1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            stripLine1.BackSecondaryColor = System.Drawing.Color.LightSkyBlue;
            stripLine1.StripWidth = 12D;
            chartArea1.AxisY.StripLines.Add(stripLine1);
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            stripLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stripLine2.IntervalOffset = -5D;
            stripLine2.StripWidth = 5D;
            chartArea1.AxisY2.StripLines.Add(stripLine2);
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80F;
            chartArea1.InnerPlotPosition.Width = 91.87197F;
            chartArea1.InnerPlotPosition.X = 6.520894F;
            chartArea1.InnerPlotPosition.Y = 7F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1_cloud";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 20F;
            chartArea1.Position.Width = 98F;
            chartArea2.AlignWithChartArea = "ChartArea1_cloud";
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 7;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            stripLine3.IntervalOffset = 20D;
            stripLine3.StripWidth = 5D;
            chartArea2.AxisX.StripLines.Add(stripLine3);
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            stripLine4.BackColor = System.Drawing.Color.LightSteelBlue;
            stripLine4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            stripLine4.BackSecondaryColor = System.Drawing.Color.White;
            stripLine4.IntervalOffset = -5D;
            stripLine4.StripWidth = 5D;
            chartArea2.AxisY.StripLines.Add(stripLine4);
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BorderColor = System.Drawing.Color.Silver;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 88F;
            chartArea2.InnerPlotPosition.Width = 91.87197F;
            chartArea2.InnerPlotPosition.X = 6.520894F;
            chartArea2.InnerPlotPosition.Y = 7.875004F;
            chartArea2.Name = "ChartArea2_cloud2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 20F;
            chartArea2.Position.Width = 98F;
            chartArea2.Position.X = 1F;
            chartArea2.Position.Y = 20F;
            chartArea3.AlignWithChartArea = "ChartArea1_cloud";
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea3.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.Silver;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 88F;
            chartArea3.InnerPlotPosition.Width = 91.87197F;
            chartArea3.InnerPlotPosition.X = 6.520894F;
            chartArea3.InnerPlotPosition.Y = 7.875004F;
            chartArea3.Name = "ChartArea3_temp";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 20F;
            chartArea3.Position.Width = 98F;
            chartArea3.Position.X = 1F;
            chartArea3.Position.Y = 40F;
            chartArea4.AlignWithChartArea = "ChartArea1_cloud";
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX2.MajorGrid.Enabled = false;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea4.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisY2.MajorGrid.Enabled = false;
            chartArea4.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea4.BorderColor = System.Drawing.Color.Silver;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorY.IsUserEnabled = true;
            chartArea4.CursorY.IsUserSelectionEnabled = true;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 88F;
            chartArea4.InnerPlotPosition.Width = 91.87197F;
            chartArea4.InnerPlotPosition.X = 6.520894F;
            chartArea4.InnerPlotPosition.Y = 7.875004F;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "ChartArea4_rain";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 20F;
            chartArea4.Position.Width = 98F;
            chartArea4.Position.X = 1F;
            chartArea4.Position.Y = 60F;
            chartArea5.AlignWithChartArea = "ChartArea1_cloud";
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea5.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY2.LabelStyle.Enabled = false;
            chartArea5.AxisY2.LineWidth = 0;
            chartArea5.AxisY2.MajorGrid.Enabled = false;
            chartArea5.AxisY2.MajorTickMark.Enabled = false;
            chartArea5.AxisY2.Maximum = 2D;
            chartArea5.AxisY2.Minimum = 0D;
            chartArea5.BorderColor = System.Drawing.Color.Silver;
            chartArea5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.CursorY.IsUserEnabled = true;
            chartArea5.CursorY.IsUserSelectionEnabled = true;
            chartArea5.InnerPlotPosition.Auto = false;
            chartArea5.InnerPlotPosition.Height = 83F;
            chartArea5.InnerPlotPosition.Width = 91.87197F;
            chartArea5.InnerPlotPosition.X = 6.520894F;
            chartArea5.InnerPlotPosition.Y = 7.874985F;
            chartArea5.IsSameFontSizeForAllAxes = true;
            chartArea5.Name = "ChartArea5_illum";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 20F;
            chartArea5.Position.Width = 98F;
            chartArea5.Position.X = 1F;
            chartArea5.Position.Y = 80F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.ChartAreas.Add(chartArea5);
            legend1.DockedToChartArea = "ChartArea5_illum";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(149, 126);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1_cloud";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "CloudIndex";
            series1.ToolTip = "Cloud index (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#M" +
    "IN{F1} max:#MAX{F1} avg:#AVG{F1}";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea2_cloud2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "CloudIndex2";
            series2.ToolTip = "Cloud idx by AAG (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nm" +
    "in:#MIN{F1} max:#MAX{F1} avg:#AVG{F1}\\n\\n";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.ChartArea = "ChartArea2_cloud2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "SkyTemp";
            series3.ToolTip = "Sky temperature (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmi" +
    "n:#MIN{F1} max:#MAX{F1} avg:#AVG{F1}";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea3_temp";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Temp1";
            series4.ToolTip = "Temp1 (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN{F1}" +
    " max:#MAX{F1} avg:#AVG{F1}\\n";
            series5.ChartArea = "ChartArea3_temp";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Temp2";
            series5.ToolTip = "Temp2 #VAL{F1} (at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN{F1}" +
    " max:#MAX{F1} avg:#AVG{F1}\\n";
            series6.ChartArea = "ChartArea3_temp";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "Temp3";
            series6.ToolTip = "Temp3 (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN{F1}" +
    " max:#MAX{F1} avg:#AVG{F1}\\n";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea4_rain";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "Wet";
            series7.ToolTip = "Rain index (#VAL{D} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\nmin:#MIN{" +
    "D} max:#MAX{D} avg:#AVG{D}\\n";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea4_rain";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.IsValueShownAsLabel = true;
            series8.Label = "#VAL";
            series8.Legend = "Legend1";
            series8.Name = "RGC";
            series8.ToolTip = "Rain gauge counter (#VAL{D}lx at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\" +
    "nmin:#MIN{D} max:#MAX{D} avg:#AVG{D}\\n";
            series9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series9.ChartArea = "ChartArea4_rain";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "Hum";
            series9.ToolTip = "Humidity (#VAL{D}% at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D}%\\nmin:#MIN{D" +
    "}% max:#MAX{D}% avg:#AVG{D}%\\n";
            series9.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series10.ChartArea = "ChartArea5_illum";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "Illum";
            series10.ToolTip = "Illuminance (#VAL{D}lx at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\nmin:#M" +
    "IN{D} max:#MAX{D} avg:#AVG{D}\\n";
            series11.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series11.ChartArea = "ChartArea4_rain";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Legend = "Legend1";
            series11.Name = "Hum2";
            series11.ToolTip = "Humidity2 (#VAL{D}% at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D}%\\nmin:#MIN{" +
    "D}% max:#MAX{D}% avg:#AVG{D}%\\n\\n";
            series11.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series12.ChartArea = "ChartArea5_illum";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series12.Legend = "Legend1";
            series12.Name = "RL1";
            series12.ToolTip = "Relay (#VAL{D}% at #VALX{dd.MM.yyyy HH:mm})\\n";
            series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series13.ChartArea = "ChartArea3_temp";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Legend = "Legend1";
            series13.Name = "ATemp";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(526, 577);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "CloudSensor";
            title1.DockedToChartArea = "ChartArea1_cloud";
            title1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.LightGray;
            title1.Name = "Title1";
            title1.Text = "Cloud Index (usual)";
            title2.DockedToChartArea = "ChartArea2_cloud2";
            title2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.LightGray;
            title2.Name = "Title2";
            title2.Text = "Cloud Index (by AAG)";
            title3.DockedToChartArea = "ChartArea3_temp";
            title3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.ForeColor = System.Drawing.Color.LightGray;
            title3.Name = "Title3";
            title3.Text = "Temperature";
            title4.DockedToChartArea = "ChartArea4_rain";
            title4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.ForeColor = System.Drawing.Color.LightGray;
            title4.Name = "Title4";
            title4.Text = "Rain & Wetness";
            title5.DockedToChartArea = "ChartArea5_illum";
            title5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.ForeColor = System.Drawing.Color.LightGray;
            title5.Name = "Title5";
            title5.Text = "Illumination";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            this.chart1.Titles.Add(title4);
            this.chart1.Titles.Add(title5);
            // 
            // txtCloudIndex2
            // 
            this.txtCloudIndex2.Location = new System.Drawing.Point(91, 15);
            this.txtCloudIndex2.Name = "txtCloudIndex2";
            this.txtCloudIndex2.Size = new System.Drawing.Size(63, 20);
            this.txtCloudIndex2.TabIndex = 9;
            // 
            // txtCloudIndex1
            // 
            this.txtCloudIndex1.Location = new System.Drawing.Point(91, 47);
            this.txtCloudIndex1.Name = "txtCloudIndex1";
            this.txtCloudIndex1.Size = new System.Drawing.Size(63, 20);
            this.txtCloudIndex1.TabIndex = 9;
            // 
            // txtRainCond
            // 
            this.txtRainCond.Location = new System.Drawing.Point(89, 47);
            this.txtRainCond.Name = "txtRainCond";
            this.txtRainCond.Size = new System.Drawing.Size(75, 20);
            this.txtRainCond.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cloud condition:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Rain condition:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(170, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Day condition:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.txtWetflag);
            this.groupBox8.Controls.Add(this.txtRainflag);
            this.groupBox8.Controls.Add(this.txtDayCond);
            this.groupBox8.Controls.Add(this.txtCloudCond);
            this.groupBox8.Controls.Add(this.txtRainCond);
            this.groupBox8.Location = new System.Drawing.Point(2, 41);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(416, 73);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Boltwood cloud sensor flags state";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(329, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Wet flag:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(251, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Rain flag:";
            // 
            // txtWetflag
            // 
            this.txtWetflag.Location = new System.Drawing.Point(332, 47);
            this.txtWetflag.Name = "txtWetflag";
            this.txtWetflag.Size = new System.Drawing.Size(75, 20);
            this.txtWetflag.TabIndex = 10;
            // 
            // txtRainflag
            // 
            this.txtRainflag.Location = new System.Drawing.Point(251, 47);
            this.txtRainflag.Name = "txtRainflag";
            this.txtRainflag.Size = new System.Drawing.Size(75, 20);
            this.txtRainflag.TabIndex = 10;
            // 
            // txtDayCond
            // 
            this.txtDayCond.Location = new System.Drawing.Point(170, 47);
            this.txtDayCond.Name = "txtDayCond";
            this.txtDayCond.Size = new System.Drawing.Size(75, 20);
            this.txtDayCond.TabIndex = 10;
            // 
            // txtCloudCond
            // 
            this.txtCloudCond.Location = new System.Drawing.Point(6, 47);
            this.txtCloudCond.Name = "txtCloudCond";
            this.txtCloudCond.Size = new System.Drawing.Size(75, 20);
            this.txtCloudCond.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "CloudIdx usual";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "CloudIdx by AAG";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(318, 10);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(100, 23);
            this.btnSimulate.TabIndex = 8;
            this.btnSimulate.Text = "Simulation";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtCloudIndex1);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.txtCloudIndex2);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Location = new System.Drawing.Point(509, 41);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(166, 73);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Cloud index";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnRelay);
            this.groupBox10.Location = new System.Drawing.Point(427, 44);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(71, 69);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Heating";
            // 
            // btnRelay
            // 
            this.btnRelay.Location = new System.Drawing.Point(6, 22);
            this.btnRelay.Name = "btnRelay";
            this.btnRelay.Size = new System.Drawing.Size(59, 42);
            this.btnRelay.TabIndex = 0;
            this.btnRelay.Text = "On";
            this.btnRelay.UseVisualStyleBackColor = true;
            this.btnRelay.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // timer_debug_portread
            // 
            this.timer_debug_portread.Tick += new System.EventHandler(this.timer_debug_portread_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 712);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnLogWindow);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 750);
            this.MinimumSize = new System.Drawing.Size(400, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Staion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBTemp;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHum1;
        private System.Windows.Forms.TextBox txtDTemp1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtHum2;
        private System.Windows.Forms.TextBox txtDTemp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtIllum;
        private System.Windows.Forms.TextBox txtLumRes;
        private System.Windows.Forms.TextBox txtIllumRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.TextBox txtATemp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnLogWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLumWTime;
        private System.Windows.Forms.TextBox txtLumSen;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtRGC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCloudIndex2;
        private System.Windows.Forms.TextBox txtCloudIndex1;
        private System.Windows.Forms.TextBox txtRainCond;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDayCond;
        private System.Windows.Forms.TextBox txtCloudCond;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRainflag;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtWetflag;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Button btnSimulate;
        public System.Windows.Forms.Timer timer_debug_changetext;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnRelay;
        private System.Windows.Forms.Timer timer_debug_portread;
    }
}

