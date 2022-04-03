using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHours { get; set; }
        public Manager Responsible { get; set; }
        public Contractor(string firstName, string lastName, Role role, double salary,double worksHours, int payPerHours, Manager responsible) : base(firstName, lastName, role, salary)
        {  
           WorkHours = worksHours;
           PayPerHours = payPerHours;
           Responsible = responsible;
             
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHours;
            return Salary;
        }

        public Role CurrentPosition()
        {
            return Role.Manager;
        }

    }
}
