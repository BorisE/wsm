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


/* ************************************************************************** 
 * Auto heating
 * 
 * 
 ****************************************************************************/
        bool prevWetSesorIsWet_state = false;

        public void UpdateAutoHeating()
        {
            chkCloudSensorNeedHeatingFlag.Checked = ParentMainForm.Hardware.CloudSensorNeedHeatingFlag;
                chkCSNeedsHeating_CSIntervalMet.Checked = ParentMainForm.Hardware.CSNeedsHeating_CSIntervalMet;
                chkCSNeedsHeating_CSDecreasingTempMet.Checked = ParentMainForm.Hardware.CSNeedsHeating_CSDecreasingTempMet;
            chkCSNeedsHeating_SinceLastHeatingMet.Checked = ParentMainForm.Hardware.CSNeedsHeating_SinceLastHeatingMet;
            chkCSNeedsHeating_RelayOffNow.Checked = ParentMainForm.Hardware.CSNeedsHeating_RelayOffNow;
            chkCSNeedsHeating_HumidityMet.Checked = ParentMainForm.Hardware.CSNeedsHeating_HumidityMet;
            chkCSNeedsHeating_NotRainingMet.Checked = ParentMainForm.Hardware.CSNeedsHeating_NotRainingMet;
            chkCSNeedsHeating_DarknessMet.Checked = ParentMainForm.Hardware.CSNeedsHeating_DarknessMet;


            try { txt0min.Text = Convert.ToString(Math.Round(ParentMainForm.Hardware.SkyIndex5min[0], 1)); }
            catch { }
            try { txt5min.Text = Convert.ToString(Math.Round(ParentMainForm.Hardware.SkyIndex5min[1], 1)); }
            catch { }
            try { txt10min.Text = Convert.ToString(Math.Round(ParentMainForm.Hardware.SkyIndex5min[2], 1)); }
            catch { }
            try { txt15min.Text = Convert.ToString(Math.Round(ParentMainForm.Hardware.SkyIndex5min[3], 1)); }
            catch { }
            try { txt20min.Text = Convert.ToString(Math.Round(ParentMainForm.Hardware.SkyIndex5min[4], 1)); }
            catch { }


            if (ParentMainForm.Hardware.WetVal <= Convert.ToInt32(ParentMainForm.Hardware.ArduinoSettings["WT"].Value))
            {
                chkWetSesorIsWet.Checked = true;
                if (!prevWetSesorIsWet_state)
                {
                    txtAutoheatingLog.AppendText(DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy") + " Switched on for WetSensor reason" + Environment.NewLine);
                }
                prevWetSesorIsWet_state = true;
            }
            else
            {
                prevWetSesorIsWet_state = false;
            }

            if (chkCloudSensorNeedHeatingFlag.Checked && chkCSNeedsHeating_SinceLastHeatingMet.Checked && chkCSNeedsHeating_RelayOffNow.Checked
                && chkCSNeedsHeating_HumidityMet.Checked && chkCSNeedsHeating_NotRainingMet.Checked && chkCSNeedsHeating_DarknessMet.Checked)
            {
                txtAutoheatingLog.AppendText(DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy")+" Switched on for CloudSensor reason"+Environment.NewLine);
            }
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
