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
        private bool AutoScrollLogFlag = true;
        private int caretPos=0;

        public LogWindow(MainForm MF)
        {
            InitializeComponent();
            ParentMainForm = MF;
        }

        public void AppendLogText(string LogText)
        {
            caretPos = txtLog.SelectionStart; 
            txtLog.AppendText(LogText);
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

        /// <summary>
        /// Clear log text handler
        /// </summary>
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        /// <summary>
        /// Autoscroll on/off handler
        /// </summary>
        private void autosctollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem AutoScrollItem = sender as ToolStripDropDownItem;
            if (AutoScrollItem.Text == "Autoscroll off")
            {
                AutoScrollLogFlag = true;
                AutoScrollItem.Text = "Autoscroll on";
            }
            else
            {
                AutoScrollLogFlag = false;
                AutoScrollItem.Text = "Autoscroll off";
            }

        }

        private void txtLog_TextChanged_1(object sender, EventArgs e)
        {
            RichTextBox ScrollBox = (RichTextBox)sender;
            /*
            ScrollBox.Find("Switching relay OFF...", RichTextBoxFinds.Reverse); //Find the text provided
            ScrollBox.SelectionColor = Color.Red; //Set the selected text color
            ScrollBox.Find("Switching relay ON...", RichTextBoxFinds.Reverse); //Find the text provided
            ScrollBox.SelectionColor = Color.Green; //Set the selected text color
            ScrollBox.Find("Temp is too high. Switching relay OFF...", RichTextBoxFinds.Reverse); //Find the text provided
            ScrollBox.SelectionColor = Color.Red; //Set the selected text color
            */
            if (AutoScrollLogFlag)
            {
                ScrollBox.SelectionStart = ScrollBox.Text.Length;
                ScrollBox.ScrollToCaret();
            }
            else
            {
                ScrollBox.SelectionStart=caretPos;
                ScrollBox.ScrollToCaret();
            }
        }
    }

}
