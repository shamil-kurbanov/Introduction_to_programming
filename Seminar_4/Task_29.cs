/*Task_29: Write a program that takes an array of  elements and 
prints them to the screen.
the user himself determines the length of the array, 
as well as the min and max range of the random number.
*/
using System;
using static System.Console;

namespace Seminar_4;

public class Task_29
{
    public static void FunctionArray()
    {
        WriteLine();
        WriteLine("Task 29: Write a program that takes an array of  elements and prints them to the screen.");
        WriteLine("The user himself determines the length of the array, as well as the min and max range of the random number.");
        WriteLine();

        WriteLine("Enter the length of the array: ");
        int length = int.Parse(ReadLine());

        WriteLine("Enter the min range of the random number: ");
        int min = int.Parse(ReadLine());

        WriteLine("Enter the max range of the random number: ");
        int max = int.Parse(ReadLine());

        int[] array = new int[length];

        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }

        WriteLine("The array is: ");
        Write('[');
        foreach (int item in array)
        {
            Write(item + " ");
        }
        Write(']' + "\n");
        WriteLine("--------------------------------");
    }
}