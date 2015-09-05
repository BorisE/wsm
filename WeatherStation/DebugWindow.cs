using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class DebugWindow : Form
    {
        MainForm ParentMainForm;

        public DebugWindow(MainForm MF)
        {
            ParentMainForm = MF;
            InitializeComponent();
        }

        public void UpdateAutoCalibrate()
        {
            txtLastMinVal.ForeColor = Color.Black;
            txtLastMinVal.Text = ParentMainForm.Hardware.LastMinValue.ToString();
            //minVal
            txtPassedFromMinSet.Text = Convert.ToInt32(ParentMainForm.Hardware.PassedFromMinSet.TotalSeconds).ToString();
            
            txtcurVal.Text = ParentMainForm.Hardware.curVal.ToString();

            txtWS_MinValue_HitCount.ForeColor = Color.Black;
            txtWS_MinValue_HitCount.Text = ParentMainForm.Hardware.WS_MinValue_HitCount.ToString();

            txtPassedFromMinHit.Text = Convert.ToInt32(ParentMainForm.Hardware.PassedFromMinHit.TotalSeconds).ToString();

            txtautoCalWS_maxPassedFromHit.Text = ParentMainForm.Hardware.autoCalWS_maxPassedFromHit.ToString();
            chkMaxPassedFromHitGreaterFlag.Checked = (ParentMainForm.Hardware.PassedFromMinHit.TotalSeconds > ParentMainForm.Hardware.autoCalWS_maxPassedFromHit);
            
            
            //WS_MinValue_LastHit
            txtWS_HitCount_Threshold.Text = ParentMainForm.Hardware.WS_HitCount_Threshold.ToString();
            chkHitCount_Greater.Checked=(ParentMainForm.Hardware.WS_MinValue_HitCount > ParentMainForm.Hardware.WS_HitCount_Threshold);

            txtWS_Calibraion_ZeroSpeedAnalogValue.ForeColor = Color.Black;
            txtWS_Calibraion_ZeroSpeedAnalogValue.Text = ParentMainForm.Hardware.WS_Calibraion_ZeroSpeedAnalogValue.ToString();
            
        }

        private void TXT_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.ForeColor = Color.Red;
        }

        private void txtWS_Calibraion_ZeroSpeedAnalogValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.ForeColor = Color.Red;

            txtAutoCallibrationLog.AppendText(DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy")+" set to " + txtBox.Text+Environment.NewLine);

        }


        private void DebugWindow_Load(object sender, EventArgs e)
        {

        }

        private void DebugWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

    }
}
