/*
Give the values of M and N. 
Write a program that will find the sum of natural elements in the range from M to N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;

namespace Seminar_9;

public class Task_66
{
    public static void promptForTask66()
    {
        Write("Enter M: ");
        int m = int.Parse(ReadLine());
        Write("Enter N: ");
        int n = int.Parse(ReadLine());

         if (m <= n)
        {
            int result = fuctionSumNaturalNumbersFromMtoN(m, n);
            WriteLine("Sum of natural numbers from " + m + " to " + n + ": " + result);
        }
        else
        {
            WriteLine("M should be less than or equal to N.");
        }

    }

    public static int fuctionSumNaturalNumbersFromMtoN(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

}