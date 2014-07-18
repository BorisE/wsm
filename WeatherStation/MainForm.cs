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
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Threading;

namespace WeatherStation
{
 
    public partial class MainForm : Form
    {
        /// <summary>
        /// Link to WeatherStationSerial class object which is used to communicate with Arduino
        /// </summary>
        public WeatherStationSerial Hardware;

        /// <summary>
        /// Link to LogForm, to where all communications with Arduino module is output
        /// </summary>
        private LogWindow LogForm;

        //For graphs
        private DateTime curX;
        private int maxNumberOfPointsInChart = 200;

        private About aboutForm;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LogForm = new LogWindow(this);
            Hardware = new WeatherStationSerial();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //INIT GRAPHICS
            //chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";

            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";

            chart3.Series[0].XValueType = ChartValueType.DateTime;
            chart3.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            // Create cursor object
            System.Windows.Forms.DataVisualization.Charting.Cursor cursor = null;
            // Set cursor object
            cursor = chart1.ChartAreas[0].CursorY;
            // Set cursor properties 
            cursor.LineWidth = 2;
            cursor.LineDashStyle = ChartDashStyle.DashDot;
            cursor.LineColor = Color.Red;
            cursor.SelectionColor = Color.Yellow;
            // Set cursor selection color of X axis cursor
            chart1.ChartAreas[0].CursorX.SelectionColor = Color.Yellow;

            // TEST COMMAND LINE PARAMETERS
            string[] args = Environment.GetCommandLineArgs();

            for (int i = 1; i < args.Length; i++)
            {
                if (args[i].IndexOf("start") >= 0)
                {
                    //AUTOSTART MONITORING
                    btnStart.PerformClick();
                } else if (args[i].ToLower().Substring(0,3) == "com")
                {
                    //RESET COM PORT NAME
                    Hardware.PortName = args[i].ToLower();
                }
            } 
        }

        /// <summary>
        /// Start monitoring
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // If the port is open, close it.
            if (Hardware.IsOpen())
            {
                if (!Hardware.stopReadData())
                {
                    Logging.Log("Could not close the COM port");
                    LogForm.txtLog.Text += "Could not close the COM port\r\n";
                    MessageBox.Show(this, "Could not close the COM port", "COM Port couldn't be closed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    btnStart.Text = "Start";
                    timer1.Enabled = false;
                    Logging.Log("Monitoring was stopped");
                    LogForm.txtLog.Text += "Monitoring was stopped\r\n";
                    Logging.CloseLogFile();
                }
            }
            else
            {
                if (!Hardware.startReadData())
                {
                    Logging.Log("Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.");
                    LogForm.txtLog.Text += "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.\r\n";
                    MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else 
                {
                    timer1.Enabled = true;
                    Logging.Log("Monitoring was started");
                    LogForm.txtLog.Text += "Monitoring was started\r\n";
                    btnStart.Text = "Stop";
                }

            }
        }

        private void timer_debug_Tick(object sender, EventArgs e)
        {

            Random rand = new Random();

            Hardware.SerialBuffer = @"Weather station v0.6
[!ver:0.6]
IP: 192.168.1.178

=== New cycle ===
[!!be:1]
Object/Ambient: -4.5/22.1
[!Obj:" + String.Format("{0:N1}", -4.5 + rand.NextDouble() * 5) + @"]
[!Amb:22.1]

Temperature: 26.60C
Pressure: 100462 Pa   753.53 mmHg  
Standard Atmosphere: 0.9915
Altitude: 72.09 M
[!BTe:26.6]
[!Pre:753.53]

Humidity: 1.00 %	
Temperature: 26.40 C  
Dew point: -34.05 /fast: -33.96 *C
[!DT1:26.4]
[!DH1:" + String.Format("{0:N0}", 0 + rand.NextDouble() * 10) + @"]

Humidity(2): 42.80 %	
Temperature(2): 24.80 C  
Dew point: 11.32 /fast: 11.29 *C
[!DT2:24.8]
[!DH2:42.8]

Illuminance: 1454.8[0.5x] r:17 s:254 wt:572
[!Lum:1454.8]
[!Lur:17]
[!Lus:254]
[!Luw:572]

Inside t: 23.00C Outside t: 39.25C 
[!Te1:" +String.Format("{0:N1}",23.0+rand.NextDouble()*5)+@"]
[!Te2:39.2]

Wetsensor analog value: 1022     digital value: 1
[!Wet:" + String.Format("{0:F0}", 1022 - rand.NextDouble() * 10) + @"]
[!!en:1]
waiting 10000
";
            timer1_Tick(sender,e);
        }

        
        /// <summary>
        /// Timer ticking - main function in the form interface; used to check the buffer every second
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Parse data
            Hardware.ParseData(Hardware.SerialBuffer);

            //Logging.Log(Hardware.SerialBuffer);

            //output buffer to Log window
            LogForm.txtLog.Text += Hardware.SerialBuffer;
            
            //clear current buffer
            Hardware.SerialBuffer = "";

            //Refresh form values
            RefreshFormFields();

            //Refresh graph
            refreshGraphs();
        }


        /// <summary>
        /// Show preferences form
        /// </summary>
        private void btnPreferences_Click(object sender, EventArgs e)
        {
            PreferencesForm PrefForm = new PreferencesForm(this);
            PrefForm.ShowDialog();
            PrefForm.Close();
        }


