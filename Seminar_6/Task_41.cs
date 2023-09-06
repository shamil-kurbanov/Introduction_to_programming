/*Task 41: The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223->3
*/

using System;
using static System.Console;

namespace Seminar_6
{
    public class Task_41
    {
        public static void FunctionCountPositiveNumbers()
        {
            try
            {
                int M = PromptForInt("Enter the number of values (M): ", "Please enter a valid positive integer for M.", minValue: 1);

                int[] numbers = new int[M]; // Array of M elements
                for (int i = 0; i < M; i++) // Filling an array with M elements
                {
                    // Prompt the user to enter a number and store the number in the array
                    numbers[i] = PromptForInt($"Enter number {i + 1}: ", "Please enter a valid integer.");
                }

                int countPositive = NumberAnalyzer.CountPositiveNumbers(numbers); // Number of values greater than 0
                WriteLine($"Number of values greater than 0: {countPositive}"); // Displaying the number of values greater than 0
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static int PromptForInt(string prompt, string errorMessage, int? minValue = null)
        {
            int value; // Value entered by the user
            while (true) // Loop until we get a valid integer
            {
                Write(prompt);
                // Try to convert the entered text to an integer
                // If the text is not an integer, TryParse() will return false
                // If the text is an integer, TryParse() will return true and the integer value will be stored in the value variable
                // If the text is an integer but outside the range of an int, TryParse() will throw an OverflowException
                // !HasValue is true if minValue is null and false if minValue has a value
                if (int.TryParse(Console.ReadLine(), out value) && (!minValue.HasValue || value >= minValue.Value))
                {
                    return value; // Return the integer value
                }
                WriteLine(errorMessage);
            }
        }
    }

    public static class NumberAnalyzer
    {
        public static int CountPositiveNumbers(int[] numbers)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
