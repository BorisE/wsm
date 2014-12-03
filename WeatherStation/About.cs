using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

namespace WeatherStation
{
    public partial class About : Form
    {
        string HardwareVerExt = "";
        string HardwareVerDateExt = "";

        public About(string _HardwareVer, string _HardwareVerDate)
        {
            HardwareVerExt = _HardwareVer;
            HardwareVerDateExt = _HardwareVerDate;
            InitializeComponent();
        }
        
        private void About_Load(object sender, EventArgs e)
        {

            // Get the version of the executing assembly (that is, this assembly).
            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            lblVersion.Text += "Version " + ver.Major.ToString() + "." + ver.Minor.ToString() + "." + ver.Build.ToString() + " rev "+ver.Revision.ToString();
            //MessageBox.Show("Application " + assemName.Name + ", Version " + ver.ToString());
            lblVersion.Text += Environment.NewLine+"Compile time: "+RetrieveLinkerTimestamp();

            // Put Arduino sketch version
            if (HardwareVerExt == "") HardwareVerExt = "n/a";
            if (HardwareVerDateExt != "") HardwareVerDateExt = " from " + HardwareVerDateExt;
            lblVersion.Text += Environment.NewLine + "Hardware sketch version: " + HardwareVerExt + HardwareVerDateExt;
            

            // Add link
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.astromania.info/";
            linkAstromania.Links.Add(link);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

        }


        private DateTime RetrieveLinkerTimestamp()
        {
            string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;
            byte[] b = new byte[2048];
            System.IO.Stream s = null;

            try
            {
                s = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                s.Read(b, 0, 2048);
            }
            finally
            {
                if (s != null)
                {
                    s.Close();
                }
            }

            int i = System.BitConverter.ToInt32(b, c_PeHeaderOffset);
            int secondsSince1970 = System.BitConverter.ToInt32(b, i + c_LinkerTimestampOffset);
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
            dt = dt.AddSeconds(secondsSince1970);
            dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);
            return dt;
        }


    }
}
