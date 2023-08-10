using System;
using static System.Console;

namespace Seminar_2;

public class Task_10_GetSecondDigit
{
    public static int GetSecondDigit(int number)
    {
        try
        {
            WriteLine("Enter a three-digit number: ");
            number = int.Parse(ReadLine());

            if (number < 100 || number > 999)
            {
                throw new FormatException("The number must be a three-digit number!");
            }
            else
            {
                int secondDigit = (number / 10) % 10;
                WriteLine("The second digit of the number is: {0}", secondDigit);
            }


        }
        catch (FormatException e)
        {
            WriteLine("Exception: {0}", e.Message);
            WriteLine("The number must be a three-digit number!");
        }

        return number;
    }
}