        private void btnLogWindow_Click(object sender, EventArgs e)
        {
            LogForm.Show();
        }

        private void RefreshFormFields()
        {
            txtObj.Text = Convert.ToString(Hardware.ObjTemp);
            txtATemp.Text = Convert.ToString(Hardware.ATemp);

            txtCloudIndex1.Text = Convert.ToString(Hardware.CloudIdx);
            txtCloudIndex2.Text = Convert.ToString(Math.Round(Hardware.CloudIdxCorr,2));

            txtBTemp.Text = Convert.ToString(Hardware.BTemp);
            txtPress.Text = Convert.ToString(Hardware.Press);

            txtHum1.Text = Convert.ToString(Hardware.Hum1);
            txtDTemp1.Text = Convert.ToString(Hardware.DTemp1);
            
            txtHum2.Text = Convert.ToString(Hardware.Hum2);
            txtDTemp2.Text = Convert.ToString(Hardware.DTemp2);

            txtIllum.Text = Convert.ToString(Hardware.Illum);
            txtLumRes.Text = Convert.ToString(Hardware.LumRes);
            txtLumSen.Text = Convert.ToString(Hardware.LumSens);
            txtLumWTime.Text = Convert.ToString(Hardware.LumWTime);

            switch (Hardware.LumRes)
            {
                case 16: txtIllumRes.Text = "1x"; break;
                case 17: txtIllumRes.Text = "0.5x"; break;
                case 19: txtIllumRes.Text = "4x"; break;
            }

            txtWet.Text = Convert.ToString(Hardware.Wet);

            txtTemp1.Text = Convert.ToString(Hardware.Temp1);
            txtTemp2.Text = Convert.ToString(Hardware.Temp2);
        
        }

        private void refreshGraphs()
        {
            curX = DateTime.Now;
            //Graph1
            if (Hardware.CheckData(Convert.ToDouble(txtObj.Text), DataCheckTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), DataCheckTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtCloudIndex1.Text), DataCheckTypeEnum.Temp)) { 
                addGraphicsPoint(chart1, 0, curX, Convert.ToDouble(txtCloudIndex1.Text)); 
            }
            if (Hardware.CheckData(Convert.ToDouble(txtObj.Text), DataCheckTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), DataCheckTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtCloudIndex2.Text), DataCheckTypeEnum.Temp))
            {
                addGraphicsPoint(chart1, 1, curX, Convert.ToDouble(txtCloudIndex2.Text));
            }
            if (Hardware.CheckData(Convert.ToDouble(txtObj.Text), DataCheckTypeEnum.Temp) && Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), DataCheckTypeEnum.Temp))
            { 
                addGraphicsPoint(chart1, 2, curX, Convert.ToDouble(txtObj.Text)); 
            }

            //Graph2
            if (Hardware.CheckData(Convert.ToDouble(txtTemp1.Text), DataCheckTypeEnum.Temp)) { addGraphicsPoint(chart2, 0, curX, Convert.ToDouble(txtTemp1.Text)); }
            if (Hardware.CheckData(Convert.ToDouble(txtTemp2.Text), DataCheckTypeEnum.Temp)) { addGraphicsPoint(chart2, 1, curX, Convert.ToDouble(txtTemp2.Text)); }

            //Graph3
            if (Hardware.CheckData(Convert.ToDouble(txtWet.Text), DataCheckTypeEnum.Wet)) { addGraphicsPoint(chart3, 0, curX, (1024 - Convert.ToInt16(txtWet.Text))); }
            if (Hardware.CheckData(Convert.ToDouble(txtHum1.Text), DataCheckTypeEnum.Hum)) { addGraphicsPoint(chart3, 1, curX, Convert.ToDouble(txtHum1.Text)); }

            //Graph4
            if (Hardware.CheckData(Convert.ToDouble(txtIllum.Text), DataCheckTypeEnum.Illum))
            {
                addGraphicsPoint(chart4, 0, curX, Convert.ToDouble(txtIllum.Text));
            }

        }


        private void addGraphicsPoint(Chart CurChart, int seriesNum, DateTime XVal, double YVal)
        {

            //curX=DateTime.Now;
            CurChart.Series[seriesNum].Points.AddXY(XVal, YVal);

            // Adjust Y & X axis scale
            CurChart.ResetAutoValues();

            /*
            // Keep a constant number of points by removing them from the left
            while (chart1.Series[0].Points.Count > maxNumberOfPointsInChart)
            {
                // Remove data points on the left side
                while (chart1.Series[0].Points.Count > maxNumberOfPointsInChart)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }

                // Adjust X axis scale
                chart1.ChartAreas[0].AxisX.Minimum = curX - maxNumberOfPointsInChart;
                chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Minimum + maxNumberOfPointsInChart;
            }
            */

            // Invalidate chart
            CurChart.Invalidate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(this, "Exit", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if (!Hardware.stopReadData())
            {
                Logging.Log("Could not close the COM port");
                LogForm.txtLog.Text += "Could not close the COM port\r\n";
            }
            Logging.Log("Application closed");
            Logging.CloseLogFile();
            LogForm.txtLog.Text += "Application closed\r\n";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.ShowDialog();
        }


    }
}
