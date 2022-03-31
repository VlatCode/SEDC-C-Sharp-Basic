using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 2
            // Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            // * Test Data:
            // * Enter the First number: 10
            // * Enter the Second number: 15
            // * Enter the third number: 20
            // * Enter the four number: 30
            // * Expected Output:
            // * The average of 10, 15, 20 and 30 is: 18

            int firstInput;
            int secondInput;
            int thirdInput;
            int fourthInput;

            Console.WriteLine("Please enter your first input:");
            firstInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second input:");
            secondInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your third input:");
            thirdInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your fourth input:");
            fourthInput = Convert.ToInt32(Console.ReadLine());

            int result = (firstInput + secondInput + thirdInput + fourthInput) / 4;
            Console.WriteLine($"The average of the four numbers you entered is: {result}");
        }
    }
}
