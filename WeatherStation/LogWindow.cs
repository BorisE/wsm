using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WeatherStation
{
    public partial class LogWindow : Form
    {
        private MainForm ParentMainForm;

        public LogWindow(MainForm MF)
        {
            InitializeComponent();
            ParentMainForm = MF;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //outText.Text += Hardware.SerialBuffer;

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void LogWindow_Load(object sender, EventArgs e)
        {
            Status1.Text = ParentMainForm.Hardware.PortName;
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }

}
