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

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        // The main control for communicating through the RS-232 port
        private SerialPort comport = new SerialPort();

        
        public Form1()
        {
            InitializeComponent();

            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string[] portnames = SerialPort.GetPortNames();
            string st="";
            foreach (string curport in portnames)
            {
                st+= curport + Environment.NewLine ;
            }
            outText.Text = st;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool error = false;

            // If the port is open, close it.
            if (comport.IsOpen)
            {
                comport.Close();
                btnStart.Text = "Start";
            }
            else
            {
                // Set the port's settings
                comport.BaudRate = int.Parse("9600");
                comport.DataBits = int.Parse("8");
                comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                comport.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                comport.PortName = txtComName.Text;
                comport.DtrEnable = true; //to reset Arduino on connect
                try
                {
                    // Open the port
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else { btnStart.Text = "Stop"; }
            }


        }



        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!comport.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Read all the data waiting in the buffer
            string data = comport.ReadExisting();

            outText.Text += data;
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }


    }
}
