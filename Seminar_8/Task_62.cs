/*
Write a program that will fill a 4 x 4 array in a spiral fashion.
For example, the output is the following array:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;
using static System.Console;

namespace Seminar_8;

public class Task_62
{
    public static void FuctionArraySpiral()
    {
        int n = 4; //Array size
        int[,] spiralArray = new int[n, n];

        int num = 1; //The number to be written to the array
        
        int rowStart = 0; //The first row of the array
        int rowEnd = n - 1; //The last row of the array

        int colStart = 0; //The first column of the array
        int colEnd = n - 1; //The last column of the array

        while(num <= n*n)
        {
            //Fill the top row
            for (int i = colStart; i <= colEnd; i++)
            {
                spiralArray[rowStart, i] = num++;
            }
            rowStart++;

            //Fill the rightmost column
            for (int i = rowStart; i <= rowEnd; i++)
            {
                spiralArray[i, colEnd] = num++;
            }
            colEnd--;

            //Fill the bottom row
            for (int i = colEnd; i >= colStart; i--)
            {
                spiralArray[rowEnd, i] = num++;
            }
            rowEnd--;

            //Fill the leftmost column
            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralArray[i, colStart] = num++;
            }
            colStart++;
        }

        //Output the array
        WriteLine("The spiral array 4x4:");
        for (int i = 0; i < spiralArray.GetLength(0); i++)
        {
            for (int j = 0; j < spiralArray.GetLength(1); j++)
            {
                Write($"{spiralArray[i, j], 3}");
            }
            WriteLine();
        }

    }
}