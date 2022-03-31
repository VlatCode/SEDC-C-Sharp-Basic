using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 3:
            // Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
            // Please find example below:
            // * Test Data:
            // * Input the First Number: 5
            // * Input the Second Number: 8
            // * Expected Output:
            // * After Swapping:
            // * First Number: 8
            // * Second Number: 5

            int firstInput, secondInput, tempVariable;

            Console.WriteLine("Enter your First number:");
            while (!Int32.TryParse(Console.ReadLine(), out firstInput))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter the 1st number: ");
            }

            Console.WriteLine("Enter your Second number:");
            while (!Int32.TryParse(Console.ReadLine(), out secondInput))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter the 1st number: ");
            }

            tempVariable = firstInput;
            firstInput = secondInput;
            secondInput = tempVariable;

            Console.WriteLine($"Result after swapping: First number: {firstInput}, Second number: {secondInput}");
        }
    }
}
