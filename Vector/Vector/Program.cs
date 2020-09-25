using System;

namespace Vector
{
    class Program
    {       

        static Random random = new Random();
        
        struct pointStruct
        {
            public int x;
            public int y;
            public int z;
        }

        static pointStruct[] GetPoints(int n = 5)
        {
            pointStruct[] points = new pointStruct[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = new pointStruct
                {
                    x = random.Next(1, 100),
                    y = random.Next(1, 100),
                    z = random.Next(1, 100)
                };
            }

            return points;
        }

        static double GetDistance(pointStruct A, pointStruct B)
        {
            int width = Math.Abs(A.x) - Math.Abs(B.x);
            int height = Math.Abs(A.y) - Math.Abs(B.y);
            int depth = Math.Abs(A.z) - Math.Abs(B.z);
            return Math.Sqrt(width * width + height * height + depth * depth);
        }

        static double ShortestDistance()
        {
            pointStruct[] pointArr = GetPoints();

            double shortest = Convert.ToDouble(int.MaxValue);

            for (int i = 0; i < pointArr.Length; i++)
            {
                for (int j = 0; j < pointArr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    double distance = GetDistance(pointArr[i], pointArr[j]);

                    if (distance < shortest)
                    {
                        shortest = distance;
                    }
                }
            }

            return shortest;
        }

        static void Main(string[] args)
            {
                Console.WriteLine(ShortestDistance());
            }
        }
    }
