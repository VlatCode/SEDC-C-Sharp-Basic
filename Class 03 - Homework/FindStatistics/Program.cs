using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 1
            // Create new console application “FindStatistics”. Input 2 numbers. If the two of them are even, print their sum,
            // if one of them is odd, print their difference, if the two off them are odd, multiply them. Don't print just the result,
            // but also the whole operation. Treat zero as even.
            // Please find example below:
            // * Test Data:
            // * Input the First Number: 8
            // * Input the Second Number: 5
            // * Expected Output:
            // * One of the numbers is odd. The operation and result are 8 - 5 = 3.

            Console.WriteLine("Enter first number");
            bool parseResult1 = int.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter second number");
            bool parseResult2 = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (parseResult1 && parseResult2)
            {
                if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                {
                    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
                }
                else if (firstNumber % 2 == 1 && secondNumber % 2 == 1)
                {
                    Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
                }
                else if (firstNumber % 2 == 1 || secondNumber % 2 == 1)
                {
                    Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }
}
