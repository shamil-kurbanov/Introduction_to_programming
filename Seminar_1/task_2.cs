//class task_2
using static System.Console;
using System;

/*
 * Write a program that takes two numbers as input and outputs which number is greater and which is less.
*/
namespace Seminar_1
{
    class task_2
    {
        public static void FunctionGreaterOrLess( int a, int b)
        {
            WriteLine();
            WriteLine("# <Task 2> #");
            WriteLine("Write a program that takes two numbers as input and outputs which number is greater and which is less.");
            WriteLine("-----------------------------------------");
            //input first number
            Write("Input first number: ");
            a = Convert.ToInt32(ReadLine());
            //input second number
            Write("Input second number: ");
            b = Convert.ToInt32(ReadLine());
            //check which number is greater and which is less
            if (a > b)
            {
                WriteLine("First number is greater than second number");
                WriteLine("--> {0} > {1}", a, b);
            }
            else if (a < b)
            {
                WriteLine("First number is less than second number");
                WriteLine("--> {0} < {1}", a, b);	
            }
            else
            {
                WriteLine("First number is equal to second number");
                WriteLine("--> {0} = {1}", a, b);
            }
            WriteLine();
            WriteLine("-----------------------------------------");
            WriteLine();




        }
    }
}