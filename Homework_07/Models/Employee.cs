using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        protected double Salary { get; set; }
        public Employee(string firstName,string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public string PrintInfo()
        {
            return $"{FirstName} {LastName} {Salary}"; 
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
