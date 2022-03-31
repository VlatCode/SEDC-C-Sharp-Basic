using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class SalesPerson : Employee
    {
        // Private property of type double
        private double _successSaleRevenue { get; set; }

        // Constructor with parameters
        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            // The properties below are specific for Sales
            Salary = 500;
            Role = RoleEnum.Sales;
        }

        // Method that adds revenue to our property _successSaleRevenue
        public void AddSuccessRevenue (double revenue)
        {
            _successSaleRevenue += revenue; 
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            // if (_successSaleRevenue <= 5000)
            // {
                return Salary + 1500;
            // }
        }
    }
}
