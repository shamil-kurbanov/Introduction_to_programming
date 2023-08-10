//Write a program that takes as input a number representing the day of the week and checks if that day is a holiday.

using System;
using static System.Console;

namespace Seminar_2
{
    class Task_14_CheckIfHoliday
    {
        public static int CheckIfHoliday(int day)
        {
            WriteLine();
            WriteLine("Task 14: Write a program that takes as input a number representing the day of the week and checks if that day is a holiday.");
            WriteLine("Enter a number from 1 to 7: ");
            day = int.Parse(ReadLine());

            switch(day){
                case 1:
                    WriteLine("Monday is not a holiday!");
                    break;
                case 2:
                    WriteLine("Tuesday is not a holiday!");
                    break;
                case 3:
                    WriteLine("Wednesday is not a holiday!");
                    break;
                case 4:
                    WriteLine("Thursday is not a holiday!");
                    break;
                case 5:
                    WriteLine("Friday is not a holiday!");
                    break;
                case 6:
                    WriteLine("-->Saturday is a holiday!<--");
                    break;
                case 7:
                    WriteLine("-->Sunday is a holiday!>--");
                    break;
                default:
                    WriteLine("Invalid input!");
                    break;
            }

            WriteLine();

            return day;
        }
    }
}