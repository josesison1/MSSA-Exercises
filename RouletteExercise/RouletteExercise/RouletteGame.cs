using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RouletteExercise
{
    public class RouletteGame
    {
            public static string CornerBet(int resultNumber)
            {
                string result = "";

                int[] FirstColumn = new int[] { 4, 7, 10, 13, 16, 19, 22, 25, 28, 31 };
                int[] SecondColumn = new int[] { 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 };
                int[] ThirdColumn = new int[] { 6, 9, 12, 15, 18, 21, 24, 27, 30, 33 };
                if (resultNumber == 37 || resultNumber == 38)
                {
                    result = "The ball lands on green. No winning corner bets.";
                }
                if (resultNumber == 1)
                {
                    int rightAdjacent = resultNumber + 1;
                    int below = resultNumber + 3;
                    int belowRight = resultNumber + 4;

                    result += "[" + resultNumber + "," + rightAdjacent + "," + below + "," + belowRight + "]";
                }
                if (resultNumber == 2)
                {
                    int leftAdjacent = resultNumber - 1;
                    int belowLeft = resultNumber + 2;
                    int below = resultNumber + 3;

                    int rightAdjacent = resultNumber + 1;
                    int belowAdjacent = resultNumber + 3;
                    int belowRight = resultNumber + 4;

                    result += "[" + leftAdjacent + "," + resultNumber + "," + belowLeft + "," + below + "]" +
                        " or [" + resultNumber + "," + rightAdjacent + "," + belowAdjacent + "," + belowRight + "]";
                }
                if (resultNumber == 3)
                {
                    int leftAdjacent = resultNumber - 1;
                    int leftBelow = resultNumber + 2;
                    int rightBelow = resultNumber + 3;

                    result += "[" + leftAdjacent + "," + resultNumber + "," + leftBelow + "," + rightBelow + "]";
                }
                if (resultNumber == 34)
                {
                    int upperAdjacent = resultNumber - 3;
                    int upperRight = resultNumber - 2;
                    int rightAdjacent = resultNumber + 1;

                    result += "[" + upperAdjacent + "," + upperRight + "," + resultNumber + "," + rightAdjacent + "]";
                }
                if (resultNumber == 35)
                {
                    int leftUpperLeft = resultNumber - 4;
                    int leftUpperRight = resultNumber - 3;
                    int leftAdjacent = resultNumber - 1;

                    int rightUpperLeft = resultNumber - 3;
                    int rightUpperRight = resultNumber - 2;
                    int rightAdjacent = resultNumber + 1;

                    result += "[" + leftUpperLeft + "," + leftUpperRight + "," + leftAdjacent + "," + resultNumber + "]" +
                        " or [" + rightUpperLeft + "," + rightUpperRight + "," + resultNumber + "," + rightAdjacent + "]";
                }
                if (resultNumber == 36)
                {
                    int upperLeft = resultNumber - 4;
                    int upperRight = resultNumber - 3;
                    int leftAdjacent = resultNumber - 1;

                    result += "[" + upperLeft + "," + upperRight + "," + leftAdjacent + "," + resultNumber + "]";
                }
                if (FirstColumn.Contains(resultNumber))
                {
                    int upperNum = resultNumber - 3;
                    int rightNum = resultNumber + 1;
                    int upperRight = upperNum + 1;

                    int lowerRight = resultNumber + 1;
                    int below = resultNumber + 3;
                    int lowerCornerRight = resultNumber + 4;

                    result += "[" + upperNum + "," + upperRight + "," + resultNumber + "," + rightNum + "]" +
                        " or [" + resultNumber + "," + lowerRight + "," + below + "," + lowerCornerRight + "]"; ;
                }
                else if (SecondColumn.Contains(resultNumber))
                {
                    int leftUpperCorner = resultNumber - 4;
                    int leftUpperRight = leftUpperCorner + 1;
                    int leftAdjacent = resultNumber - 1;

                    int rightUpperCorner = resultNumber - 3;
                    int rightUpperRight = rightUpperCorner + 1;
                    int rightAdjacent = resultNumber + 1;

                    int leftLowerCorner = resultNumber - 1;
                    int leftLowerLeft = resultNumber + 2;
                    int leftCornerBelow = resultNumber + 3;

                    int rightLowerCorner = resultNumber + 1;
                    int rightBelow = resultNumber + 3;
                    int rightLowerRight = resultNumber + 4;

                    result += "[" + leftUpperCorner + "," + leftUpperRight + "," + leftAdjacent + "," + resultNumber + "] "
                      + " or [" + rightUpperCorner + "," + rightUpperRight + "," + rightAdjacent + "," + resultNumber + "] " +
                      " or [" + leftLowerCorner + "," + resultNumber + "," + leftLowerLeft + "," + leftCornerBelow + "] " +
                        " or [" + resultNumber + "," + rightLowerCorner + "," + rightBelow + "," + rightLowerRight + "] ";
                }
                else if (ThirdColumn.Contains(resultNumber))
                {
                    int leftUpperleft = resultNumber - 4;
                    int leftUpperRight = resultNumber - 3;
                    int leftAdjacent = resultNumber - 1;

                    int lowerCornerLeft = resultNumber - 1;
                    int lowerLeft = resultNumber + 2;
                    int belowAdjacent = resultNumber + 3;

                    result += "[" + leftUpperleft + "," + leftUpperRight + "," + leftAdjacent + "," + resultNumber + "]" +
                        " or [" + lowerCornerLeft + "," + resultNumber + "," + lowerLeft + "," + belowAdjacent + "]"; ;
                }
                return result;
            }
            public static string SixLine(int resultNumber) 
            {
                string result = "";

                if (resultNumber > 0 && resultNumber <= 3)
                {
                    result = "The 6 line winning numbers are: 1/2/3/4/5/6";
                }
                else if (resultNumber >= 4 && resultNumber <= 6)
                {
                    result = "The 6 line winning numbers are either 1/2/3/4/5/6 or 4/5/6/7/8/9";
                }
                else if (resultNumber >= 7 && resultNumber <= 9)
                {
                    result = "The 6 line winning numbers are either 4/5/6/7/8/9 or 7/8/9/10/11/12";
                }
                else if (resultNumber >= 10 && resultNumber <= 12)
                {
                    result = "The 6 line winning numbers are either 7/8/9/10/11/12 or 10/11/12/13/14/15";
                }
                else if (resultNumber >= 13 && resultNumber <= 15)
                {
                    result = "The 6 line winning numbers are either 10/11/12/13/14/15 or 13/14/15/16/17/18";
                }
                else if (resultNumber >= 16 && resultNumber <= 18)
                {
                    result = "The 6 line winning numbers are either 13/14/15/16/17/18 or 16/17/18/19/20/21";
                }
                else if (resultNumber >= 19 && resultNumber <= 21)
                {
                    result = "The 6 line winning numbers are either 16/17/18/19/20/21 or 19/20/21/22/23/24";
                }
                else if (resultNumber >= 22 && resultNumber <= 24)
                {
                    result = "The 6 line winning numbers are either 19/20/21/22/23/24 or 22/23/24/25/26/27";
                }
                else if (resultNumber >= 25 && resultNumber <= 27)
                {
                    result = "The 6 line winning numbers are either 22/23/24/25/26/27 or 25/26/27/28/29/30";
                }
                else if (resultNumber >= 28 && resultNumber <= 30)
                {
                    result = "The 6 line winning numbers are either 25/26/27/28/29/30 or 28/29/30/31/32/33";
                }
                else if (resultNumber >= 31 && resultNumber <= 33)
                {
                    result = "The 6 line winning numbers are either 28/29/30/31/32/33 or 31/32/33/34/35/36";
                }
                else if (resultNumber >= 34 && resultNumber <= 36)
                {
                    result = "The 6 line winning numbers are 31/32/33/34/35/36";
                }
                else
                {
                    result = "No winning six lines.";
                }
                return result;
            }
            public static string Split(int currentNum)
            {
                string result = "";
                if (currentNum == 37 || currentNum == 38)
                {
                    result = "No Split Bet wins.";
                }
                if (currentNum == 1)
                {
                    int rightAdjacency = currentNum + 1;
                    int downAdjacency = currentNum + 3;

                    result += "[" + currentNum + "," + rightAdjacency.ToString() + "] " + "[" + currentNum + "," + downAdjacency + "]";
                }
                else if (currentNum == 2)
                {
                    int downAdjacency = currentNum + 3;
                    int leftAdjacency = currentNum - 1;
                    int rightAdjacency = currentNum + 1;
                    result += "[" + currentNum + "," + rightAdjacency + "] " + "[" + currentNum + "," + downAdjacency + "] "
                        + "[" + currentNum + "," + leftAdjacency + "]";
                }
                else if (currentNum == 3)
                {
                    int downAdjacency = currentNum + 3;
                    int leftAdjacency = currentNum - 1;
                    result += "[" + currentNum + "," + downAdjacency + "] "
                       + "[" + currentNum + "," + leftAdjacency + "]";
                }
                else if (currentNum == 34)
                {
                    int upAdjacency = currentNum - 3;
                    int rightAdjacency = currentNum + 1;
                    result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                        + rightAdjacency + "] ";
                }
                else if (currentNum == 35)
                {
                    int leftAdjacency = currentNum - 1;
                    int upAdjacency = currentNum - 3;
                    int rightAdjacency = currentNum + 1;
                    result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                 + rightAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";

                }
                else if (currentNum == 36)
                {
                    int leftAdjacency = currentNum - 1;
                    int upAdjacency = currentNum - 3;
                    result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";
                }
                else if (currentNum == 4 || currentNum == 7 || currentNum == 10 || currentNum == 13 || currentNum == 16 || currentNum == 19 ||
                         currentNum == 22 || currentNum == 25 || currentNum == 28 || currentNum == 31)
                {
                    int upAdjacency = currentNum - 3;
                    int downAdjacency = currentNum + 3;
                    int rightAdjacency = currentNum + 1;
                    result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                        + rightAdjacency + "] " + "[" + currentNum + "," + downAdjacency + "]";
                }
                else if (currentNum == 5 || currentNum == 8 || currentNum == 11 || currentNum == 14 || currentNum == 17 ||
                         currentNum == 20 || currentNum == 23 || currentNum == 26 || currentNum == 29 || currentNum == 32)
                {
                    int upAdjacency = currentNum - 3;
                    int downAdjacency = currentNum + 3;
                    int leftAdjacency = currentNum - 1;
                    int rightAdjacency = currentNum + 1;
                    result += "[" + currentNum + "," + upAdjacency + "] " + "[" + currentNum + ","
                        + rightAdjacency + "] " + "[" + currentNum + "," + downAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";
                }
                else if (currentNum == 6 || currentNum == 9 || currentNum == 12 || currentNum == 15 || currentNum == 18 ||
                         currentNum == 21 || currentNum == 24 || currentNum == 27 || currentNum == 30 || currentNum == 33)
                {
                    int upAdjacency = currentNum - 3;
                    int downAdjacency = currentNum + 3;
                    int leftAdjacency = currentNum - 1;
                    result += "[" + currentNum + "," + upAdjacency + "] "
                        + "[" + currentNum + "," + downAdjacency + "] " + "[" + currentNum + "," + leftAdjacency + "]";
                }
                return result;
            }
            public static string Street(string[] stringArray, int currentIndex) 
            {
                string result = "";
                string plusOne = "";
                string minusOne = "";

                if (currentIndex >= 2 && currentIndex <= 35)
                {
                    plusOne = stringArray[currentIndex + 1];
                    minusOne = stringArray[currentIndex - 1];
                    result = "Street rows winners: " + minusOne + " | " + stringArray[currentIndex] + " | " + plusOne;
                }
                else
                {
                    result = "No street row winners";
                }
                return result;
            }
            public static string Rows(int resultNumber) 
            {
                string result = "";

                if (resultNumber <= 12 && resultNumber > 0)
                {
                    result = "First Column Wins";
                }
                else if (resultNumber >= 13 && resultNumber < 25)
                {
                    result = "Second Column Wins";
                }
                else if (resultNumber >= 25 && resultNumber <= 36)
                {
                    result = "Third Column Wins";
                }
                else
                {
                    result = "No Columns won";
                }
                return result;
            }
            public static string LowOrHigh(int resultNumber) 
            {
                string result = "";

                if (resultNumber >= 19 && resultNumber < 36)
                {
                    result = "High";
                }
                else if (resultNumber > 0 && resultNumber < 19)
                {
                    result = "Low";
                }
                else
                {
                    result = "The ball landed on a green bin, no low or high bet winners.";
                }

                return result;
            }
            public static int RandomizeRoulette(string[] rouletteArray) 
            {
                Random random = new Random();
                int resultIndex = random.Next(rouletteArray.Length - 1);
                int realNumber = resultIndex + 1;
                Console.WriteLine("Spinning...");
                return realNumber;
            }
            public static string RedOrBlack(string resultValue) 
            {
                string isRed = "Red";
                string isGreen = "Green";
                string result = "";

                bool red = resultValue.Contains(isRed);
                bool green = resultValue.Contains(isGreen);
                if (red)
                {
                    result = "Red";
                }
                else if (green)
                {
                    result = "Green";
                }
                else
                {
                    result = "Black";
                }
                return result;
            }
            public static string EvenOrOdd(int resultNumber) 
            {
                string resultString = "";

                if (resultNumber == 36 || resultNumber == 37)
                {
                    resultString = "It is neither even or odd.";
                }
                resultNumber %= 2;
                if (resultNumber == 0)
                {
                    resultString += "Evens";
                }
                else if (resultNumber != 0)
                {
                    resultString += "Odds";
                }
                return resultString;

            }

        }
}
