/*
Task_34.cs
Specify an array filled with random positive three-digit numbers. 
Write a program to show the number of even numbers in an array.
[345, 897, 568, 234] -> 2
[234, 567, 789, 123] -> 1
[234, 567, 789, 123, 456] -> 2
*/

using System;
using static System.Console;

namespace Seminar_5;
    public class Task_34
    {
        // FunctionEvenNumbersInArray
        /* This function fills an array with random positive 
         * three-digit numbers and displays the number of even 
         * numbers in an array.
        */
        public static void FunctionEvenNumbersInArray(){
            int[] array = new int[10]; // Array of 10 elements
            Random random = new Random();
            int evenNumber = 0; // Number of even numbers in an array

            // Filling an array with random positive three-digit numbers
            for(int i = 0; i < array.Length; i++){
                array[i] = random.Next(100, 1000);
                if(array[i] % 2 == 0){
                    evenNumber++; // Counting the number of even numbers in an array
                }
            }

            // Displaying an array
            WriteLine("Array: ");	
            Write("[ ");
            for(int i = 0; i < array.Length; i++){
                Write($"{array[i]} ");
            }
            Write("]");

            // Displaying the number of even numbers in an array
            WriteLine($"\nThe number of even numbers in an array: {evenNumber}");
        }

    }