using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public CEO(string firstName, string lastName, Role role, double salary, int shares, Employee[] employees): base(firstName, lastName, role, salary)
        {
              Shares = shares;
              Employees = employees;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }

        public void PrintEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee.FirstName);
            }
        }


    }

}
