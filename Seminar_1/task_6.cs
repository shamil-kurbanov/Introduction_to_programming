//class task_6
using static System.Console;
using System;

/*
 * Write a program that takes a number as input and returns whether the number is even or not.
*/
namespace Seminar_1
{
    class task_6
    {
        public static void FunctionEvenOrNot( int number)
        {
            WriteLine();
            WriteLine("# <Task 6> #");
            WriteLine("Write a program that takes a number as input and returns whether the number is even or not.");
            WriteLine("-----------------------------------------");
            //input number
            Write("Input your number: ");
            number = Convert.ToInt32(ReadLine());
            //check if number is even or not

            if(number % 2 == 0){
                WriteLine("Number is even");
                WriteLine("--> {0} % 2 = 0", number);
            }
            else{
                WriteLine("Number is not even");
                WriteLine("--> {0} % 2 != 0", number);
            }

            WriteLine();
            WriteLine("-----------------------------------------");
            WriteLine();


        }
    }
}