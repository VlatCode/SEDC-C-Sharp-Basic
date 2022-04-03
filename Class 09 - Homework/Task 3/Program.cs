using System;
using System.Collections.Generic;
using System.Linq;
using Task_3.Enums;
using Task_3.Models;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 3
            // * Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.

            List<Animal> animals = new List<Animal>()
            {
                new Animal() { Name = "Rex", Color = "Brown", Age = 3, Gender = GenderEnum.Male },
                new Animal() { Name = "Lea", Color = "Black", Age = 5, Gender = GenderEnum.Female },
                new Animal() { Name = "ThisIsALongName", Color = "White", Age = 2, Gender = GenderEnum.Female },
                new Animal() { Name = "Aron", Color = "Black", Age = 7, Gender = GenderEnum.Male },
                new Animal() { Name = "Jackson", Color = "Brown", Age = 1, Gender = GenderEnum.Male },
                new Animal() { Name = "Frankie", Color = "White", Age = 11, Gender = GenderEnum.Male },
                new Animal() { Name = "Ally", Color = "Brown", Age = 3, Gender = GenderEnum.Female },
            };

            // * Find the names of all the animals aged 5 or more
            List<Animal> agedFiveOrMore = animals.Where(a => a.Age >= 5).ToList();

            Console.WriteLine("1. Animals aged 5 or more: ");
            foreach (var animal in agedFiveOrMore)
            {
                    Console.WriteLine($"- {animal.Name}");
            }

            // * Find all the names of the animals that start with 'A'
            List<Animal> nameStartsWithA = animals.Where(b => b.Name.StartsWith("A")).ToList();

            Console.WriteLine("2. Animals whose names start with 'A': ");
            foreach (var animal in nameStartsWithA)
            {
                    Console.WriteLine($"- {animal.Name}");
            }

            // * Find all male, brown animals
            List<Animal> maleBrownAnimals = animals.Where(c => c.Gender == GenderEnum.Male && c.Color == "Brown").ToList();

            Console.WriteLine("3. Male, brown animals: ");
            foreach (var animal in maleBrownAnimals)
            {
                    Console.WriteLine($"- {animal.Name}");
            }

            // * Find the first animal whose name is longer than 10 characters
            List<Animal> nameLongerThan10 = animals.FirstOrDefault(d => d.Name.Length > 10).ToList();

            Console.WriteLine("4. Animals whose name is longer than 10 characters: ");
            foreach (var animal in nameLongerThan10)
            {
                    Console.WriteLine($"- {animal.Name}");
            }
        }
    }
}
