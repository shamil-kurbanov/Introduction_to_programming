//class task_4
using static System.Console;
using System;

namespace Seminar_1
{
    class Task_4
    {
        public static void Main()
        {
            WriteLine("# <Task 4> #");
            WriteLine("Write a program that takes three numbers as input and outputs which number is max");
            WriteLine("-----------------------------------------");

            int a = PromptForNumber("Input first number: ");
            int b = PromptForNumber("Input second number: ");
            int c = PromptForNumber("Input third number: ");

            if (a == b && b == c)
            {
                WriteLine("Numbers are equal");
                WriteLine("--> {0} = {1} = {2}", a, b, c);
            }
            else
            {
                int max = FindMax(a, b, c);
                WriteLine("Max number is {0}", max);
            }

            WriteLine();
            WriteLine("-----------------------------------------");
        }

private static int PromptForNumber(string prompt)
{
    while (true)
    {
        try
        {
            Write(prompt);
            return Convert.ToInt32(ReadLine());
        }
        catch (FormatException)
        {
            WriteLine("Invalid input. Please enter a number.");
        }
    }
}


        private static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
            }
            return max;
        }
    }
}
