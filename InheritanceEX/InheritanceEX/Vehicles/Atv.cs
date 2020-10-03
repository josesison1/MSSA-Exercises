using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEX.Vehicles
{
    class Atv : TactVehicles
    {
        public static void TopSpeed()
        {
            Console.WriteLine("20 MPH!");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }
}
