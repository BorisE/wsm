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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine21 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine22 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine23 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine24 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series61 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series62 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series63 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series64 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series66 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series67 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series68 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series69 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series70 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series71 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series72 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title26 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title27 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title28 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title29 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title30 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.txt0min = new System.Windows.Forms.TextBox();
            this.txt5min = new System.Windows.Forms.TextBox();
            this.txt10min = new System.Windows.Forms.TextBox();
            this.txt15min = new System.Windows.Forms.TextBox();
            this.txt20min = new System.Windows.Forms.TextBox();
            this.txtArdSetTD = new System.Windows.Forms.TextBox();
            this.txtArdSetWT = new System.Windows.Forms.TextBox();
            this.txtArdSetRT = new System.Windows.Forms.TextBox();
            this.btnQueryArduinoSettings = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            // timer_main
            // 
            this.timer_main.Interval = 10000;
            this.timer_main.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnPreferences.Text = "Preferences";
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
            this.txtRGCLastMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtWetLastMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.groupBox7.Location = new System.Drawing.Point(2, 623);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(136, 74);
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
            this.btnAbout.Location = new System.Drawing.Point(687, 9);
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
            chartArea26.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea26.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea26.AxisX.LabelAutoFitMinFontSize = 7;
            chartArea26.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea26.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea26.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea26.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea26.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea26.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea26.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea26.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea26.AxisY.MajorGrid.Interval = 0D;
            chartArea26.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea26.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea26.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea26.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea26.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea26.AxisY.ScrollBar.LineColor = System.Drawing.Color.Silver;
            stripLine21.BackColor = System.Drawing.Color.White;
            stripLine21.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            stripLine21.BackSecondaryColor = System.Drawing.Color.LightSkyBlue;
            stripLine21.StripWidth = 12D;
            chartArea26.AxisY.StripLines.Add(stripLine21);
            chartArea26.AxisY2.MajorGrid.Enabled = false;
            stripLine22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stripLine22.IntervalOffset = -5D;
            stripLine22.StripWidth = 5D;
            chartArea26.AxisY2.StripLines.Add(stripLine22);
            chartArea26.BackSecondaryColor = System.Drawing.Color.White;
            chartArea26.BorderColor = System.Drawing.Color.Silver;
            chartArea26.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea26.CursorX.IsUserEnabled = true;
            chartArea26.CursorX.IsUserSelectionEnabled = true;
            chartArea26.CursorY.IsUserEnabled = true;
            chartArea26.CursorY.IsUserSelectionEnabled = true;
            chartArea26.InnerPlotPosition.Auto = false;
            chartArea26.InnerPlotPosition.Height = 80F;
            chartArea26.InnerPlotPosition.Width = 91.87197F;
            chartArea26.InnerPlotPosition.X = 6.520894F;
            chartArea26.InnerPlotPosition.Y = 7F;
            chartArea26.IsSameFontSizeForAllAxes = true;
            chartArea26.Name = "ChartArea1_cloud";
            chartArea26.Position.Auto = false;
            chartArea26.Position.Height = 20F;
            chartArea26.Position.Width = 98F;
            chartArea27.AlignWithChartArea = "ChartArea1_cloud";
            chartArea27.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea27.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea27.AxisX.LabelAutoFitMinFontSize = 7;
            chartArea27.AxisX.LabelStyle.Enabled = false;
            chartArea27.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea27.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea27.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            stripLine23.IntervalOffset = 20D;
            stripLine23.StripWidth = 5D;
            chartArea27.AxisX.StripLines.Add(stripLine23);
            chartArea27.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea27.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea27.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea27.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea27.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea27.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            stripLine24.BackColor = System.Drawing.Color.LightSteelBlue;
            stripLine24.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            stripLine24.BackSecondaryColor = System.Drawing.Color.White;
            stripLine24.IntervalOffset = -5D;
            stripLine24.StripWidth = 5D;
            chartArea27.AxisY.StripLines.Add(stripLine24);
            chartArea27.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea27.BorderColor = System.Drawing.Color.Silver;
            chartArea27.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea27.CursorX.IsUserEnabled = true;
            chartArea27.CursorX.IsUserSelectionEnabled = true;
            chartArea27.CursorY.IsUserEnabled = true;
            chartArea27.CursorY.IsUserSelectionEnabled = true;
            chartArea27.InnerPlotPosition.Auto = false;
            chartArea27.InnerPlotPosition.Height = 88F;
            chartArea27.InnerPlotPosition.Width = 91.87197F;
            chartArea27.InnerPlotPosition.X = 6.520894F;
            chartArea27.InnerPlotPosition.Y = 7.875004F;
            chartArea27.Name = "ChartArea2_cloud2";
            chartArea27.Position.Auto = false;
            chartArea27.Position.Height = 20F;
            chartArea27.Position.Width = 98F;
            chartArea27.Position.X = 1F;
            chartArea27.Position.Y = 20F;
            chartArea28.AlignWithChartArea = "ChartArea1_cloud";
            chartArea28.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea28.AxisX.LabelStyle.Enabled = false;
            chartArea28.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea28.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea28.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea28.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea28.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea28.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea28.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea28.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea28.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea28.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea28.BackColor = System.Drawing.Color.White;
            chartArea28.BorderColor = System.Drawing.Color.Silver;
            chartArea28.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea28.CursorY.IsUserEnabled = true;
            chartArea28.CursorY.IsUserSelectionEnabled = true;
            chartArea28.InnerPlotPosition.Auto = false;
            chartArea28.InnerPlotPosition.Height = 88F;
            chartArea28.InnerPlotPosition.Width = 91.87197F;
            chartArea28.InnerPlotPosition.X = 6.520894F;
            chartArea28.InnerPlotPosition.Y = 7.875004F;
            chartArea28.Name = "ChartArea3_temp";
            chartArea28.Position.Auto = false;
            chartArea28.Position.Height = 20F;
            chartArea28.Position.Width = 98F;
            chartArea28.Position.X = 1F;
            chartArea28.Position.Y = 40F;
            chartArea29.AlignWithChartArea = "ChartArea1_cloud";
            chartArea29.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea29.AxisX.LabelStyle.Enabled = false;
            chartArea29.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea29.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea29.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea29.AxisX2.MajorGrid.Enabled = false;
            chartArea29.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea29.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea29.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea29.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea29.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea29.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea29.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea29.AxisY2.MajorGrid.Enabled = false;
            chartArea29.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea29.AxisY2.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea29.AxisY2.ScaleBreakStyle.CollapsibleSpaceThreshold = 20;
            chartArea29.AxisY2.ScaleBreakStyle.Enabled = true;
            chartArea29.AxisY2.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea29.BorderColor = System.Drawing.Color.Silver;
            chartArea29.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea29.CursorX.IsUserEnabled = true;
            chartArea29.CursorX.IsUserSelectionEnabled = true;
            chartArea29.CursorY.IsUserEnabled = true;
            chartArea29.CursorY.IsUserSelectionEnabled = true;
            chartArea29.InnerPlotPosition.Auto = false;
            chartArea29.InnerPlotPosition.Height = 88F;
            chartArea29.InnerPlotPosition.Width = 91.87197F;
            chartArea29.InnerPlotPosition.X = 6.520894F;
            chartArea29.InnerPlotPosition.Y = 7.875004F;
            chartArea29.IsSameFontSizeForAllAxes = true;
            chartArea29.Name = "ChartArea4_rain";
            chartArea29.Position.Auto = false;
            chartArea29.Position.Height = 20F;
            chartArea29.Position.Width = 98F;
            chartArea29.Position.X = 1F;
            chartArea29.Position.Y = 60F;
            chartArea30.AlignWithChartArea = "ChartArea1_cloud";
            chartArea30.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea30.AxisX.LabelStyle.Enabled = false;
            chartArea30.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea30.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea30.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea30.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea30.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea30.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea30.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea30.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea30.AxisY2.LabelStyle.Enabled = false;
            chartArea30.AxisY2.LineWidth = 0;
            chartArea30.AxisY2.MajorGrid.Enabled = false;
            chartArea30.AxisY2.MajorTickMark.Enabled = false;
            chartArea30.AxisY2.Maximum = 2D;
            chartArea30.AxisY2.Minimum = 0D;
            chartArea30.BorderColor = System.Drawing.Color.Silver;
            chartArea30.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea30.CursorY.IsUserEnabled = true;
            chartArea30.CursorY.IsUserSelectionEnabled = true;
            chartArea30.InnerPlotPosition.Auto = false;
            chartArea30.InnerPlotPosition.Height = 83F;
            chartArea30.InnerPlotPosition.Width = 91.87197F;
            chartArea30.InnerPlotPosition.X = 6.520894F;
            chartArea30.InnerPlotPosition.Y = 7.874985F;
            chartArea30.IsSameFontSizeForAllAxes = true;
            chartArea30.Name = "ChartArea5_illum";
            chartArea30.Position.Auto = false;
            chartArea30.Position.Height = 20F;
            chartArea30.Position.Width = 98F;
            chartArea30.Position.X = 1F;
            chartArea30.Position.Y = 80F;
            this.chart1.ChartAreas.Add(chartArea26);
            this.chart1.ChartAreas.Add(chartArea27);
            this.chart1.ChartAreas.Add(chartArea28);
            this.chart1.ChartAreas.Add(chartArea29);
            this.chart1.ChartAreas.Add(chartArea30);
            legend6.DockedToChartArea = "ChartArea5_illum";
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.IsDockedInsideChartArea = false;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(149, 126);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series61.BorderWidth = 3;
            series61.ChartArea = "ChartArea1_cloud";
            series61.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series61.Legend = "Legend1";
            series61.Name = "CloudIndex";
            series61.ToolTip = "Cloud index (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#M" +
    "IN{F1} max:#MAX{F1} avg:#AVG{F1}";
            series61.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series62.BorderWidth = 2;
            series62.ChartArea = "ChartArea2_cloud2";
            series62.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series62.Legend = "Legend1";
            series62.Name = "CloudIndex2";
            series62.ToolTip = "Cloud idx by AAG (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nm" +
    "in:#MIN{F1} max:#MAX{F1} avg:#AVG{F1}\\n\\n";
            series62.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series63.ChartArea = "ChartArea2_cloud2";
            series63.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series63.Legend = "Legend1";
            series63.Name = "SkyTemp";
            series63.ToolTip = "Sky temperature (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmi" +
    "n:#MIN{F1} max:#MAX{F1} avg:#AVG{F1}";
            series64.BorderWidth = 2;
            series64.ChartArea = "ChartArea3_temp";
            series64.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series64.Legend = "Legend1";
            series64.Name = "Temp1";
            series64.ToolTip = "Temp1 (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN{F1}" +
    " max:#MAX{F1} avg:#AVG{F1}\\n";
            series65.ChartArea = "ChartArea3_temp";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series65.Legend = "Legend1";
            series65.Name = "Temp2";
            series65.ToolTip = "Temp2 #VAL{F1} (at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN{F1}" +
    " max:#MAX{F1} avg:#AVG{F1}\\n";
            series66.ChartArea = "ChartArea3_temp";
            series66.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series66.Legend = "Legend1";
            series66.Name = "Temp3";
            series66.ToolTip = "Temp3 (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN{F1}" +
    " max:#MAX{F1} avg:#AVG{F1}\\n";
            series67.BorderWidth = 2;
            series67.ChartArea = "ChartArea4_rain";
            series67.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series67.Legend = "Legend1";
            series67.Name = "Wet";
            series67.ToolTip = "Rain index (#VAL{D} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\nmin:#MIN{" +
    "D} max:#MAX{D} avg:#AVG{D}\\n";
            series68.BorderWidth = 3;
            series68.ChartArea = "ChartArea4_rain";
            series68.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series68.IsValueShownAsLabel = true;
            series68.Label = "#VAL";
            series68.Legend = "Legend1";
            series68.Name = "RGC";
            series68.ToolTip = "Rain gauge counter (#VAL{D} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\nm" +
    "in:#MIN{D} max:#MAX{D} avg:#AVG{D}\\n";
            series68.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series69.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series69.ChartArea = "ChartArea4_rain";
            series69.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series69.Legend = "Legend1";
            series69.Name = "Hum";
            series69.ToolTip = "Humidity (#VAL{D}% at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D}%\\nmin:#MIN{D" +
    "}% max:#MAX{D}% avg:#AVG{D}%\\n";
            series69.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series70.ChartArea = "ChartArea5_illum";
            series70.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series70.Legend = "Legend1";
            series70.Name = "Illum";
            series70.ToolTip = "Illuminance (#VAL{D}lx at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{D} \\nmin:#M" +
    "IN{D} max:#MAX{D} avg:#AVG{D}\\n";
            series71.ChartArea = "ChartArea5_illum";
            series71.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series71.Legend = "Legend1";
            series71.Name = "RL1";
            series71.ToolTip = "Relay (#VAL{D}% at #VALX{dd.MM.yyyy HH:mm})\\n";
            series71.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series72.ChartArea = "ChartArea3_temp";
            series72.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series72.Legend = "Legend1";
            series72.Name = "ATemp";
            series72.ToolTip = "Case temp (#VAL{F1} at #VALX{dd.MM.yyyy HH:mm})\\nlast value: #LAST{F1} \\nmin:#MIN" +
    "{F1} max:#MAX{F1} avg:#AVG{F1}\\n";
            this.chart1.Series.Add(series61);
            this.chart1.Series.Add(series62);
            this.chart1.Series.Add(series63);
            this.chart1.Series.Add(series64);
            this.chart1.Series.Add(series65);
            this.chart1.Series.Add(series66);
            this.chart1.Series.Add(series67);
            this.chart1.Series.Add(series68);
            this.chart1.Series.Add(series69);
            this.chart1.Series.Add(series70);
            this.chart1.Series.Add(series71);
            this.chart1.Series.Add(series72);
            this.chart1.Size = new System.Drawing.Size(618, 577);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "CloudSensor";
            title26.DockedToChartArea = "ChartArea1_cloud";
            title26.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title26.ForeColor = System.Drawing.Color.LightGray;
            title26.Name = "Title1";
            title26.Text = "Cloud Index (usual)";
            title27.DockedToChartArea = "ChartArea2_cloud2";
            title27.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title27.ForeColor = System.Drawing.Color.LightGray;
            title27.Name = "Title2";
            title27.Text = "Cloud Index (by AAG)";
            title28.DockedToChartArea = "ChartArea3_temp";
            title28.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title28.ForeColor = System.Drawing.Color.LightGray;
            title28.Name = "Title3";
            title28.Text = "Temperature";
            title29.DockedToChartArea = "ChartArea4_rain";
            title29.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title29.ForeColor = System.Drawing.Color.LightGray;
            title29.Name = "Title4";
            title29.Text = "Rain & Wetness";
            title30.DockedToChartArea = "ChartArea5_illum";
            title30.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title30.ForeColor = System.Drawing.Color.LightGray;
            title30.Name = "Title5";
            title30.Text = "Illumination";
            this.chart1.Titles.Add(title26);
            this.chart1.Titles.Add(title27);
            this.chart1.Titles.Add(title28);
            this.chart1.Titles.Add(title29);
            this.chart1.Titles.Add(title30);
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
            this.btnSimulate.Location = new System.Drawing.Point(581, 9);
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
            this.groupBox9.Location = new System.Drawing.Point(600, 41);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(166, 73);
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
            this.txtCSNeedHeating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCSNeedHeating.Name = "txtCSNeedHeating";
            this.txtCSNeedHeating.ReadOnly = true;
            this.txtCSNeedHeating.Size = new System.Drawing.Size(31, 20);
            this.txtCSNeedHeating.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.txtCSNeedHeating, resources.GetString("txtCSNeedHeating.ToolTip"));
            // 
            // btnRelay
            // 
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
            this.txtSinceHeatingOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtRainLastMinute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtSinceHeatingOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // txt0min
            // 
            this.txt0min.Location = new System.Drawing.Point(254, 11);
            this.txt0min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt0min.Name = "txt0min";
            this.txt0min.ReadOnly = true;
            this.txt0min.Size = new System.Drawing.Size(43, 20);
            this.txt0min.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.txt0min, resources.GetString("txt0min.ToolTip"));
            // 
            // txt5min
            // 
            this.txt5min.Location = new System.Drawing.Point(301, 11);
            this.txt5min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt5min.Name = "txt5min";
            this.txt5min.ReadOnly = true;
            this.txt5min.Size = new System.Drawing.Size(43, 20);
            this.txt5min.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.txt5min, resources.GetString("txt5min.ToolTip"));
            // 
            // txt10min
            // 
            this.txt10min.Location = new System.Drawing.Point(347, 11);
            this.txt10min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt10min.Name = "txt10min";
            this.txt10min.ReadOnly = true;
            this.txt10min.Size = new System.Drawing.Size(43, 20);
            this.txt10min.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.txt10min, resources.GetString("txt10min.ToolTip"));
            // 
            // txt15min
            // 
            this.txt15min.Location = new System.Drawing.Point(394, 11);
            this.txt15min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt15min.Name = "txt15min";
            this.txt15min.ReadOnly = true;
            this.txt15min.Size = new System.Drawing.Size(43, 20);
            this.txt15min.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.txt15min, resources.GetString("txt15min.ToolTip"));
            // 
            // txt20min
            // 
            this.txt20min.Location = new System.Drawing.Point(440, 11);
            this.txt20min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt20min.Name = "txt20min";
            this.txt20min.ReadOnly = true;
            this.txt20min.Size = new System.Drawing.Size(43, 20);
            this.txt20min.TabIndex = 7;
            this.mainToolTip.SetToolTip(this.txt20min, resources.GetString("txt20min.ToolTip"));
            // 
            // txtArdSetTD
            // 
            this.txtArdSetTD.Location = new System.Drawing.Point(487, -2);
            this.txtArdSetTD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArdSetTD.Name = "txtArdSetTD";
            this.txtArdSetTD.ReadOnly = true;
            this.txtArdSetTD.Size = new System.Drawing.Size(36, 20);
            this.txtArdSetTD.TabIndex = 8;
            this.mainToolTip.SetToolTip(this.txtArdSetTD, "Actual maximum temperature delta setting as it was read from Arduino ");
            // 
            // txtArdSetWT
            // 
            this.txtArdSetWT.Location = new System.Drawing.Point(523, -2);
            this.txtArdSetWT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArdSetWT.Name = "txtArdSetWT";
            this.txtArdSetWT.ReadOnly = true;
            this.txtArdSetWT.Size = new System.Drawing.Size(36, 20);
            this.txtArdSetWT.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.txtArdSetWT, "Actual heating starting wet threshold setting as it was read from Arduino ");
            // 
            // txtArdSetRT
            // 
            this.txtArdSetRT.Location = new System.Drawing.Point(487, 17);
            this.txtArdSetRT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArdSetRT.Name = "txtArdSetRT";
            this.txtArdSetRT.ReadOnly = true;
            this.txtArdSetRT.Size = new System.Drawing.Size(47, 20);
            this.txtArdSetRT.TabIndex = 10;
            this.mainToolTip.SetToolTip(this.txtArdSetRT, "Actual maximum heating cycle duration setting as it was read from Arduino \r\n");
            // 
            // btnQueryArduinoSettings
            // 
            this.btnQueryArduinoSettings.Location = new System.Drawing.Point(537, 16);
            this.btnQueryArduinoSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQueryArduinoSettings.Name = "btnQueryArduinoSettings";
            this.btnQueryArduinoSettings.Size = new System.Drawing.Size(21, 20);
            this.btnQueryArduinoSettings.TabIndex = 11;
            this.btnQueryArduinoSettings.Text = "?";
            this.mainToolTip.SetToolTip(this.btnQueryArduinoSettings, "Query actual settings from Arduino ");
            this.btnQueryArduinoSettings.UseVisualStyleBackColor = true;
            this.btnQueryArduinoSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 708);
            this.Controls.Add(this.btnQueryArduinoSettings);
            this.Controls.Add(this.txtArdSetRT);
            this.Controls.Add(this.txtArdSetWT);
            this.Controls.Add(this.txtArdSetTD);
            this.Controls.Add(this.txt20min);
            this.Controls.Add(this.txt15min);
            this.Controls.Add(this.txt10min);
            this.Controls.Add(this.txt5min);
            this.Controls.Add(this.txt0min);
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
            this.MaximumSize = new System.Drawing.Size(1920, 746);
            this.MinimumSize = new System.Drawing.Size(702, 746);
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
            this.groupBox10.PerformLayout();
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
        private System.Windows.Forms.TextBox txt0min;
        private System.Windows.Forms.TextBox txt5min;
        private System.Windows.Forms.TextBox txt10min;
        private System.Windows.Forms.TextBox txt15min;
        private System.Windows.Forms.TextBox txt20min;
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
    }
}

