using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 4
            // * Create four methods for calculation sum, substract, multiplication and division of two numbers.
            // * Create a function called calculator, that has three parameters. The first one is operator and then two numbers.
            // * Depending on the value of the operator, call the corresponding function from the four ones
            //                                                                          from above.

            Console.WriteLine("Choose an operator +, -, * or /");
            string operation = Console.ReadLine();

            if (operation != "-" && operation != "+" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid operator");
                return;
            }
            Console.WriteLine("Enter the first number");
            bool firstParsingResult = int.TryParse(Console.ReadLine(), out int firstNum);

            Console.WriteLine("Enter the second number");
            bool secondParsingResult = int.TryParse(Console.ReadLine(), out int secondNum);

            if (!firstParsingResult || !secondParsingResult)
            {
                Console.WriteLine("Invalid inputs for numbers");
                return;
            }

            if (operation == "+")
            {
                int result = Sum(firstNum, secondNum);
                Console.WriteLine($"Sum of the numbers: {result}");
            }
            else if (operation == "-")
            {
                int result = Subtraction(firstNum, secondNum);
                Console.WriteLine($"Subtraction result: {result}");
            }
            else if (operation == "*")
            {
                int result = Multiplication(firstNum, secondNum);
                Console.WriteLine($"Multiplication result: {result}");
            }
            else if (operation == "/")
            {
                int result = Division(firstNum, secondNum);
                Console.WriteLine($"Division result: {result}");
            }
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
