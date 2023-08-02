//class task_4
using static System.Console;
using System;

/*
 * Write a program that takes two numbers as input and outputs which number is greater and which is less.
*/
namespace Seminar_1
{
    class task_4
    {
        public static void FunctionMax( int a, int b, int c)
        {
            WriteLine();
            WriteLine("# <Task 4> #");
            WriteLine("Write a program that takes tree numbers as input and outputs which number is max");
            WriteLine("-----------------------------------------");
            //input first number
            Write("Input first number: ");
            a = Convert.ToInt32(ReadLine());
            //input second number
            Write("Input second number: ");
            b = Convert.ToInt32(ReadLine());

            //input third number
            Write("Input third number: ");
            c = Convert.ToInt32(ReadLine());

            //check which number is max
            if (a > b && a > c)
            {
                WriteLine("First number is max");
                WriteLine("--> {0} > {1} and {0} > {2}", a, b, c);
            }
            else if (b > a && b > c)
            {
                WriteLine("Second number is max");
                WriteLine("--> {0} > {1} and {0} > {2}", b, a, c);
            }
            else if (c > a && c > b)
            {
                WriteLine("Third number is max");
                WriteLine("--> {0} > {1} and {0} > {2}", c, a, b);
            }
            else
            {
                WriteLine("Numbers are equal");
                WriteLine("--> {0} = {1} = {2}", a, b, c);
            }

            WriteLine();
            WriteLine("-----------------------------------------");
            WriteLine();


        }
    }
}