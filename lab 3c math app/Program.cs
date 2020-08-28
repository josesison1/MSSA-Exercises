using System;
using System.Transactions;

namespace lab_3c_math_app
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0; int num2 = 0;

            Console.WriteLine("Enter the first number you want to calculate:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to calculate:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of calculation do you want to perform?");
            Console.WriteLine("\tA - Add");
            Console.WriteLine("\tS - Subtract");
            Console.WriteLine("\tM - Multiply");
            Console.WriteLine("\tD - Divide");


            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
                    Console.WriteLine("Press any key to close this console application....");
                    Console.ReadKey();  
        }
    }
}

   // Console.WriteLine("Press any key to close this console application....");
   // Console.ReadKey();  