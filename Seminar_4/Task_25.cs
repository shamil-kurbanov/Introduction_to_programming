using System;
using static System.Console;

namespace Seminar_4
{
    public class Task_25
    {
        //Task_25: Write a loop that takes two numbers (A and B) as input and raises A to the power of B.
        //3, 5 -> 243 (3⁵)
        //2, 4 -> 16

        public static void FunctionAPowerOfB()
        {
            WriteLine();
            WriteLine("Task 25: Write a loop that takes two numbers (A and B) as input and raises A to the power of B.");
            WriteLine("Enter a number A: ");
            int A = int.Parse(ReadLine());
            WriteLine("Enter a number B: ");
            int B = int.Parse(ReadLine());
            int result = 1;

            if (B < 0){
                WriteLine("Exponent B must be not less als 0");
            }else{

                for (int i = 0; i < B; i++)
                {
                    result *= A;
                }
            WriteLine("{0} to the power of {1} is: {2}", A, B, result);
            WriteLine();
            }
            WriteLine("--------------------------------");
        }

    }
}