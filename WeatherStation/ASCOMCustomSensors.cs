using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    /// <summary>
    /// Base class for ASCOM custom sensors
    /// </summary>
    internal abstract class ASCOMCustomSensors
    {
        /// <summary>
        /// Variable for storing driver id
        /// </summary>
        protected string _driverId = "";

        /// <summary>
        /// Pointer for the main object (should be created in each derived class
        /// </summary>
        protected ASCOM.DriverAccess.AscomDriver objDriver = null;

        /// <summary>
        /// Internal var for storing current read status
        /// </summary>
        protected Int16 _curstatus = -1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="initDriverId"></param>
        public ASCOMCustomSensors(string initDriverId)
        {
            _driverId = initDriverId;
        }

        /// <summary>
        /// Abstract method to read current status from driver. Should be implemented for every sensor
        /// </summary>
        public abstract void ReadStatus();


        /// <summary>
        /// Propertie to read current status. Should be called after ReadStatus
        /// </summary>
        public string DeviceId
        {
            get {
                return _driverId;
            }
            set {
                _driverId =value;
                ResetDriver();
            }
        }

        /// <summary>
        /// Reset current driver. Useful if you change driver id and it is needed to connect again
        /// </summary>
        public void ResetDriver()
        {
            if (objDriver != null) objDriver.Dispose();
            objDriver = null;
        }

        /// <summary>
        /// Propertie to read current status. Should be called after ReadStatus
        /// </summary>
        public Int16 CurrentStatus
        {
            get { return _curstatus; }
        }
    }

    /**************************************************************************************************************************************/
    /// <summary>
    /// ASCOM PARK SENSOR
    /// </summary>
    internal class ASCOMTelescopeParkSensor : ASCOMCustomSensors
    {
        private bool? bAtParkFlag = null;

        public ASCOMTelescopeParkSensor(string initDriverId) : base(initDriverId)
        {
        }

        /// <summary>
        /// Implementaion of abastract class
        /// </summary>
        public override void ReadStatus()
        {
            try
            {
                //1 - if null assign
                if (objDriver == null) objDriver = new ASCOM.DriverAccess.Telescope(_driverId);

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


    /**************************************************************************************************************************************/
    /// <summary>
    /// ASCOM DOME SHUTTER STATUS SENSOR
    /// </summary>
    internal class ASCOMDomeShutterClosedSensor : ASCOMCustomSensors
    {
        private ASCOM.DeviceInterface.ShutterState ShutterStatus = ASCOM.DeviceInterface.ShutterState.shutterError;

        public ASCOMDomeShutterClosedSensor(string initDriverId) : base(initDriverId)
        {
        }

        /// <summary>
        /// Implementaion of abastract class
        /// </summary>
        public override void ReadStatus()
        {
            try
            {
                //1 - if null assign
                if (objDriver == null) objDriver = new ASCOM.DriverAccess.Dome(_driverId);

                //2 - Connect
                if (objDriver != null) objDriver.Connected = true;

                //3 - Read
                if (objDriver.Connected) ShutterStatus = ((ASCOM.DriverAccess.Dome)objDriver).ShutterStatus;
            }
            catch
            {
                ShutterStatus = ASCOM.DeviceInterface.ShutterState.shutterError;
            }

            //4 - convert result to res
            if (ShutterStatus == ASCOM.DeviceInterface.ShutterState.shutterError)
            {
                _curstatus = -1;
            }
            else if (ShutterStatus == ASCOM.DeviceInterface.ShutterState.shutterClosed)
            {
                _curstatus = 1;
            }
            else if (ShutterStatus == ASCOM.DeviceInterface.ShutterState.shutterClosing || ShutterStatus == ASCOM.DeviceInterface.ShutterState.shutterOpening)
            {
                _curstatus = 10;
            }
            else
            {
                _curstatus = 0;
            }
        }
    }

    class CustomSensors
    {
        public bool bASCOM_telescope_use = false;
        public bool bASCOM_dome_use = false;

        public string ASCOM_telescope_driverid = "";
        public string ASCOM_dome_driverid = "";

    }

}
