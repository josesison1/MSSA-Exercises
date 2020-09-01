using System;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace progex01
{
    class Program
    {
        static int enterNum()
        {
            int enterNum = int.Parse(Console.ReadLine());
            if (enterNum > 0)
            {
                return enterNum;
            }
            else
            {
                Console.WriteLine("You must input a number greater than zero.");
                return enterNum;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\nPart 1, circumference and area of a circle.");
                Console.Write("Enter an integer for the radius: ");
                int intradius = enterNum();
                double circumference = checked(2 * Math.PI * intradius);
                Console.WriteLine($"The circumference is {circumference}");

                try
                {
                    double area = checked(Math.PI * (intradius * intradius));
                    Console.WriteLine($"The area is {area}");
                }
                catch (OverflowException oEx)
                {
                    Console.WriteLine("Input must be a number." + oEx.Message);
                }
                // Part 2
                Console.WriteLine("\nPart 2, volume of a hemisphere.");
                Console.WriteLine("Enter an integer for the radius: ");
                intradius = enterNum();
                float fraction = 4 / 3f;
                double volume = checked((fraction * Math.PI * (Math.Pow(intradius, 3)))) / 2;
                Console.WriteLine($"The volume is {volume}");

                // Part 3
                double s, areaTriangle;
                double a, b, c;

                Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
                Console.WriteLine("Enter an integer for the first side of the triangle: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter an integer for the second side of the triangle: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter an integer for the third side of the triangle: ");
                c = double.Parse(Console.ReadLine());

                s = (a + b + c) / 2;
                areaTriangle = checked(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
                Console.WriteLine("The area of the triangle is: " + areaTriangle);
            }
            finally
            {
                Console.WriteLine("Thank you.");
            }
            }
            }
    }














      








