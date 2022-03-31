using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CEO : Employee
    {
        // * Make a new class CEO that inherits from Employee that will have a property Employees ( an array of Employees), Shares property ( int ), SharesPrice ( double )
        // * The shares price should not be accessed from outside of the class - This is why it's private
        public string[] Employees { get; set; }

        public int Shares { get; set; }

        private double _sharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, int shares, string[] employees)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Shares = shares;
            Employees = employees;
        }

        // * There should be a method called AddSharesPrice() that will accept a double number and it will change the SharesPrice.
        public double AddSharesPrice(double number)
        {
            _sharesPrice += number;

            return _sharesPrice;
        }

        // * The CEO should have a method called PrintEmployees() that will print all employees that work for his company. 
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");

            foreach (string employees in Employees)
            {
                Console.WriteLine(employees);
            }
        }

        // * The CEO should override the GetSalary method to return Salary + Shares * SharesPrice
        public override double GetSalary()
        {
            Salary += (Shares * _sharesPrice);
            Console.WriteLine($"Salary of CEO is: {Salary}");
            return Salary;
        }
    }
}
