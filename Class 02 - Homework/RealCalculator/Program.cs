using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 1
            // Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.
            // * Test Data:
            // * Enter the First number: 10
            // * Enter the Second number: 15
            // * Enter the Operation: +
            // * Expected Output:
            // * The result is: 25

            int firstInput;
            int secondInput;

            Console.WriteLine("Enter your First number:");
            firstInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Second number:");
            secondInput = Convert.ToInt32(Console.ReadLine());

            string operation;
            int result;

            Console.WriteLine("Choose one of the following mathematical operations: +, -, * or /");
            operation = Console.ReadLine();
            if (operation == "+")
            {
                result = firstInput + secondInput;
                Console.WriteLine($"The result is: {result}");
            }
            else if (operation == "-")
            {
                result = firstInput - secondInput;
                Console.WriteLine($"The result is: {result}");
            }
            else if (operation == "*")
            {
                result = firstInput * secondInput;
                Console.WriteLine($"The result is: {result}");
            }
            else if (operation == "/")
            {
                result = firstInput / secondInput;
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("You enter invalid operation!");
            }
        }
    }
}
