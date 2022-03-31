using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 2
            //  * Take a sentence as input and find its words.

            Console.WriteLine("Enter a string:");
            string mainString = Console.ReadLine();

            string[] smallerStrings = mainString.Split(' ');
            foreach (string item in smallerStrings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
