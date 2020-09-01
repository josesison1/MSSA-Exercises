using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t\t|********************************************|" +
                                "\n\t\t\t\t|    F    I    Z    Z    B    U    Z    Z    |" +
                                "\n\t\t\t\t|********************************************|");

                for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
