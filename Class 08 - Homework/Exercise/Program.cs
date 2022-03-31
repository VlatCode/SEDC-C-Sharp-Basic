using Domain.Enums;
using Domain.Models;
using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee()
            //{
            //    FirstName = "Marko",
            //    LastName = "Markovski",
            //    Role = RoleEnum.Other
            //};
            //employee.PrintInfo();

            //// Object instanced from SalesPerson constructor with parameters firstName and lastName
            //SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            //salesPerson.AddSuccessRevenue(300);
            //Console.WriteLine($"Salesperson salary: {salesPerson.GetSalary()}");

            //// Object instanced from Manager constructor with parameters firstName, lastName and salary
            //Manager manager = new Manager("Bill", "Billsky", /* salary */ 700);
            //Console.WriteLine($"Manager salary: {manager.GetSalary()}");
            //manager.AddBonus(200);
            //manager.AddBonus(100);
            //Console.WriteLine($"Manager salary with bonus: {manager.GetSalary()}");

            /////
            ///

            // Task 2
            Console.WriteLine("-----TASK 2-----");

            Contractor contractor01 = new Contractor
            {
                FirstName = "Bob",
                LastName = "Bobsky"
            };

            Contractor contractor02 = new Contractor
            {
                FirstName = "Bill",
                LastName = "Billsky"
            };

            // Made out of a default constructor from the Manager class, because if we used the Manager constructor we would have to include a salary, which is not needed in this task
            Manager manager01 = new Manager
            {
                FirstName = "Rob",
                LastName = "Robsky"
            };

            // Made out of a default constructor from the Manager class, because if we used the Manager constructor we would have to include a salary, which is not needed in this task
            Manager manager02 = new Manager
            {
                FirstName = "Pete",
                LastName = "Petesky"
            };

            // Made out of the SalesPerson constructor with parameters from the SalesPerson class
            SalesPerson salesMan = new SalesPerson("Matt", "Mattsky");

            // * Make an array called Company with 2 contractors, 2 managers and 1 salesPerson
            // *** I had to create the objects above in order to create this array
            object[] company = new object[5] { contractor01, contractor02, manager01, manager02, salesMan };

            // * Create a new instance of CEO and call: ceoName.PrintInfo(), ceoName.PrintEmployees() and ceoName.GetSalary() to check if everything is working.
            CEO ceo = new CEO("John", "Johnsky", 1500, 14, new string[] { "Bob Bobsky", "Bill Billsky", "Rob Robsky", "Pete Petesky", "Matt Mattsky" });

            Console.WriteLine("CEO:");
            ceo.AddSharesPrice(100);
            ceo.PrintInfo();
            ceo.GetSalary();
            ceo.PrintEmployees();
        }
    }
}
