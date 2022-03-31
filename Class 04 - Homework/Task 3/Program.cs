using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 3
            // * Create a function that takes a number as input.
            // This method should return the sum of the digits in the number.

            int n, sum = 0, m;

            Console.WriteLine("Enter a number:");

            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }

            Console.WriteLine($"The sum of the digits in the entered number is {sum}");
        }
    }
}
