using System;
using Task_2___GetPersonStats.Models;

namespace Task_2___GetPersonStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 2
            // * Create a class Human
            // * Add properties: FirstName, LastName, Age
            // * Create a method called GetPersonStats that returns the full name of the human as well as their age
            // * Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
            // * Call the GetPersonStats method and print the result in the console after the object is created

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            bool success = int.TryParse(Console.ReadLine(), out int age);

            Human human = new Human();
            human.FirstName = firstName;
            human.LastName = lastName;
            human.Age = age;

            Console.WriteLine(human.GetPersonStats(firstName, lastName, age));
        }
    }
}
