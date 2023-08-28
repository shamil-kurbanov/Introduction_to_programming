        /*
        Write a function that takes a number as input and outputs the sum of the digits in the number.
        452 -> 11
        82 -> 10
        9012 -> 12
        */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Seminar_4;
public class Task_27
{
        public static void FunctionSumOfDigits()
        {
        WriteLine();
        WriteLine("Task 27: Write a function that takes a number as input and outputs the sum of the digits in the number.");

        WriteLine("Enter a number: ");
        int number = int.Parse(ReadLine());

        WriteLine("The sum of the digits in the number is: " + SumOfDigits(number));
        static int SumOfDigits(int number)
        {
                int sum = 0;

                while (number > 0)
                {
                sum += number % 10; // add the last digit to the sum
                number /= 10; // remove the last digit from the number
                }

                return sum;
        }
        WriteLine();
        WriteLine("--------------------------------");
        }
}