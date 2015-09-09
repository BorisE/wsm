using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WeatherStation
{
    static class WebServices
    {

        public static bool WebDataFlag = true;
        public static string siteipURL = "http://astromania.info/checkconn/putweatherdata2.php";
        public static UInt32 LIMIT_WEB_SEND_INTERVAL = 1 * 60 + 5; //how often to send data, sec
        public static DateTime LastWebDataSent;
        
        //FOR DEBUGGING
        //private static siteipURL = "http://localhost/checkconn/putweatherdata2.php";



        public static bool SendToNarodmonFlag = true;
        public static string Narodmon_MAC = "";
        public static UInt32 LIMIT_NARODMON_SEND_INTERVAL = 5*60+5; //how often to send data, sec
        public static DateTime LastNarodMonDataSent;
        
        /// <summary>
        /// Send data to server asynchroneously
        /// </summary>
        /// <param name="queryst">Get query string in the from "param1=1&param2=2&..."</param>
        public static void sendToServer(string queryst)
        {
            Logging.Log("WebServices.sendToServer enter", 3);
            // Send http query
            try
            {
                WebClient client = new WebClient();
                client.DownloadDataCompleted += client_DownloadDataCompleted;
                Uri urlToRequest = new Uri(siteipURL + "?" + queryst);
                Logging.Log("WebServices.sendToServer query: " + urlToRequest.ToString(), 2);
                
                client.DownloadDataAsync(urlToRequest);
            }
            catch (WebException e)
            {
                Logging.Log("Couldn't reach network server: " + e.Message);
                //MessageBox.Show("Couldn't reach network server: " + e.Message);
                //return ipdata;
                // report a problem with the port name (never get there)
            }
            Logging.Log("WebServices.sendToServer exit", 3);
        }

        // Data received event handler
        private static void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Logging.Log("Error downloading data: " + e.Error.Message);
                //MessageBox.Show(e.Error.Message);
                return;
            }

            if (e.Result != null && e.Result.Length > 0)
            {
                string downloadedData = Encoding.Default.GetString(e.Result);
                Logging.Log("Web query return string: " + downloadedData,2);
                LastWebDataSent = DateTime.Now;
                //MessageBox.Show(downloadedData);
            }
            else
            {
                Logging.Log("No data was downloaded.");
                //MessageBox.Show("No data was downloaded.");
            }
        }

        /// <summary>
        /// Send data to Narodmon.RU
        /// </summary>
        /// <param name="queryst">string in the form "mac1=1&mac2=2&..."</param>
        public static void sendDataToNarodmon(string queryst)
        {
            Logging.Log("WebServices.sendDataToNarodmon enter", 3);
            
            string DevPrefix=Narodmon_MAC.Replace("-", "");
            if (queryst == "") queryst = DevPrefix+"01" + "=10.2"+"&" + DevPrefix+"02" + "=754";
            string postData = "ID=" + Narodmon_MAC + "&" + queryst + ""; //[&time=UnixTime][&lat=LAT][&lng=LNG][&name=ASTROMANIA.INFO]

            //Logging.Log("Narodmon query: " + postData, 2);

            WebRequest request=null;
            Stream dataStream=null;
            try
            {
                // Create a request using a URL that can receive a post. 
                request = WebRequest.Create("http://narodmon.ru/post.php");
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;

                // Get the request stream.
                dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();

                Logging.Log("Narodmon POST query: " + postData, 2);
            }
            catch (Exception e)
            {
                Logging.Log("Errror during narodmon web request: " + e.Message);
            }
            finally
            {
                if (dataStream != null)  dataStream.Close();
            }

            WebResponse response=null;
            StreamReader reader=null;
            try
            {
                // Get the response.
                response = request.GetResponse();
                // Log  the status.
                Logging.Log("Narodmon response status: " + ((HttpWebResponse)response).StatusDescription,2);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Log  the content.
                Logging.Log("Narodmon response: " + responseFromServer,2);
                LastNarodMonDataSent = DateTime.Now;
            }
            catch (Exception e)
            {
                Logging.Log("Errror during getting narodmon web response: " + e.Message);
            }
            finally
            {
                // Clean up the streams.
                if (response != null) response.Close();
                if (reader != null) reader.Close();
            }

            Logging.Log("WebServices.sendDataToNarodmon exit", 3);
        }


        /// <summary>
        /// External method to check when was the last communication
        /// </summary>        
        public static UInt32 SinceLastDataSent(DateTime LastSent)
        {
            TimeSpan SinceLastRead = DateTime.Now.Subtract(LastSent);
            UInt32 SinceLastRead_sec = (UInt32)Math.Round(SinceLastRead.TotalSeconds, 0);

            return SinceLastRead_sec;
        }



        /// <summary>
        /// Finds the MAC address of the NIC with maximum speed.
        /// </summary>
        /// <returns>The MAC address.</returns>
        public static string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                //log.Debug( "Found MAC Address: " + nic.GetPhysicalAddress() + " Type: " + nic.NetworkInterfaceType);

                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    //log.Debug("New Max Speed = " + nic.Speed + ", MAC: " + tempMac);
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }

    }
}
