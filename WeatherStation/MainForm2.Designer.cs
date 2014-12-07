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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine5 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine6 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFldBTemp = new System.Windows.Forms.TextBox();
            this.txtFldPress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFldHum1 = new System.Windows.Forms.TextBox();
            this.txtFldDTemp1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFldHum2 = new System.Windows.Forms.TextBox();
            this.txtFldDTemp2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFldLumWTime = new System.Windows.Forms.TextBox();
            this.txtFldLumSen = new System.Windows.Forms.TextBox();
            this.txtFldIllum = new System.Windows.Forms.TextBox();
            this.txtFldLumRes = new System.Windows.Forms.TextBox();
            this.txtFldIllumRes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtFldObj = new System.Windows.Forms.TextBox();
            this.txtFldATemp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnLogWindow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFldRGCCumulative = new System.Windows.Forms.TextBox();
            this.txtFldRGC = new System.Windows.Forms.TextBox();
            this.txtRGCLastMin = new System.Windows.Forms.TextBox();
            this.txtWetLastMin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFldWet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtFldTemp1 = new System.Windows.Forms.TextBox();
            this.txtFldTemp2 = new System.Windows.Forms.TextBox();
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
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCSNeedHeating = new System.Windows.Forms.TextBox();
            this.btnRelay = new System.Windows.Forms.Button();
            this.txtSinceHeatingOn = new System.Windows.Forms.TextBox();
            this.txtRainLastMinute = new System.Windows.Forms.TextBox();
            this.txtSinceHeatingOff = new System.Windows.Forms.TextBox();
            this.timer_debug_portread = new System.Windows.Forms.Timer(this.components);
            this.txtArdSetTD = new System.Windows.Forms.TextBox();
            this.txtArdSetWT = new System.Windows.Forms.TextBox();
            this.txtArdSetRT = new System.Windows.Forms.TextBox();
            this.btnQueryArduinoSettings = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtMinCloudIdx = new System.Windows.Forms.TextBox();
            this.txtMinRainIdx = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txt0min = new System.Windows.Forms.TextBox();
            this.txt5min = new System.Windows.Forms.TextBox();
            this.txt10min = new System.Windows.Forms.TextBox();
            this.txt15min = new System.Windows.Forms.TextBox();
            this.txt20min = new System.Windows.Forms.TextBox();
            this.pannelMaximum = new System.Windows.Forms.Panel();
            this.panelDebug = new System.Windows.Forms.Panel();
            this.pannelMinimum = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnStart_min = new System.Windows.Forms.Button();
            this.btnIndRelay = new System.Windows.Forms.Button();
            this.btnIndRain = new System.Windows.Forms.Button();
            this.btnIndCloud = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pannelMaximum.SuspendLayout();
            this.panelDebug.SuspendLayout();
            this.pannelMinimum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            // timer_main
            // 
            this.timer_main.Interval = 10000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
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
            this.groupBox2.Controls.Add(this.txtFldBTemp);
            this.groupBox2.Controls.Add(this.txtFldPress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(2, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 73);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PressureSensor";
            // 
            // txtFldBTemp
            // 
            this.txtFldBTemp.Location = new System.Drawing.Point(60, 19);
            this.txtFldBTemp.Name = "txtFldBTemp";
            this.txtFldBTemp.Size = new System.Drawing.Size(63, 20);
            this.txtFldBTemp.TabIndex = 0;
            // 
            // txtFldPress
            // 
            this.txtFldPress.Location = new System.Drawing.Point(60, 45);
            this.txtFldPress.Name = "txtFldPress";
            this.txtFldPress.Size = new System.Drawing.Size(63, 20);
            this.txtFldPress.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFldHum1);
            this.groupBox3.Controls.Add(this.txtFldDTemp1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(2, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 73);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HumiditySensor";
            // 
            // txtFldHum1
            // 
            this.txtFldHum1.Location = new System.Drawing.Point(60, 19);
            this.txtFldHum1.Name = "txtFldHum1";
            this.txtFldHum1.Size = new System.Drawing.Size(63, 20);
            this.txtFldHum1.TabIndex = 0;
            // 
            // txtFldDTemp1
            // 
            this.txtFldDTemp1.Location = new System.Drawing.Point(60, 45);
            this.txtFldDTemp1.Name = "txtFldDTemp1";
            this.txtFldDTemp1.Size = new System.Drawing.Size(63, 20);
            this.txtFldDTemp1.TabIndex = 1;
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
            this.groupBox4.Controls.Add(this.txtFldHum2);
            this.groupBox4.Controls.Add(this.txtFldDTemp2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(2, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 73);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HumiditySensor2";
            // 
            // txtFldHum2
            // 
            this.txtFldHum2.Location = new System.Drawing.Point(60, 19);
            this.txtFldHum2.Name = "txtFldHum2";
            this.txtFldHum2.Size = new System.Drawing.Size(63, 20);
            this.txtFldHum2.TabIndex = 0;
            // 
            // txtFldDTemp2
            // 
            this.txtFldDTemp2.Location = new System.Drawing.Point(60, 45);
            this.txtFldDTemp2.Name = "txtFldDTemp2";
            this.txtFldDTemp2.Size = new System.Drawing.Size(63, 20);
            this.txtFldDTemp2.TabIndex = 1;
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
            this.groupBox5.Controls.Add(this.txtFldLumWTime);
            this.groupBox5.Controls.Add(this.txtFldLumSen);
            this.groupBox5.Controls.Add(this.txtFldIllum);
            this.groupBox5.Controls.Add(this.txtFldLumRes);
            this.groupBox5.Controls.Add(this.txtFldIllumRes);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(2, 435);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 100);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IlluminanceSensor";
            // 
            // txtFldLumWTime
            // 
            this.txtFldLumWTime.Location = new System.Drawing.Point(89, 71);
            this.txtFldLumWTime.Name = "txtFldLumWTime";
            this.txtFldLumWTime.Size = new System.Drawing.Size(34, 20);
            this.txtFldLumWTime.TabIndex = 4;
            // 
            // txtFldLumSen
            // 
            this.txtFldLumSen.Location = new System.Drawing.Point(50, 71);
            this.txtFldLumSen.Name = "txtFldLumSen";
            this.txtFldLumSen.Size = new System.Drawing.Size(34, 20);
            this.txtFldLumSen.TabIndex = 3;
            // 
            // txtFldIllum
            // 
            this.txtFldIllum.Location = new System.Drawing.Point(60, 19);
            this.txtFldIllum.Name = "txtFldIllum";
            this.txtFldIllum.Size = new System.Drawing.Size(63, 20);
            this.txtFldIllum.TabIndex = 0;
            // 
            // txtFldLumRes
            // 
            this.txtFldLumRes.Location = new System.Drawing.Point(11, 71);
            this.txtFldLumRes.Name = "txtFldLumRes";
            this.txtFldLumRes.Size = new System.Drawing.Size(34, 20);
            this.txtFldLumRes.TabIndex = 2;
            // 
            // txtFldIllumRes
            // 
            this.txtFldIllumRes.Location = new System.Drawing.Point(60, 45);
            this.txtFldIllumRes.Name = "txtFldIllumRes";
            this.txtFldIllumRes.Size = new System.Drawing.Size(63, 20);
            this.txtFldIllumRes.TabIndex = 1;
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
            this.groupBox6.Controls.Add(this.txtFldObj);
            this.groupBox6.Controls.Add(this.txtFldATemp);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(2, 120);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 73);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SkySensor";
            // 
            // txtFldObj
            // 
            this.txtFldObj.Location = new System.Drawing.Point(60, 19);
            this.txtFldObj.Name = "txtFldObj";
            this.txtFldObj.Size = new System.Drawing.Size(63, 20);
            this.txtFldObj.TabIndex = 0;
            // 
            // txtFldATemp
            // 
            this.txtFldATemp.Location = new System.Drawing.Point(60, 45);
            this.txtFldATemp.Name = "txtFldATemp";
            this.txtFldATemp.Size = new System.Drawing.Size(63, 20);
            this.txtFldATemp.TabIndex = 1;
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
            this.btnPreferences.Location = new System.Drawing.Point(90, 10);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(79, 22);
            this.btnPreferences.TabIndex = 1;
            this.btnPreferences.Text = "Settings";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnLogWindow
            // 
            this.btnLogWindow.Location = new System.Drawing.Point(175, 10);
            this.btnLogWindow.Name = "btnLogWindow";
            this.btnLogWindow.Size = new System.Drawing.Size(74, 22);
            this.btnLogWindow.TabIndex = 2;
            this.btnLogWindow.Text = "Show Log";
            this.btnLogWindow.UseVisualStyleBackColor = true;
            this.btnLogWindow.Click += new System.EventHandler(this.btnLogWindow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFldRGCCumulative);
            this.groupBox1.Controls.Add(this.txtFldRGC);
            this.groupBox1.Controls.Add(this.txtRGCLastMin);
            this.groupBox1.Controls.Add(this.txtWetLastMin);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtFldWet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 76);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wet Sensor";
            // 
            // txtFldRGCCumulative
            // 
            this.txtFldRGCCumulative.Location = new System.Drawing.Point(72, 45);
            this.txtFldRGCCumulative.Name = "txtFldRGCCumulative";
            this.txtFldRGCCumulative.Size = new System.Drawing.Size(37, 20);
            this.txtFldRGCCumulative.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.txtFldRGCCumulative, "Incremental (from the very begining) RG-11 rain sensor value. Used for narodmon s" +
        "ervice");
            // 
            // txtFldRGC
            // 
            this.txtFldRGC.Location = new System.Drawing.Point(37, 45);
            this.txtFldRGC.Name = "txtFldRGC";
            this.txtFldRGC.Size = new System.Drawing.Size(30, 20);
            this.txtFldRGC.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.txtFldRGC, "Current RG-11 rain sensor value");
            // 
            // txtRGCLastMin
            // 
            this.txtRGCLastMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRGCLastMin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtRGCLastMin.Location = new System.Drawing.Point(114, 45);
            this.txtRGCLastMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtRGCLastMin.Name = "txtRGCLastMin";
            this.txtRGCLastMin.ReadOnly = true;
            this.txtRGCLastMin.Size = new System.Drawing.Size(18, 20);
            this.txtRGCLastMin.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.txtRGCLastMin, "Rain RG-11 sensor status:\r\n\"-\" none\r\n\"now\" - rain was detected during last measur" +
        "e cycle\r\n\"rain\" - rain was detected during last minute (but not during current c" +
        "ycle)\r\n");
            // 
            // txtWetLastMin
            // 
            this.txtWetLastMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtWetLastMin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtWetLastMin.Location = new System.Drawing.Point(114, 19);
            this.txtWetLastMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtWetLastMin.Name = "txtWetLastMin";
            this.txtWetLastMin.ReadOnly = true;
            this.txtWetLastMin.Size = new System.Drawing.Size(18, 20);
            this.txtWetLastMin.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.txtWetLastMin, resources.GetString("txtWetLastMin.ToolTip"));
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
            // txtFldWet
            // 
            this.txtFldWet.Location = new System.Drawing.Point(60, 19);
            this.txtFldWet.Name = "txtFldWet";
            this.txtFldWet.Size = new System.Drawing.Size(50, 20);
            this.txtFldWet.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.txtFldWet, "Current wet sensor value");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wet:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtFldTemp1);
            this.groupBox7.Controls.Add(this.txtFldTemp2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(4, 623);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(134, 74);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temp sensors";
            // 
            // txtFldTemp1
            // 
            this.txtFldTemp1.Location = new System.Drawing.Point(60, 19);
            this.txtFldTemp1.Name = "txtFldTemp1";
            this.txtFldTemp1.Size = new System.Drawing.Size(63, 20);
            this.txtFldTemp1.TabIndex = 0;
            // 
            // txtFldTemp2
            // 
            this.txtFldTemp2.Location = new System.Drawing.Point(60, 45);
            this.txtFldTemp2.Name = "txtFldTemp2";
            this.txtFldTemp2.Size = new System.Drawing.Size(63, 20);
            this.txtFldTemp2.TabIndex = 1;
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
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(675, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // timer_debug_changetext
            // 
            this.timer_debug_changetext.Interval = 9000;
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
            chartArea4.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea4.AxisY2.ScaleBreakStyle.CollapsibleSpaceThreshold = 20;
            chartArea4.AxisY2.ScaleBreakStyle.Enabled = true;
            chartArea4.AxisY2.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
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
            series8.ToolTip = "Rain gauge counter (#VAL{D} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\nm" +
    "in:#MIN{D} max:#MAX{D} avg:#AVG{D}\\n";
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
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
            series11.ChartArea = "ChartArea5_illum";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Legend = "Legend1";
            series11.Name = "RL1";
            series11.ToolTip = "Relay (#VAL{D}% at #VALX{dd.MM.yyyy HH:mm})\\n";
            series11.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series12.ChartArea = "ChartArea3_temp";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Legend = "Legend1";
            series12.Name = "ATemp";
            series12.ToolTip = "Case temp (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN" +
    "{F1} max:#MAX{F1} avg:#AVG{F1}\\n";
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
            this.chart1.Size = new System.Drawing.Size(615, 571);
            this.chart1.TabIndex = 24;
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
            this.txtCloudIndex2.Size = new System.Drawing.Size(54, 20);
            this.txtCloudIndex2.TabIndex = 1;
            // 
            // txtCloudIndex1
            // 
            this.txtCloudIndex1.Location = new System.Drawing.Point(91, 47);
            this.txtCloudIndex1.Name = "txtCloudIndex1";
            this.txtCloudIndex1.Size = new System.Drawing.Size(54, 20);
            this.txtCloudIndex1.TabIndex = 2;
            // 
            // txtRainCond
            // 
            this.txtRainCond.Location = new System.Drawing.Point(89, 47);
            this.txtRainCond.Name = "txtRainCond";
            this.txtRainCond.Size = new System.Drawing.Size(75, 20);
            this.txtRainCond.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 6;
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
            this.groupBox8.TabIndex = 14;
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
            this.txtWetflag.TabIndex = 4;
            // 
            // txtRainflag
            // 
            this.txtRainflag.Location = new System.Drawing.Point(251, 47);
            this.txtRainflag.Name = "txtRainflag";
            this.txtRainflag.Size = new System.Drawing.Size(75, 20);
            this.txtRainflag.TabIndex = 3;
            // 
            // txtDayCond
            // 
            this.txtDayCond.Location = new System.Drawing.Point(170, 47);
            this.txtDayCond.Name = "txtDayCond";
            this.txtDayCond.Size = new System.Drawing.Size(75, 20);
            this.txtDayCond.TabIndex = 2;
            // 
            // txtCloudCond
            // 
            this.txtCloudCond.Location = new System.Drawing.Point(6, 47);
            this.txtCloudCond.Name = "txtCloudCond";
            this.txtCloudCond.Size = new System.Drawing.Size(75, 20);
            this.txtCloudCond.TabIndex = 0;
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
            this.label20.TabIndex = 0;
            this.label20.Text = "CloudIdx by AAG";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimulate.Location = new System.Drawing.Point(569, 9);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(100, 23);
            this.btnSimulate.TabIndex = 12;
            this.btnSimulate.Text = "Simulation";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.txtCloudIndex1);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.txtCloudIndex2);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Location = new System.Drawing.Point(588, 41);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(176, 73);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Cloud index";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label22);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.txtCSNeedHeating);
            this.groupBox10.Controls.Add(this.btnRelay);
            this.groupBox10.Controls.Add(this.txtSinceHeatingOn);
            this.groupBox10.Controls.Add(this.txtRainLastMinute);
            this.groupBox10.Controls.Add(this.txtSinceHeatingOff);
            this.groupBox10.Location = new System.Drawing.Point(427, 41);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(167, 73);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Heating";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(103, 53);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "CS";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(103, 15);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Rain";
            // 
            // txtCSNeedHeating
            // 
            this.txtCSNeedHeating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCSNeedHeating.Location = new System.Drawing.Point(132, 50);
            this.txtCSNeedHeating.Margin = new System.Windows.Forms.Padding(2);
            this.txtCSNeedHeating.Name = "txtCSNeedHeating";
            this.txtCSNeedHeating.ReadOnly = true;
            this.txtCSNeedHeating.Size = new System.Drawing.Size(31, 20);
            this.txtCSNeedHeating.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.txtCSNeedHeating, resources.GetString("txtCSNeedHeating.ToolTip"));
            // 
            // btnRelay
            // 
            this.btnRelay.Enabled = false;
            this.btnRelay.Location = new System.Drawing.Point(6, 15);
            this.btnRelay.Name = "btnRelay";
            this.btnRelay.Size = new System.Drawing.Size(88, 29);
            this.btnRelay.TabIndex = 0;
            this.btnRelay.Text = "On";
            this.mainToolTip.SetToolTip(this.btnRelay, "Switch heating relay on");
            this.btnRelay.UseVisualStyleBackColor = true;
            this.btnRelay.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // txtSinceHeatingOn
            // 
            this.txtSinceHeatingOn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSinceHeatingOn.Location = new System.Drawing.Point(6, 50);
            this.txtSinceHeatingOn.Margin = new System.Windows.Forms.Padding(2);
            this.txtSinceHeatingOn.Name = "txtSinceHeatingOn";
            this.txtSinceHeatingOn.ReadOnly = true;
            this.txtSinceHeatingOn.Size = new System.Drawing.Size(43, 20);
            this.txtSinceHeatingOn.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.txtSinceHeatingOn, "Seconds since last heating relay switching on");
            // 
            // txtRainLastMinute
            // 
            this.txtRainLastMinute.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRainLastMinute.Location = new System.Drawing.Point(133, 14);
            this.txtRainLastMinute.Margin = new System.Windows.Forms.Padding(2);
            this.txtRainLastMinute.Name = "txtRainLastMinute";
            this.txtRainLastMinute.ReadOnly = true;
            this.txtRainLastMinute.Size = new System.Drawing.Size(30, 20);
            this.txtRainLastMinute.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.txtRainLastMinute, "Rain last minute (calcluated on both wet and rain RG-11 sensors)");
            // 
            // txtSinceHeatingOff
            // 
            this.txtSinceHeatingOff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSinceHeatingOff.Location = new System.Drawing.Point(52, 50);
            this.txtSinceHeatingOff.Margin = new System.Windows.Forms.Padding(2);
            this.txtSinceHeatingOff.Name = "txtSinceHeatingOff";
            this.txtSinceHeatingOff.ReadOnly = true;
            this.txtSinceHeatingOff.Size = new System.Drawing.Size(43, 20);
            this.txtSinceHeatingOff.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.txtSinceHeatingOff, "Seconds since last heating relay switching off");
            // 
            // timer_debug_portread
            // 
            this.timer_debug_portread.Tick += new System.EventHandler(this.timer_debug_portread_Tick);
            // 
            // txtArdSetTD
            // 
            this.txtArdSetTD.Location = new System.Drawing.Point(234, 0);
            this.txtArdSetTD.Margin = new System.Windows.Forms.Padding(2);
            this.txtArdSetTD.Name = "txtArdSetTD";
            this.txtArdSetTD.ReadOnly = true;
            this.txtArdSetTD.Size = new System.Drawing.Size(36, 20);
            this.txtArdSetTD.TabIndex = 8;
            this.mainToolTip.SetToolTip(this.txtArdSetTD, "Actual maximum temperature delta setting as it was read from Arduino ");
            // 
            // txtArdSetWT
            // 
            this.txtArdSetWT.Location = new System.Drawing.Point(271, 0);
            this.txtArdSetWT.Margin = new System.Windows.Forms.Padding(2);
            this.txtArdSetWT.Name = "txtArdSetWT";
            this.txtArdSetWT.ReadOnly = true;
            this.txtArdSetWT.Size = new System.Drawing.Size(36, 20);
            this.txtArdSetWT.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.txtArdSetWT, "Actual heating starting wet threshold setting as it was read from Arduino ");
            // 
            // txtArdSetRT
            // 
            this.txtArdSetRT.Location = new System.Drawing.Point(235, 20);
            this.txtArdSetRT.Margin = new System.Windows.Forms.Padding(2);
            this.txtArdSetRT.Name = "txtArdSetRT";
            this.txtArdSetRT.ReadOnly = true;
            this.txtArdSetRT.Size = new System.Drawing.Size(47, 20);
            this.txtArdSetRT.TabIndex = 10;
            this.mainToolTip.SetToolTip(this.txtArdSetRT, "Actual maximum heating cycle duration setting as it was read from Arduino \r\n");
            // 
            // btnQueryArduinoSettings
            // 
            this.btnQueryArduinoSettings.Location = new System.Drawing.Point(286, 21);
            this.btnQueryArduinoSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnQueryArduinoSettings.Name = "btnQueryArduinoSettings";
            this.btnQueryArduinoSettings.Size = new System.Drawing.Size(21, 20);
            this.btnQueryArduinoSettings.TabIndex = 11;
            this.btnQueryArduinoSettings.Text = "?";
            this.mainToolTip.SetToolTip(this.btnQueryArduinoSettings, "Query actual settings from Arduino ");
            this.btnQueryArduinoSettings.UseVisualStyleBackColor = true;
            this.btnQueryArduinoSettings.Click += new System.EventHandler(this.btnQueryArduinoSettings_Click);
            // 
            // txtMinCloudIdx
            // 
            this.txtMinCloudIdx.Location = new System.Drawing.Point(219, 86);
            this.txtMinCloudIdx.Name = "txtMinCloudIdx";
            this.txtMinCloudIdx.Size = new System.Drawing.Size(38, 20);
            this.txtMinCloudIdx.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.txtMinCloudIdx, "Cloud index");
            // 
            // txtMinRainIdx
            // 
            this.txtMinRainIdx.Location = new System.Drawing.Point(300, 86);
            this.txtMinRainIdx.Name = "txtMinRainIdx";
            this.txtMinRainIdx.Size = new System.Drawing.Size(38, 20);
            this.txtMinRainIdx.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.txtMinRainIdx, "Wet index");
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(380, 86);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(38, 20);
            this.txtMinTemp.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.txtMinTemp, "Current temperature");
            // 
            // txt0min
            // 
            this.txt0min.Location = new System.Drawing.Point(2, 9);
            this.txt0min.Margin = new System.Windows.Forms.Padding(2);
            this.txt0min.Name = "txt0min";
            this.txt0min.ReadOnly = true;
            this.txt0min.Size = new System.Drawing.Size(43, 20);
            this.txt0min.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.txt0min, resources.GetString("txt0min.ToolTip"));
            // 
            // txt5min
            // 
            this.txt5min.Location = new System.Drawing.Point(49, 9);
            this.txt5min.Margin = new System.Windows.Forms.Padding(2);
            this.txt5min.Name = "txt5min";
            this.txt5min.ReadOnly = true;
            this.txt5min.Size = new System.Drawing.Size(43, 20);
            this.txt5min.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.txt5min, resources.GetString("txt5min.ToolTip"));
            // 
            // txt10min
            // 
            this.txt10min.Location = new System.Drawing.Point(95, 9);
            this.txt10min.Margin = new System.Windows.Forms.Padding(2);
            this.txt10min.Name = "txt10min";
            this.txt10min.ReadOnly = true;
            this.txt10min.Size = new System.Drawing.Size(43, 20);
            this.txt10min.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.txt10min, resources.GetString("txt10min.ToolTip"));
            // 
            // txt15min
            // 
            this.txt15min.Location = new System.Drawing.Point(142, 9);
            this.txt15min.Margin = new System.Windows.Forms.Padding(2);
            this.txt15min.Name = "txt15min";
            this.txt15min.ReadOnly = true;
            this.txt15min.Size = new System.Drawing.Size(43, 20);
            this.txt15min.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.txt15min, resources.GetString("txt15min.ToolTip"));
            // 
            // txt20min
            // 
            this.txt20min.Location = new System.Drawing.Point(188, 9);
            this.txt20min.Margin = new System.Windows.Forms.Padding(2);
            this.txt20min.Name = "txt20min";
            this.txt20min.ReadOnly = true;
            this.txt20min.Size = new System.Drawing.Size(43, 20);
            this.txt20min.TabIndex = 7;
            this.mainToolTip.SetToolTip(this.txt20min, resources.GetString("txt20min.ToolTip"));
            // 
            // pannelMaximum
            // 
            this.pannelMaximum.AutoSize = true;
            this.pannelMaximum.Controls.Add(this.groupBox10);
            this.pannelMaximum.Controls.Add(this.panelDebug);
            this.pannelMaximum.Controls.Add(this.groupBox9);
            this.pannelMaximum.Controls.Add(this.btnSimulate);
            this.pannelMaximum.Controls.Add(this.chart1);
            this.pannelMaximum.Controls.Add(this.btnLogWindow);
            this.pannelMaximum.Controls.Add(this.btnPreferences);
            this.pannelMaximum.Controls.Add(this.btnAbout);
            this.pannelMaximum.Controls.Add(this.btnStart);
            this.pannelMaximum.Controls.Add(this.groupBox5);
            this.pannelMaximum.Controls.Add(this.groupBox1);
            this.pannelMaximum.Controls.Add(this.groupBox7);
            this.pannelMaximum.Controls.Add(this.groupBox4);
            this.pannelMaximum.Controls.Add(this.groupBox3);
            this.pannelMaximum.Controls.Add(this.groupBox8);
            this.pannelMaximum.Controls.Add(this.groupBox6);
            this.pannelMaximum.Controls.Add(this.groupBox2);
            this.pannelMaximum.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelMaximum.Location = new System.Drawing.Point(0, 0);
            this.pannelMaximum.Name = "pannelMaximum";
            this.pannelMaximum.Size = new System.Drawing.Size(768, 700);
            this.pannelMaximum.TabIndex = 0;
            // 
            // panelDebug
            // 
            this.panelDebug.Controls.Add(this.btnQueryArduinoSettings);
            this.panelDebug.Controls.Add(this.txtArdSetWT);
            this.panelDebug.Controls.Add(this.txtArdSetRT);
            this.panelDebug.Controls.Add(this.txtArdSetTD);
            this.panelDebug.Controls.Add(this.txt20min);
            this.panelDebug.Controls.Add(this.txt15min);
            this.panelDebug.Controls.Add(this.txt10min);
            this.panelDebug.Controls.Add(this.txt5min);
            this.panelDebug.Controls.Add(this.txt0min);
            this.panelDebug.Location = new System.Drawing.Point(253, 0);
            this.panelDebug.Name = "panelDebug";
            this.panelDebug.Size = new System.Drawing.Size(309, 41);
            this.panelDebug.TabIndex = 25;
            // 
            // pannelMinimum
            // 
            this.pannelMinimum.AutoSize = true;
            this.pannelMinimum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pannelMinimum.Controls.Add(this.label26);
            this.pannelMinimum.Controls.Add(this.label25);
            this.pannelMinimum.Controls.Add(this.label24);
            this.pannelMinimum.Controls.Add(this.txtMinTemp);
            this.pannelMinimum.Controls.Add(this.txtMinRainIdx);
            this.pannelMinimum.Controls.Add(this.txtMinCloudIdx);
            this.pannelMinimum.Controls.Add(this.btnStart_min);
            this.pannelMinimum.Controls.Add(this.btnIndRelay);
            this.pannelMinimum.Controls.Add(this.btnIndRain);
            this.pannelMinimum.Controls.Add(this.btnIndCloud);
            this.pannelMinimum.Controls.Add(this.chart2);
            this.pannelMinimum.Location = new System.Drawing.Point(0, 705);
            this.pannelMinimum.Name = "pannelMinimum";
            this.pannelMinimum.Size = new System.Drawing.Size(764, 109);
            this.pannelMinimum.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(344, 89);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "Temp:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(264, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Wet:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(166, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "CloudIdx:";
            // 
            // btnStart_min
            // 
            this.btnStart_min.Location = new System.Drawing.Point(4, 84);
            this.btnStart_min.Name = "btnStart_min";
            this.btnStart_min.Size = new System.Drawing.Size(60, 22);
            this.btnStart_min.TabIndex = 3;
            this.btnStart_min.Text = "Start";
            this.btnStart_min.UseVisualStyleBackColor = true;
            this.btnStart_min.Click += new System.EventHandler(this.btnStart_min_Click);
            // 
            // btnIndRelay
            // 
            this.btnIndRelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndRelay.Location = new System.Drawing.Point(4, 55);
            this.btnIndRelay.Name = "btnIndRelay";
            this.btnIndRelay.Size = new System.Drawing.Size(50, 23);
            this.btnIndRelay.TabIndex = 2;
            this.btnIndRelay.Text = "Relay";
            this.btnIndRelay.UseVisualStyleBackColor = true;
            // 
            // btnIndRain
            // 
            this.btnIndRain.BackColor = System.Drawing.SystemColors.Control;
            this.btnIndRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndRain.Location = new System.Drawing.Point(4, 29);
            this.btnIndRain.Name = "btnIndRain";
            this.btnIndRain.Size = new System.Drawing.Size(50, 23);
            this.btnIndRain.TabIndex = 1;
            this.btnIndRain.Text = "Rain";
            this.btnIndRain.UseVisualStyleBackColor = false;
            // 
            // btnIndCloud
            // 
            this.btnIndCloud.BackColor = System.Drawing.SystemColors.Control;
            this.btnIndCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIndCloud.Location = new System.Drawing.Point(4, 3);
            this.btnIndCloud.Margin = new System.Windows.Forms.Padding(0);
            this.btnIndCloud.Name = "btnIndCloud";
            this.btnIndCloud.Size = new System.Drawing.Size(50, 23);
            this.btnIndCloud.TabIndex = 0;
            this.btnIndCloud.Text = "Cloud";
            this.btnIndCloud.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndCloud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIndCloud.UseVisualStyleBackColor = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.LightGray;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea6.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea6.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea6.AxisY.Interval = 10D;
            chartArea6.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea6.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea6.AxisY.MajorGrid.Interval = 10D;
            chartArea6.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisY.MinorGrid.Interval = 5D;
            chartArea6.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea6.AxisY.ScrollBar.LineColor = System.Drawing.Color.Silver;
            stripLine5.BackColor = System.Drawing.Color.LightSkyBlue;
            stripLine5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            stripLine5.BackSecondaryColor = System.Drawing.Color.White;
            stripLine5.Interval = 30D;
            stripLine5.IntervalOffset = 10D;
            stripLine5.StripWidth = 10D;
            chartArea6.AxisY.StripLines.Add(stripLine5);
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            stripLine6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stripLine6.IntervalOffset = -5D;
            stripLine6.StripWidth = 5D;
            chartArea6.AxisY2.StripLines.Add(stripLine6);
            chartArea6.BackSecondaryColor = System.Drawing.Color.White;
            chartArea6.BorderColor = System.Drawing.Color.Silver;
            chartArea6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.CursorX.IsUserEnabled = true;
            chartArea6.CursorX.IsUserSelectionEnabled = true;
            chartArea6.CursorY.IsUserEnabled = true;
            chartArea6.CursorY.IsUserSelectionEnabled = true;
            chartArea6.InnerPlotPosition.Auto = false;
            chartArea6.InnerPlotPosition.Height = 81.61977F;
            chartArea6.InnerPlotPosition.Width = 98F;
            chartArea6.InnerPlotPosition.X = 2F;
            chartArea6.InnerPlotPosition.Y = 5.30303F;
            chartArea6.IsSameFontSizeForAllAxes = true;
            chartArea6.Name = "ChartArea1_cloud";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 99F;
            chartArea6.Position.Width = 99F;
            chartArea6.Position.X = 1F;
            chartArea6.Position.Y = 1F;
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.Location = new System.Drawing.Point(64, 0);
            this.chart2.Margin = new System.Windows.Forms.Padding(0);
            this.chart2.Name = "chart2";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1_cloud";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Name = "CloudIndex";
            series13.ToolTip = "Cloud index (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#M" +
    "IN{F1} max:#MAX{F1} avg:#AVG{F1}";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart2.Series.Add(series13);
            this.chart2.Size = new System.Drawing.Size(700, 78);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "CloudSensor";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Weather Station";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Weather Station";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_open,
            this.toolStripSeparator1,
            this.toolStripMenuItem_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 54);
            // 
            // toolStripMenuItem_open
            // 
            this.toolStripMenuItem_open.Name = "toolStripMenuItem_open";
            this.toolStripMenuItem_open.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_open.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_exit.Text = "Exit";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(768, 832);
            this.Controls.Add(this.pannelMinimum);
            this.Controls.Add(this.pannelMaximum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 940);
            this.MinimumSize = new System.Drawing.Size(702, 740);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Staion";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
            this.groupBox10.PerformLayout();
            this.pannelMaximum.ResumeLayout(false);
            this.panelDebug.ResumeLayout(false);
            this.panelDebug.PerformLayout();
            this.pannelMinimum.ResumeLayout(false);
            this.pannelMinimum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFldBTemp;
        private System.Windows.Forms.TextBox txtFldPress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFldHum1;
        private System.Windows.Forms.TextBox txtFldDTemp1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFldHum2;
        private System.Windows.Forms.TextBox txtFldDTemp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFldIllum;
        private System.Windows.Forms.TextBox txtFldLumRes;
        private System.Windows.Forms.TextBox txtFldIllumRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtFldObj;
        private System.Windows.Forms.TextBox txtFldATemp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnLogWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFldWet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtFldTemp1;
        private System.Windows.Forms.TextBox txtFldTemp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFldLumWTime;
        private System.Windows.Forms.TextBox txtFldLumSen;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtFldRGC;
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
        public System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.Button btnSimulate;
        public System.Windows.Forms.Timer timer_debug_changetext;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnRelay;
        private System.Windows.Forms.Timer timer_debug_portread;
        private System.Windows.Forms.TextBox txtCSNeedHeating;
        private System.Windows.Forms.TextBox txtSinceHeatingOn;
        private System.Windows.Forms.TextBox txtSinceHeatingOff;
        private System.Windows.Forms.TextBox txtRGCLastMin;
        private System.Windows.Forms.TextBox txtWetLastMin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtRainLastMinute;
        private System.Windows.Forms.TextBox txtArdSetTD;
        private System.Windows.Forms.TextBox txtArdSetWT;
        private System.Windows.Forms.TextBox txtArdSetRT;
        private System.Windows.Forms.Button btnQueryArduinoSettings;
        private System.Windows.Forms.TextBox txtFldRGCCumulative;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Panel pannelMaximum;
        private System.Windows.Forms.Panel pannelMinimum;
        private System.Windows.Forms.Button btnIndCloud;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnIndRelay;
        private System.Windows.Forms.Button btnIndRain;
        private System.Windows.Forms.Button btnStart_min;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtMinRainIdx;
        private System.Windows.Forms.TextBox txtMinCloudIdx;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelDebug;
        private System.Windows.Forms.TextBox txt20min;
        private System.Windows.Forms.TextBox txt15min;
        private System.Windows.Forms.TextBox txt10min;
        private System.Windows.Forms.TextBox txt5min;
        private System.Windows.Forms.TextBox txt0min;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
    }
}

