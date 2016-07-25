using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
        abstract class ASCOMCustomSensors
        {
            // Drvier id
            public string DriverId = "";

            protected ASCOM.DriverAccess.AscomDriver objDriver = null;

            // Method to read current status from driver
            public abstract void ReadStatus();

            public ASCOMCustomSensors(string initDriverId)
            {
                DriverId = initDriverId;
            }


            // Method to reset driver (i.e. to create on new driverid)
            public void ResetDriver()
            {
                objDriver = null;
            }


            protected Int16 _curstatus=-1;
            
            // Return status from driver
            public Int16 CurrentStatus
            {
                get { return _curstatus; }
            }
        }

        class ASCOMTelescopeParkSensor : ASCOMCustomSensors
        {
            //private ASCOM.DriverAccess.Telescope objDriver = null;

            private bool? bAtParkFlag = null;

            public ASCOMTelescopeParkSensor(string initDriverId) : base(initDriverId)
            {

            }

            public override void ReadStatus()
            {
                try
                {
                    //1 - if null assign
                    if (objDriver == null) objDriver = new ASCOM.DriverAccess.Telescope(DriverId);

                    //2 - Connect
                    if (objDriver != null) objDriver.Connected = true;

                    //3 - Read
                    if (objDriver.Connected) bAtParkFlag = ((ASCOM.DriverAccess.Telescope)objDriver).AtPark;
                }
                catch
                {
                    bAtParkFlag = null;
                }

                //4 - convert result to res
                if (bAtParkFlag == null)
                {
                    _curstatus = -1;
                }
                else if (bAtParkFlag == true)
                {
                    _curstatus = 1;
                }
                else if (bAtParkFlag == false)
                {
                    _curstatus = 0;
                }
            }

        }


    class Program
    {
        static void Main(string[] args)
        {
            ASCOMTelescopeParkSensor Test = new ASCOMTelescopeParkSensor("EQMOD_SIM.Telescope");

            Console.WriteLine("Status : " + Test.CurrentStatus.ToString());

            Test.ReadStatus();

            Console.WriteLine("Status : " + Test.CurrentStatus.ToString());
            Console.ReadLine();

            Test.ReadStatus();

            Console.WriteLine("Status : " + Test.CurrentStatus.ToString());
            Console.ReadLine();
        }
    }
}
