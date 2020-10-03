using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceEX.Personnel
{
     class Marines
    {
        public static void Talk()
        {
            Console.WriteLine("Oorah");
        }

        public virtual void Motivate()
        {
            Console.WriteLine("Default response of the Motivate method");
        }
    }
}
