using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ManipulatingArray
{
    class Program
    {
        static void Main()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int totalA = 0;
            foreach (int item in ArrayA)
            {
                totalA += item;
            }

            Console.WriteLine("ArrayA contains: [0,2,4,6,8,10]");
            Console.WriteLine("Number of elements in ArrayA is: " + ArrayA.Length);
            Console.WriteLine("The sum is: " + totalA);
            Console.WriteLine($"The average of this array is:  {arrayAverage(ArrayA)}");
            
            Array.Reverse(ArrayA);
            Console.WriteLine("Reversed Array: ");
            foreach (int i in ArrayA)
            {
                Console.Write(i + " ");
            }

            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int totalB = 0;
            foreach (int item in ArrayB)
            {
                totalB += item;
            }

            Console.WriteLine("\n\n\nArrayB contains: [1,3,5,7,9]");
            Console.WriteLine("Number of elements in ArrayB is: " + ArrayB.Length);
            Console.WriteLine("The total of ArrayB is: " + totalB);
            Console.WriteLine($"The average of this array is:  {arrayAverage(ArrayB)}");
            
            Array.Reverse(ArrayB);
            Console.WriteLine("Reversed Array: ");
            foreach (int i in ArrayB)
            {
                Console.Write(i + " ");
            }

            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int totalC = 0;
            foreach (int item in ArrayC)
            {
                totalC += item;
            }

            Console.WriteLine("\n\n\nArrayC contains: [3,1,4,1,5,9,2,6,5,3,5,9]");
            Console.WriteLine("Number of elements in ArrayC is: " + ArrayC.Length);
            Console.WriteLine("The total of ArrayC is: " + totalC);
            Console.WriteLine($"The average of this array is:  {arrayAverage(ArrayC)}");
            
            Array.Reverse(ArrayC);
            Console.WriteLine("Reversed Array: ");
            foreach (int i in ArrayC)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nRotating Arrays:" + RotateArray.RotatingArray("left", 2, ArrayA));
            Console.WriteLine(RotateArray.RotatingArray("right", 2, ArrayB));
            Console.WriteLine(RotateArray.RotatingArray("left", 4, ArrayC));
        }

        public static double arrayAverage(int[] arrayAvg)
        {
            double arrayLength = arrayAvg.Length;
            double arraySum = 0;
            foreach (int item in arrayAvg)
            {
                arraySum += item;
            }
            return arraySum / arrayLength;
        }       
    }
}




