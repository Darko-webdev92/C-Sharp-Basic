using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Homework_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer darko = new Customer("Darko", "Angelovski", 10L, 1234, 1000);

            List<Customer> customers = new List<Customer>() { darko};

            Console.WriteLine("Welcome to the ATM app \n");
            
            short userCounter = 0;
           
            while (true)
            {
                bool continueLogging = true;

                Console.WriteLine("1. Register new card \n" + "2. Log in with your card");
                string registerOrLogin = Console.ReadLine();

                if (registerOrLogin != "1" && registerOrLogin != "2")
                {
                    Console.WriteLine("Please enter 1 or 2");
                    continue;
                }

                if (registerOrLogin == "1")
                {
                    {
                        customers.Add(RegisterNewAccount(customers));
                        Console.WriteLine("Than you for registering..");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Welcome to the ATM app \n");

                        continue;
                    }
                }
                else if(registerOrLogin == "2")
                {
                    string inputCardNumber;

                    while (true)
                    {
                        Console.WriteLine("Please enter your card number:");
                        inputCardNumber = Console.ReadLine().Trim();

                        if (!ValidateCustomerCardNumber(inputCardNumber.Replace("-", ""), customers))
                        {
                                Console.WriteLine("This card number does not exits");
                                continue;
                        }
                        else
                        {
                            Customer customer = customers.Find(cust => cust.CardNumber.ToString() == inputCardNumber);
                            
                            if (customer.Blocked == true)
                            {
                                Console.WriteLine("Your card number is blocked. ");
                                continueLogging = false;
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Welcome to the ATM app \n");

                                break;
                            }
                            break;
                        }
                    }

                    if(continueLogging == true)
                    {
                        string inputPin;

                        while (true)
                        {
                            Console.WriteLine("Enter Pin:");
                            inputPin = Console.ReadLine().Trim();

                            Customer customer;

                            if (!ValidateCustomer(inputCardNumber, inputPin, customers, userCounter))
                            {
                                if (userCounter >= 2)
                                {
                                    Console.WriteLine("You card number is blocked !!! Please contact our support team to unblock your card");
                                    break;
                                }
                                else
                                {
                                    userCounter++;
                                    continue;
                                }
                            }
                            else
                            {
                                customer = customers.Find(cust => cust.CardNumber.ToString() == inputCardNumber);

                                bool firstYes = true;
                                while (true)
                                {

                                    if (firstYes)
                                    {
                                        CustomerOption(customer);
                                        firstYes = false;
                                    }

                                    Console.WriteLine("Do you want to do another action. ");
                                    Console.WriteLine("Enter Y if you want to do another action");
                                    string anotherAction = Console.ReadLine().Trim();

                                    if (anotherAction.ToLower() == "y")
                                    {
                                        CustomerOption(customer);
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("GOODBYE");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("Welcome to the ATM app \n");

                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        public static bool ValidateCustomerCardNumber(string cardNumber, List<Customer> customers)
        {
            bool customerDoesExists = customers.Any(cust => cust.CardNumber.ToString() == cardNumber);

            return customerDoesExists;
        }

            


        public static bool ValidateCustomer(string cardNumber, string pin, List<Customer> customers, int userCounter)
        {
            bool success = false;
            bool customerDoesExists = customers.Any(cust => cust.CardNumber.ToString() == cardNumber);

            while (true)
            {
                if (customerDoesExists)
                {
                    Customer customer = customers.Find(cust => cust.CardNumber.ToString() == cardNumber);
                   
                    if (customer.CardNumber.ToString() == cardNumber)
                    {

                        if ((cardNumber.Replace("-", "") == customer.CardNumber.ToString()) && (pin == customer.Pin.ToString()) && (customer.Blocked == false))
                        {
                            Console.WriteLine($"Welcome {customer.FullName}");
                            success = true;
                            break;

                        }else if((cardNumber.Replace("-", "") == customer.CardNumber.ToString()) && (pin == customer.Pin.ToString()) && (customer.Blocked == true))
                        {
                            Console.WriteLine("Your card is blocked");

                            break;
                        }
                        else
                        {
                            ++userCounter;

                            if (userCounter <= 2)
                            {
                                Console.WriteLine("Please enter valid pin");
                                
                                break;
                            }

                            customer.Blocked = true;
                            break;
                        }

                    }
                }

                
            }
            return userCounter <= 2 && success == true ? true : false;
        }

            public static void CustomerOption(Customer customer)
        {

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("1. Check Balance \n" + "2. Cash Withdrawal \n" + "3. Cash Deposit");
            string userOption;
           
            while (true)
            {
                userOption = Console.ReadLine().Trim();
               
                if (userOption != "1" && userOption != "2" && userOption != "3")
                {
                    Console.WriteLine("Please Enter 1, 2 or 3 ");

                    continue;
                }
                break;
            }

            if (userOption == "1")
            {
                Console.WriteLine($"You have {customer.CheckBalance()} on your account");  
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Enter the amount you want to witdhaw");
                string inputMoney;
                decimal withdrawal = 0;
                
                while (true)
                {
                    
                    inputMoney = Console.ReadLine().Trim();

                    if (!decimal.TryParse(inputMoney, out withdrawal))
                    {
                        Console.WriteLine("Please enter the amount you want to witdhraw");
                        continue;
                    }

                    if(withdrawal > customer.CheckBalance())
                    {
                        Console.WriteLine("Not enough money on your accont");
                    }
                    else
                    {
                        customer.CashWithdrawal(withdrawal);
                        Console.WriteLine($"You withdrew {withdrawal}. You have {customer.CheckBalance()} left on your account");
                    }
                    break;
                }
                
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Enter the amount you want to deposit");
                string inputMoney;
                decimal deposit = 0;
               
                while (true)
                {

                    inputMoney = Console.ReadLine().Trim();
                    if (!decimal.TryParse(inputMoney, out deposit))
                    {
                        Console.WriteLine("Please enter the amount you want to add to your acccount");
                        continue;
                    }
                    break;
                }
                customer.CashDeposit(deposit);
                Console.WriteLine($"You added {deposit} to your account");

            }
        }

        public static Customer RegisterNewAccount(List<Customer> customers)
        {
            Console.WriteLine("Enter your First Name");
            string inputFristName = Console.ReadLine().Trim();

            Console.WriteLine("Enter your Last Name");
            string inputLastName = Console.ReadLine().Trim();

            long cardNumber;
            int pin;
            decimal balance;
            
            while (true)
            {
                Console.WriteLine("Enter your new card number");
                string inputCardNumber = Console.ReadLine().Trim();
      
                if(long.TryParse(inputCardNumber.Replace("-", ""), out cardNumber))
                {
                    bool customerDoesExists = customers.Any(cust => cust.CardNumber.ToString() == cardNumber.ToString());
                    if (customerDoesExists)
                    {
                        Console.WriteLine("Customer with this card number already exits.");

                        continue;
                    }
                }
                break;
             } 

            while (true)
            {
                Console.WriteLine("Enter pin");
                string inputPin = Console.ReadLine().Trim();

                if (!int.TryParse(inputPin, out pin))
                {
                    Console.WriteLine("Please enter digits");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Enter balance");
                string inputBalance = Console.ReadLine().Trim();

                if (!decimal.TryParse(inputBalance, out balance))
                {
                    Console.WriteLine("Please enter digits");
                    continue;
                }
                break;
            }

            Customer newCustomer = new Customer(inputFristName, inputLastName,cardNumber, pin, balance);

            return newCustomer;
        }
    }
}
