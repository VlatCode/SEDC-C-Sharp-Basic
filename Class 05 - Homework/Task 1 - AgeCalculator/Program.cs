using System;

namespace Task_1___AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Task 1
            // * Make a method called AgeCalculator
            // * The method will have one input parameter, your birthday date
            // * The method should return your age
            // * Show the age of a user after he inputs a date

            // > Note: take into consideration if the birthday is today, after or before today

            Console.WriteLine("Please enter your date of birth in the following order: mm/dd/yy");

            DateTime dateTime = UserInput();
            int age = AgeCalculator(dateTime);
            Console.WriteLine($"You are {age} years old!");
        }

        public static DateTime UserInput()
        {
            DateTime birthDay;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
            {
                Console.WriteLine("Invalid input! Please enter your date of birth in the correct order: mm/dd/yy ");
            }
            return birthDay;
        }
        public static int AgeCalculator(DateTime input)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - input.Year;
            if (today.Month < input.Month && today.Month == input.Month)
            {
                age--;
            }
            return age;
        }
    }
}
