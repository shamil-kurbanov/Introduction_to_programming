//class task_4
using static System.Console;
using System;

namespace Seminar_1;
    class Task_4_1
    {
        public static void FunctionMax(int a, int b, int c){
            WriteLine("# <Task 4> #");
            WriteLine("Write a program that takes three numbers as input and outputs which number is max");
            WriteLine("-----------------------------------------");

            a = PromptForNumber("Input first number: ");
            b = PromptForNumber("Input second number: ");
            c = PromptForNumber("Input third number: ");

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

            
    }

public static int PromptForNumber(string prompt)
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
    
