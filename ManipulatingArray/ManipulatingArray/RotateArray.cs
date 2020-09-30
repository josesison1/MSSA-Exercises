using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulatingArray
{
    public class RotateArray
    {
             public static int[] RotatingArray(string direction, int numOfPlaces, int[] inputArray)
             {
            int[] rotatedArray = new int[inputArray.Length];
            int index = 0;
            if (direction == "left")
            {
                for (int i = inputArray.Length - numOfPlaces; i < inputArray.Length; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
                for (int i = 0; i < inputArray.Length - numOfPlaces; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
            }
            else 
            {
                for (int i = numOfPlaces; i < inputArray.Length; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
                for (int i = 0; i < numOfPlaces; i++)
                {
                    rotatedArray[index] = inputArray[i];
                    index++;
                }
            }
            return rotatedArray;
        }
    }
}
