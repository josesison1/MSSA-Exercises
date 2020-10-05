using System;
using System.Globalization;
using System.Security.Cryptography;

namespace RouletteExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of the colors and numbers from 1-36 including 0 & 00
            string[] rouletteNumbers= new string[] { "Red : 1", "Black : 2", "Red : 3", "Black : 4", "Red : 5",
                                                   "Black : 6", "Red : 7", "Black : 8", "Red : 9", "Black : 10", "Black : 11", "Red : 12",
                                                   "Black : 13", "Red : 14", "Black : 15", "Red : 16", "Black : 17", "Red : 18", "Red : 19",
                                                   "Black : 20", "Red : 21", "Black : 22", "Red : 23", "Black : 24", "Red : 25", "Black : 26",
                                                   "Red : 27", "Black : 28", "Black : 29", "Red : 30", "Black : 31", "Red : 32", "Black : 33",
                                                   "Red : 34", "Black : 35", "Red : 36", "Green : 0", "Green : 00" };



            Console.WriteLine("\n\n***********************************************\n" +
                                "|         WELCOME TO THE ROULETTE GAME        |" +
                              "\n***********************************************\n");
            Console.Write("Press ANY key to spin.......\n");
            Console.ReadLine();
            int resultNumber = RouletteGame.RandomizeRoulette(rouletteNumbers) - 1;
            int indexNum = resultNumber;
            Console.WriteLine("\nThe ball landed on : " + rouletteNumbers[resultNumber]);
            resultNumber += 1;
            Console.WriteLine("The winning bets are as follows: ");            
            Console.WriteLine("Evens or Odds bets: " + RouletteGame.EvenOrOdd(resultNumber));           
            Console.WriteLine("Green, Red or Black bets: " + RouletteGame.RedOrBlack(rouletteNumbers[indexNum]));
            Console.WriteLine("Lows or Highs bets: " + RouletteGame.LowOrHigh(resultNumber));
            Console.WriteLine("Rows bets: " + RouletteGame.Rows(resultNumber));
            Console.WriteLine("Street bets: "+ RouletteGame.Street(rouletteNumbers, indexNum));           
            Console.WriteLine("Split win cases: " + RouletteGame.Split(resultNumber));
            Console.WriteLine("Six Line win cases: " + RouletteGame.SixLine(resultNumber));
            Console.WriteLine("Corner win cases: " + RouletteGame.CornerBet(resultNumber));
            
        }
    }
}
