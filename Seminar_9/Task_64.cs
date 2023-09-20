/*
Set the value to N. 
Write a program that prints all natural numbers in the range from N to 1. 
Execute using recursion.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


using System;
using static System.Console;

namespace Seminar_9;

public class Task_64
{
//FuctionPrintNaturalNumbersFromNtoOne
    public static void promptForTask64()
    {
        Write("Enter N: ");
        int n = int.Parse(ReadLine());

        if (n >= 1)
        {
            Write("Natural numbers from " + n + " to 1: ");
            fuctionPrintNaturalNumbersFromNtoOne(n);
            WriteLine();
        }else{
            WriteLine("N must be greater than 0");
        }
    }

    public static void fuctionPrintNaturalNumbersFromNtoOne(int n)
    {
        if (n >= 1)
        {
            Write(n);
            if (n != 1)
            {
                Write(", ");
            }
        fuctionPrintNaturalNumbersFromNtoOne(n - 1); //recursion call
        }
        
    }



}