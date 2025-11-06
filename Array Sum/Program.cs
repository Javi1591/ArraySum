/*
Student Name: Xavier Nazario
COP2360 Sept. 12, 2024 - Assignment 7
Collaboration Statement: I worked on this myself.
I used my notes and rough hand-drawn sketch for the assignment.
    *** I'll hand-draw a sketch in order to plan how to code my programs. ***
*/

using System;

namespace Array_Sum;

class Program
{
    static void Main(string[] args)
    {
        // Declare numbers array[10]
        //  Use int, has 10 elements
        // Declare random variable
        // Declare cumulativeTotal variable
        //  Use int
        int[] numbers = new int[10];
        Random random = new Random();
        int cumulativeTotal = 0;

        // Add 100 random numbers: 1 - 100
        //  Use for loop, System.Random.Next(100)
        // Display output
        for (int i = 0; i < numbers.Length; i++)
        {
            // Get random numbers
            numbers[i] = random.Next(1, 101);
            // Add to cumulativeTotal
            cumulativeTotal += numbers[i];

            // Output values and cumulative total
            Console.WriteLine($"Printing element {i} with a value of {numbers[i]}. Running total: {cumulativeTotal}");
        }
    }
}
