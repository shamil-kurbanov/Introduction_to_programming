//class task_8
using static System.Console;
using System;

/*
 * Write a program that takes a number as input and returns whether the number is even or not.
*/
namespace Seminar_1
{
    class task_8
    {
        public static void FunctionAllEvenNumbers( int N)
        {
            WriteLine();
            WriteLine("# <Task 8> #");
            WriteLine("Write a program that takes a number (N) as input and outputs all even numbers from 1 to N");
            WriteLine("-----------------------------------------");
            //input number
            Write("Input N: ");
            N = Convert.ToInt32(ReadLine());
            //all even numbers from 1 to N after another in string
            WriteLine("All even numbers from 1 to {0}:", N);

           //let's create an array:
            int[] arr = new int[N];
            for(int i = 0; i < N; i++){
                arr[i] = i + 1;
            } 

            //and now we sort the array , it should only contain all even numbers from 1 to N:
            for(int i = 0; i < N; i++){
                if(arr[i] % 2 == 0){
                    Write("{0} ", arr[i]);
                }
            }

            WriteLine();
            WriteLine("-----------------------------------------");
            WriteLine();
        }
    }
}
