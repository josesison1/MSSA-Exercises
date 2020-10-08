using System;
using System.Xml.Schema;
using System.Xml.XPath;

namespace Prac
{
    class Program
    {
        // Given input of 2 numbers, if first number is divisible by the 2nd number return true;
        static bool dividesEvenly(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        // Return if input is empty or not 

        static bool isEmpty(string inputString)
        {
            if (inputString == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Convert minutes into seconds  
        static void secondsinmins()
        {
            Console.Write("Enter the minutes you want to convert into seconds: ");
            int mins = Convert.ToInt32(Console.ReadLine());
            int result = mins * 60;

            Console.WriteLine($"there are {result} seconds in {mins} minutes");
        }
        static void Main(string[] args)
        {
            //SecondsInMins();
            //isEmpty();
            bool num = dividesEvenly(900, 90);
            Console.WriteLine($"{ num}");
            
        }
    }
}
