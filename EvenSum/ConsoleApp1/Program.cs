using System;
using System.IO;
using System.Net.Http.Headers;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static int EvenSum(int min, int max)
        {
            int result = 0;

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0) result += i;
            }
            return result;
        }


        static void Main(string[] args)
        {
            int total = EvenSum(2, 5);
            Console.WriteLine(total);
        }
    }
}
