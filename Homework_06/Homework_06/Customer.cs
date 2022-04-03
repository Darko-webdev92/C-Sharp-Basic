using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_06
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public long CardNumber { get;}
        internal int Pin { get; set; }
        private decimal Balance { get; set; }

        public bool Blocked { get; set; }
        public Customer(string firstName, string lastName, long cardNumber, int pin, decimal balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
        
        public decimal CheckBalance()
        {
            return Balance;
        }

        public void CashWithdrawal(decimal withdrawal)
        {
                Balance = Balance - withdrawal;
        }

        public void CashDeposit(decimal cash)
        {
            Balance = Balance + cash;
        }
    }

}
