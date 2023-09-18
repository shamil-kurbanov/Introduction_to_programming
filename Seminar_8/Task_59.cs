/*
Specify a two-dimensional array of integers. 
Write a program that deletes the row and column 
at the intersection of which the smallest array element is located.
For example, given an array:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
The smallest element is 1, the output is
the following array:
9 2 3
4 2 4
2 6 7
*/

using System;
using static System.Console;

namespace Seminar_8;

public class Task_59
{
    public static void FuctionArrayModification()
    {

        //Define the array
        int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        //Find the smallest element and its position
        int smallestValue = array[0, 0];
        int smallestRow = 0;
        int smallestColumn = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] < smallestValue)
                {
                    smallestValue = array[i, j];
                    smallestRow = i;
                    smallestColumn = j;
                }
            }
        }

        //Create a new array with reduced dimensions
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) -1];
        int newRow = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i == smallestRow)
            {
                continue; //Skip the row with the smallest element
            }

            int newColumn = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == smallestColumn)
                {
                    continue; //Skip the column with the smallest element
                }

                newArray[newRow, newColumn] = array[i, j];
                newColumn++;
            }

            newRow++;
        }

        //Print the new array
        WriteLine("The Modified Array is:");
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for(int j = 0; j < newArray.GetLength(1); j++)
            {
                Write($"{newArray[i, j]} ");
            }
            WriteLine();

        }
    }

}