using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        // ## Task 1
        // Extend the exercise for Employees with two more Employees.
        // Add a class called Contractor that inherits from Employee.The employee should have properties: WorkHours(double ), PayPerHour(int ) and Responsible(Manager (object )).
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        // * The GetSalary method should be overridden to return WorkHours* PayPerHour and also change the Salary property to that amount
        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        // * A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor
        public Manager CurrentPosition()
        {
            return Responsible;
        }

    }
}
