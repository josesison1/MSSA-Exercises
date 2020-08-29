using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\t\t\t\t\t|============================|\n" +
                                    "\t\t\t\t\t| WELCOME TO THE NUMBER GAME |\n" +
                                    "\t\t\t\t\t|============================|\n");

            Console.WriteLine("\n\t\t\t\t\tGuess the magic number between 1-1000\n\n");

            Random random = new Random();
            int rightNumber = random.Next(0, 1000);
            int guessCount = 0;
            bool isRightNumber = false;

            while (isRightNumber == false)
            {
                Console.Write("\t\t\t\t\tWhat is your guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == rightNumber)
                {
                    guessCount++;
                    Console.WriteLine($"\t\t\t\t\tGood job! It only took you {guessCount} tries!");
                    isRightNumber = true;
                }

                if (userGuess < rightNumber)
                {
                    Console.Write("\t\t\t\t\tYou guessed too low! Try again.\n\n");
                    guessCount++;
                }
                if (userGuess > rightNumber)
                {
                    Console.Write("\t\t\t\t\tYou guessed too high! Try again.\n\n ");
                    guessCount++;
                }
            }
        }
    }
}
