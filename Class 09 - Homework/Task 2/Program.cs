using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Task 2
            //* Create a list of ten numbers.
            //* Use LINQ to select in a list of the squares of all the numbers in the list from above.

            List<int> integersList = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                integersList.Add(random.Next(1, 100));
            }

            List<int> squaredInts = integersList.Select(n => n * n).ToList();
            Console.WriteLine("List of squared numbers: ");
            foreach (int squares in squaredInts)
            {
                Console.WriteLine(squares);
            }
        }
    }
}
