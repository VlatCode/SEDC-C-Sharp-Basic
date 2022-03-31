using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 4
            // * Make a new console application.
            // * Create an array of 10 whole numbers(integers). 
            // * Find the minimum and maximum and print them in the console.

            int[] integerArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            int i, max, min, n;
            
            n = 10;
            max = integerArray[0];
            min = integerArray[0];

            for (i = 1; i < n; i++)
            {
                if (integerArray[i] > max)
                {
                    max = integerArray[i];
                }

                if (integerArray[i] < min)
                {
                    min = integerArray[i];
                }
            }

            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
        }
    }
}
