/*
Problem 58: Define two matrices. Write a program that will find the product of two matrices.
For example, given 2 matrices:
2 4 | 3 4
3 2 | 3 3
The resulting matrix will be:
18 20
15 18
*/

using System;
using static System.Console;

namespace Seminar_8;

public class Task_58
{
    public static void FuctionMatrixMultiplication()
    {
        //Define the first matrix
        int[,] matrix1 =
        {
         {2, 4},
         {3, 2}
        };

        //Define the second matrix
        int[,] matrix2 =
        {
          {3, 4},
          {3, 3}
         };

        //Find the dimensions of the matrices
         int rows1 = matrix1.GetLength(0);
         int columns1 = matrix1.GetLength(1);
         int rows2 = matrix2.GetLength(0);
         int columns2 = matrix2.GetLength(1);

         //Check if the matrices can be multiplied

        if(columns1 != rows2)
        {
          WriteLine("The matrices cannot be multiplied");
         return;
        }

        //Create the resulting matrix to store the product
        int[,] resultMatrix = new int[rows1, columns2];

        //Multiply the matrices
        for(int i = 0; i < rows1; i++)
        {
            for(int j = 0; j < columns2; j++)
            {
             resultMatrix[i, j] = 0;
             for (int k = 0; k < columns1; k++)
                {
                     resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        //Print the resulting matrix
        WriteLine("The resulting matrix is:");
        for (int i = 0; i < rows1; i++)
        {
            for(int j = 0; j < columns2; j++)
            {
                Write($"{resultMatrix[i, j] }");
            }
            WriteLine();
         }


    }
}