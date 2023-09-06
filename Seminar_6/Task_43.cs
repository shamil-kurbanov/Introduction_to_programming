/*
Task 43: 
Write a program that will find the point of intersection of 
two lines given by the equations y = k1 * x + b1, y = k2 * x + b2; 
the values b1, k1, b2 and k2 are set by the user.
For Example: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0.5; -0.5)
*/

using System;
using static System.Console;

namespace Seminar_6;

public class Task_43
    {
        public static void FunctionLineIntersection()
        {
            WriteLine();
            WriteLine("Task 43. \n ***** Welcome to the Line Intersection Calculator! *****");
            WriteLine("Write a program that will find the point of intersection of ");
            WriteLine("two lines given by the equations y = k1 * x + b1, y = k2 * x + b2; ");

            try
            {
                Write("Enter the value of k1: ");
                double k1 = Convert.ToDouble(ReadLine());

                Write("Enter the value of b1: ");
                double b1 = Convert.ToDouble(ReadLine());

                Write("Enter the value of k2: ");
                double k2 = Convert.ToDouble(ReadLine());

                Write("Enter the value of b2: ");
                double b2 = Convert.ToDouble(ReadLine());

                if (k1 == k2)
                {
                    WriteLine("The lines are parallel. They do not intersect.");
                }
                else{
                    double x = (b2 - b1) / (k1 - k2);
                    double y = k1 * x + b1;

                    WriteLine($"The point of intersection is ({x}, {y})");
                }

            }
            catch (FormatException)
            {
                WriteLine($"Invalid input. Please enter a valid numeric values for k1, b1, k2 and b2");
            }
            catch(DivideByZeroException)
            {
                WriteLine("The lines are parallel. They do not intersect.");
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }