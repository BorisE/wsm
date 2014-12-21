﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WeatherStation
{
    /// <summary>
    /// Class with method for working with Weather Station data, getting not from Serial Port, but from file
    /// </summary>
    public static class SerialFromFile
    {

        public static string SerialFileNameIn = "";
        public static string SerialFileNameOut = "";

        public static bool ConsideredOpen = false;

        public static UInt32 _MAX_MODIFICATION_TIMEOUT = 100;

        /// <summary>
        /// Open Serial File Emulation
        /// </summary>
        /// <returns>true if it can be opened</returns>
        public static bool Open()
        {
            Logging.Log("SerialFromFile Open enter", 3);
            bool retIsOpened = false;

            if (File.Exists(SerialFileNameIn))
            {

                if (checkFileModification())
                {
                    retIsOpened = true;
                }
                else
                {
                    retIsOpened = false;
                }
    
            }
            else
            {
                retIsOpened = false;
            }

            ConsideredOpen = retIsOpened;
            if (retIsOpened)
            {
                Logging.Log("SerialFileNameIn exists, considered port is opened", 1);
            }
            else
            {
                Logging.Log("SerialFileNameIn doesn't exist, considered port can't be opened", 1);
            }

            return retIsOpened;
        }


        /// <summary>
        /// Close Serial File Emulation
        /// </summary>
        /// <returns>true if it can be opened</returns>
        public static bool Close()
        {
            Logging.Log("SerialFromFile Close enter", 3);
            bool retIsClosed = false;

            ConsideredOpen = retIsClosed;

            Logging.Log("SerialFromFile Close exit, state = " + retIsClosed, 3); 
            return retIsClosed;
        }



        /// <summary>
        /// Emulated read from port. Checks if file was modified...
        /// </summary>
        /// <returns>Buffer, or empty string if file wasn't modified or even exists</returns>
        public static string Read()
        {
            Logging.Log("SerialFromFile Read enter", 3);
            string st = "";

            if (checkFileModification())
            {
                st = getBufferFromFile();
            }

            Logging.Log("SerialFromFile Read exit", 3);
            return st;
        }

        /// <summary>
        /// Check file modification date
        /// </summary>
        /// <returns></returns>
        public static bool checkFileModification()
        {
            Logging.Log("checkFileModification enter", 3);
            bool retIsModified = false;

            if (File.Exists(SerialFileNameIn))
            {
                // Get the creation time.
                DateTime dt = File.GetLastWriteTime(SerialFileNameIn);

                TimeSpan SinceLastModification = DateTime.Now.Subtract(dt);
                UInt32 SinceLastModification_sec = (UInt32)Math.Round(SinceLastModification.TotalSeconds, 0);

                if (SinceLastModification_sec < _MAX_MODIFICATION_TIMEOUT)
                {
                    retIsModified = true;
                    Logging.Log("Serial file emulation modification check ok. Was modified " + SinceLastModification_sec+" sec. ago", 2);
                }
                else
                {
                    retIsModified = false;
                    Logging.Log("Serial file emulation error - file haven't changed for too long (" + SinceLastModification_sec + " sec)");
                }
            }
            else
            {
                retIsModified = false;
                Logging.Log("Serial file emulation error - file doesn't exist");
            }

            Logging.Log("checkFileModification exit", 3);
            return retIsModified;
        }



        /// <summary>
        /// Get data from file
        /// </summary>
        /// <returns></returns>
        public static string getBufferFromFile()
        {
            Logging.Log("getBufferFromFile enter", 3);
            string st = "";

            if (File.Exists(SerialFileNameIn))
            {
                // Get the creation time.
                st = File.ReadAllText(SerialFileNameIn);
            }
            else
            {
                Logging.Log("Serial File emulation error. File with serial output can't be found");
            }

            Logging.Log("getBufferFromFile exit", 3);
            return st;
        }


    }
}
