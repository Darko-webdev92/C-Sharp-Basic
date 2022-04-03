using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstName, string secondName,Role role, double salary ) 
            : base(firstName, secondName, Role.Sales, 500)
        {

        }

        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            int bonus = 0;
            if(SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }else if(SuccessSaleRevenue >2000 && SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }else if(SuccessSaleRevenue > 5000)
            {
                bonus = 1500;
            }

            return Salary + bonus;
        }
    }
}
