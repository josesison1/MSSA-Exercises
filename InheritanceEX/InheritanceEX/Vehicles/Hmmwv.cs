using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEX.Vehicles
{
    class Hmmwv : TactVehicles
    {
        public static void Speed()
        {
            Console.WriteLine("I am going 60 MPH");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }
}
