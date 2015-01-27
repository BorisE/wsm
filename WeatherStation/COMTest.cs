using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WeatherStation
{
    [Guid("DBE0E8C4-1C61-41f3-B6A4-4E2F353D3D05")]
    public interface COMTest
    {
        void PrintHi(string name);
    }

    [Guid("C6659361-1625-4746-931C-36014B146679")]
    public class InterfaceImplementation: COMTest
    {
        public void PrintHi(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
