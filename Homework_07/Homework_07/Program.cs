using Models;
using System;

namespace Homework_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager dare = new Manager("Darko", "Angelovski", Role.Manager, 50000);
            Manager petko = new Manager("Petko", "Petkovski", Role.Manager, 30000);
            SalesPerson bob = new SalesPerson("Bob", "Bobson", Role.Sales, 10000);
            Employee[] company = new Employee[] { new Contractor("John", "Johnsky", Role.Other, 300, 80, 100, dare ),
                new Contractor("Bob", "Bobsky", Role.Other, 300, 80, 100, petko), dare, petko, bob};


            CEO ceo = new CEO("Ron", "Ronsky", Role.CEO, 1500, 100, company);
            Console.WriteLine(ceo.PrintInfo());
            ceo.AddSharesPrice(14);
            Console.WriteLine(ceo.GetSalary());
            ceo.PrintEmployees();
           

        }
    }
}
