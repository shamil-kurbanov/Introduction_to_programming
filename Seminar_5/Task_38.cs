/*
 * Task: 38
 * Specify an array of real numbers. Find the difference between the maximum and minimum elements of an array.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

*/

using System;
using static System.Console;

namespace Seminar_5;

public class Task_38
    {
        public static void FuncDiffBetweenMaxAndMinInArray(){
            // Random Array of real numbers
            double[] array = new double[10]; // Array of 10 elements	
            Random random = new Random();
            double max = 0; // Maximum element of an array
            double min = 0; // Minimum element of an array
            double diff = 0; // Difference between the maximum and minimum elements of an array

            // Filling an array with random real numbers
            for(int i = 0; i < array.Length; i++){
                array[i] = random.NextDouble() * 100;
                if(i == 0){
                    max = array[i];
                    min = array[i];
                }
                if(array[i] > max){
                    max = array[i]; // Maximum element of an array
                }
                if(array[i] < min){
                    min = array[i]; // Minimum element of an array
                }
            }

            // Displaying an array
            WriteLine("Array: ");
            Write("[ ");
            for(int i = 0; i < array.Length; i++){
                Write($"{array[i]:F2} ");
            }
            Write("]");

            // Displaying the difference between the maximum and minimum elements of an array
            diff = max - min;
            WriteLine($"\n The maximum element: {max:F2}");
            WriteLine($"The minimum element: {min:F2}");
            WriteLine($"\nThe difference between the max and min elements of the array: ");
            WriteLine($"{max:F2} - {min:F2} = {diff:F2}");

        }
    }
