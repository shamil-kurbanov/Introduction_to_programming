/*
Write a program to evaluate the Ackermann function using recursion. Given two non-negative numbers m and n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using System;
using static System.Console;

namespace Seminar_9;

public class Task_68
{
    public static void promptForTask68()
    {
        WriteLine("Ackermann function A(m,n)");
        WriteLine();
        Write("Enter m: ");
        int m = int.Parse(ReadLine());
        Write("Enter n: ");
        int n = int.Parse(ReadLine());

        int result = functionAckermann(m, n);
        WriteLine("A(" + m + "," + n + ") = " + result);
    }

    public static int functionAckermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return functionAckermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return functionAckermann(m - 1, functionAckermann(m, n - 1));
        }
        else
        {
            return 0;
        }
    }
}