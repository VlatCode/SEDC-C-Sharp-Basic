using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 1
            // * Give the user an option to input 5 numbers
            // * Store all numbers in a QUEUE
            // * When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

            Queue<int> userInput = new Queue<int>();

            Console.WriteLine("Please enter your 5 numbers");
            int number;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter number {i + 1}: ");

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine($"Please enter number {i + 1}");
                }

                userInput.Enqueue(number);
            }

            Console.WriteLine("Your queue of numbers: ");
            foreach (var numbers in userInput)
            {
                Console.WriteLine(numbers);
            }

            
        }
    }
}
