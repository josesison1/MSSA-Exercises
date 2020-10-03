using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceEX.Personnel
{
    class JuniorEnlisted : Marines
    {
        public static void Dedication()
        {
            Console.WriteLine("Motivation");
        }
        public override void Motivate()
        {
            Console.WriteLine("Chesty Puller!");
        }
    }
}
