using System;
using System.Security.Cryptography.X509Certificates;

namespace KmtoMiles
{
    class Program
    {
        static double KiloInMile  = 1.609;
        static double MiToKm(double miles) => miles * KiloInMile;       
       


        static void Main(string[] args)
        {
            Console.WriteLine(MiToKm(5));          
       }
    }
}
