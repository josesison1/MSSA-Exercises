using System;
using System.Transactions;

namespace montecarlo
{
    class Program
    {
        static (double, double) RandomPointGenerator(Random R)
        {
            double x = R.NextDouble();
            double y = R.NextDouble();

            //Console.WriteLine($"{x}      {y}");
            return (x, y);
        }

        static double hypotenesuse(double A, double B) => Math.Sqrt((A * A) + (B * B));


        static void Main(string[] args)
        {
            int iterations = 10;
            if (args.Length > 0) iterations = Int32.Parse(args[0]);
            Console.WriteLine($"try running {iterations} times:    ");

            int countInsideCircle = 0;
            Random R = new Random();
            double x, y, z;

            for (int i = 0; i < iterations; i++)
            {
                (x, y) = RandomPointGenerator(R);
                z = hypotenesuse(x, y);
                if (z <= 1.0) countInsideCircle++;
                //Console.WriteLine(".");
            }
            double result = (double)countInsideCircle / (double)iterations;
            Console.WriteLine($"{ result * 4.0}");
            Console.WriteLine(Math.PI);
            //static (double, double) randomNumGen(Random x, Random y)
            //{
            //    double doubleX = x.NextDouble();
            //    double doubleY = y.NextDouble();
            //    return (doubleX, doubleY);
            //}

            //static double findHypotenuse(double x, double y)
            //{
            //    double hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            //    return hypotenuse;
            //}

            //static void startCalculation(int iterations)
            //{
            //    Random x = new Random();
            //    Random y = new Random();
            //    double count = 0;
            //    for (int i = 0; i < iterations; i++) 
            //    {
            //        (double randomX, double randomY) = randomNumGen(x, y);
            //        double hypotenuse = findHypotenuse(randomX, randomY);
            //        if (hypotenuse <= 1)
            //        {
            //            count++;
            //        }
            //    }
            //    double result = (count / iterations) * 4;
            //    Console.WriteLine($"The calculated pi is {result}");
            //    double difference = Math.Abs(result - Math.PI);
            //    Console.WriteLine($"The difference between pi and the calculated pi is {difference}");
            //}
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("How many times do you want to iterate?");
            //    int numOfIterations = int.Parse(Console.ReadLine());
            //    startCalculation(numOfIterations);
            //}
        }
        }
}
/*
10
100
1000
10000
*/