/*
Write a program that displays the third digit of a given number, or reports that there is no third digit.
645 -> 5
78 -> no third digit
32679 -> 6
*/

using System;
using static System.Console;

namespace Seminar_2
{
    class Task_13_GetThirdDigit
    {
        public static int GetThirdDigit(int number)
        {
            WriteLine();
            WriteLine("Task 13: Write a program that displays the third digit of a given number, or reports that there is no third digit.");

            try
            {
                WriteLine("Enter a number: ");
                number = int.Parse(ReadLine());

                if (number < 100)
                {
                    WriteLine("There is no third digit in the number: {0}", number);

                }
                else
                {
                    WriteLine("The third digit of the number is: {0}", number.ToString()[2]);
                }

                WriteLine();

            }
            catch (FormatException e)
            {
                WriteLine("Exception: {0}", e.Message);
                WriteLine("The number must be a three-digit number!");
            }

            return number;

        }
    }
}
