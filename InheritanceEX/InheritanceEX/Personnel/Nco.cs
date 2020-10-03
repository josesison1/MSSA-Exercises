using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEX.Personnel
{
    class Nco : Marines
    {
        public static void Greetings()
        {
            Console.WriteLine("Good morning");
        }

        public override void Motivate()
        {
            Console.WriteLine("Smedley Butler!");
        }
    }
}
