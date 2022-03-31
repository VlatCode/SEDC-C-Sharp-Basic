using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 1
            // * Take one string from the input and print its last 5 characters.

            Console.WriteLine("Enter a string:");
            string message = Console.ReadLine();

            string subString = message.Substring(message.Length-5);
            Console.WriteLine(subString);
        }
    }
}
