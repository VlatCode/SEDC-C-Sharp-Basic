using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2___GetPersonStats.Models
{
    public class Human
    {
        // ## Task 2
        // * Create a class Human
        // * Add properties: FirstName, LastName, Age
        // * Create a method called GetPersonStats that returns the full name of the human as well as their age
        // * Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
        // * Call the GetPersonStats method and print the result in the console after the object is created

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            return $"{firstName} {lastName} is {age} years old.";
        }
    }
}
