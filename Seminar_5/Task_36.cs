//Task_36: Define a one-dimensional array filled with random numbers. 
//Find the sum of elements in odd positions.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;
using static System.Console;

namespace Seminar_5;
    public class Task_36
    {
        public static void FunctionSumOfElemInOddPos(){
            int[] array = new int[10]; // Array of 10 elements
            Random random = new Random();
            int sum = 0; // Sum of elements in odd positions

            // Filling an array with random numbers
            for(int i = 0; i < array.Length; i++){
                array[i] = random.Next(-10, 10);
                if(i % 2 != 0){
                    sum += array[i]; // Sum of elements in odd positions
                }
            }

            // Displaying an array
            WriteLine("Array: ");	
            Write("[ ");
            for(int i = 0; i < array.Length; i++){
                Write($"{array[i]} ");
            }
            Write("]");

            // Displaying the sum of elements in odd positions
            WriteLine($"\nThe sum of elements in odd positions: {sum}");
        }
        

    }