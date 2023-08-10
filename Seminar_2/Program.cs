//Write a program that takes a three-digit number as input and outputs the second digit of that number
//on the console.

using System;
using static System.Console;
using static Seminar_2.Task_10_GetSecondDigit;
using static Seminar_2.Task_13_GetThirdDigit;
using static Seminar_2.Task_14_CheckIfHoliday;


namespace Seminar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSecondDigit(0);
            
            WriteLine("Want you other three-digit number to be calculated?");
            WriteLine("Enter 'y' for yes or 'n' for no: ");
            string answer = ReadLine(); 
            
            switch (answer)
            {
                case "y":
                    GetSecondDigit(0);
                    break;
                case "n":
                    WriteLine("Good bye!");
                    break;
                default:
                    WriteLine("Invalid input!");
                    break;
            }

            GetThirdDigit(0);
            CheckIfHoliday(0);
            
        }
    }
}