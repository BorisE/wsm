using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WeatherStation;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStationSerial WS = new WeatherStationSerial();

            Random rand = new Random();
            string st3=String.Format("{0:N1}", 23.0 + rand.NextDouble() * 5);
            Console.WriteLine(st3);

            WS.LastMeasure = DateTime.Now;
            Thread.Sleep(2000);

            double N = DateTime.Now.ToOADate();
            Console.WriteLine(N);
            
            //Сохранение Boltwood Sensor file
            WS.Bolt_date = DateTime.Now.ToString("yyyy-MM-dd");
            WS.Bolt_time = DateTime.Now.ToString("HH:mm:ss.ff");
            WS.Bolt_now = DateTime.Now.ToOADate();

            TimeSpan MeasureInterval = DateTime.Now.Subtract(WS.LastMeasure);
            WS.Bolt_SinceLastMeasure = (ushort)Math.Round(MeasureInterval.TotalSeconds,0);
            Console.WriteLine(WS.Bolt_SinceLastMeasure);


            string bold_st = String.Format("{0,10} {1,11} C K {2,6:N1} {3,6:N1} {4,6:N1} {5,6:N1} {6,3:N0} {7,6:N1} {8,3:N0} {9,1:N0} {10,1:N0} {11,5:N0} {12,12:F5} {13,1:N0} {14,1:N0} {15,1:N0} {16,1:N0} {17,1:N0} {18,1:N0}",
                WS.Bolt_date, WS.Bolt_time, WS.ObjTempVal, WS.BaseTempVal, WS.SensorCaseTempVal, WS.WindSpeed, WS.HumidityVal, WS.Bolt_DewPoint, WS.Bolt_Heater,
                (int)WS.Bolt_RainFlag, (int)WS.Bolt_WetFlag, WS.Bolt_SinceLastMeasure.ToString("00000"), WS.Bolt_now.ToString("000000.#####"), 
                (int)WS.Bolt_CloudCond, (int)WS.Bolt_WindCond, (int)WS.Bolt_RainCond, (int)WS.Bolt_DaylighCond, (int)WS.Bolt_RoofCloseFlag, (int)WS.Bolt_AlertFlag);

            Logging.WirteBoltwoodData(bold_st);
            WS.LastMeasure = DateTime.Now;


            double t = 19.2; double h = 1.0;
            double dp = WS.DewPoint(t, h);
            Console.WriteLine("Dew point at {0}C {1}%: {2}",t,h,dp);

            Console.WriteLine("Test");
            Console.ReadLine();
            
        }
    }
}
