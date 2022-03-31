using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 3
            // Ask the user to enter a number as an input.
            // Print all the numbers except the numbers divisible by 5.
            // When you come to 80, the limit is reached.

            Console.WriteLine("Enter a number:");
            bool success = int.TryParse(Console.ReadLine(), out int inputNumber);

            for (int i = 0; i <= inputNumber; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }

                if (i > 80)
                {
                    Console.WriteLine("The limit is reached");
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
