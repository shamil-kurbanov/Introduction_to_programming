/*Task 41: The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223->3
*/

using System;

namespace CountPositiveNumbers
{
    public class Task_41
    {
        public static void FunctionCountPositiveNumbers()
        {
            try
            {
                int M = PromptForInt("Enter the number of values (M): ", "Please enter a valid positive integer for M.", minValue: 1);

                int[] numbers = new int[M];
                for (int i = 0; i < M; i++)
                {
                    numbers[i] = PromptForInt($"Enter number {i + 1}: ", "Please enter a valid integer.");
                }

                int countPositive = NumberAnalyzer.CountPositiveNumbers(numbers);
                Console.WriteLine($"Number of values greater than 0: {countPositive}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static int PromptForInt(string prompt, string errorMessage, int? minValue = null)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && (!minValue.HasValue || value >= minValue.Value))
                {
                    return value;
                }
                Console.WriteLine(errorMessage);
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
