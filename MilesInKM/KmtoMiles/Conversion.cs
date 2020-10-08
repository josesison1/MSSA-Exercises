using System;
using System.Collections.Generic;
using System.Text;

namespace KmtoMiles
{
    class Conversion
    {
        const double conversion = 1.609;
        public static double KmToMiles(double kilo)
        {
            return kilo / conversion;                  
        }

        public static double MilesToKilo(double miles)
        {
            return miles * conversion;
        }
    }
}
