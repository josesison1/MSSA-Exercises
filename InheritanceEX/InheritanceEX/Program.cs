using System;
using InheritanceEX.Personnel;
using InheritanceEX.Vehicles;

namespace InheritanceEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX 7A - C# - Military Unit (Implementing Inheritance)\n");


            Marines myMarines = new Marines();
            Marines.Talk();
            myMarines.Motivate();

            Console.WriteLine();

            JuniorEnlisted juniorMarine = new JuniorEnlisted();
            JuniorEnlisted.Dedication();
            juniorMarine.Motivate();

            Console.WriteLine();

            Nco myNCO = new Nco();
            Nco.Greetings();
            myNCO.Motivate();

            Console.WriteLine();

            TactVehicles vehicles = new TactVehicles();
            TactVehicles.StartUp();
            TactVehicles.GoFast();
            vehicles.Stop();

            Console.WriteLine();

            Atv allTerrain = new Atv();
            Atv.TopSpeed();
            allTerrain.Stop();

            Console.WriteLine();

            Hmmwv myhmmwvv = new Hmmwv();
            Hmmwv.Speed();
            myhmmwvv.Stop();
        }
    }
}
