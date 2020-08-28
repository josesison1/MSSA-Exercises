using System;

namespace IntegerSwap
{
    class Program
    {
        static void IntSwap()
        {
            int x = 4;
            int y = 10;

            Console.WriteLine("\n\nBefore swap: x=" + x + " y=" + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swap: x=" + x + " y=" + y);
        }
        static void Main(string[] args)
        {
            IntSwap();

        }
    }
}


    

