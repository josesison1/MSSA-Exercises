using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace InheritanceEX.Vehicles
{
    public class TactVehicles
    {
        public static void StartUp()
        {
            Console.WriteLine("Starts engine");
        }

        public static void GoFast()
        {
            Console.WriteLine("Faster!");
        }
        
        public virtual void Stop()
        {
            Console.WriteLine("Default noise of the stop method");
        }
    }
}
