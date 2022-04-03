using System;
using System.Globalization;

namespace Homework_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFormat = "";
            while (true)
            {
                Console.WriteLine("Choose format: \n 1. Month - Day - Year format \n 2. Day - Month - Year format");
                inputFormat = Console.ReadLine().Trim();
                Console.WriteLine();
                if (inputFormat != "1" && inputFormat != "2")
                {
                    Console.WriteLine("Please enter 1 or 2 for correct format");
                    continue;
                }
                break;
            }

            while (true)
            {
                if(inputFormat == "2")
                {
                    Console.WriteLine("Please enter your date of birth in Day - Month - Year format");
                    Console.WriteLine();
                    string input = Console.ReadLine().Trim();

                    if (!DateTime.TryParse(input, out DateTime birthDay))
                    {
                        Console.WriteLine("Please enter valid date");
                        continue;
                    }

                    string dateInString = birthDay.ToString("dd.MM.yyyy");

                    if (birthDay.Date >= DateTime.Now.Date)
                    {
                        Console.WriteLine("Please enter date before today");
                        continue;
                    }

                    Console.WriteLine("You are " + AgeCalculator(Convert.ToDateTime(dateInString)) + " year old");

                }
                else
                {
                    Console.WriteLine("Please enter your date of birth in Month - Day - Year format");
                    string input = Console.ReadLine().Trim();

                    if (!DateTime.TryParse(input, out DateTime birthDay))
                    {
                        Console.WriteLine("Please enter valid date");
                        continue;
                    }

                    if (birthDay.Date >= DateTime.Now.Date)
                    {
                        Console.WriteLine("Please enter date before today");
                        continue;
                    }

                    Console.WriteLine("You are " + AgeCalculator(Convert.ToDateTime(birthDay)) + " year old");

                }
                break;

            }
        }

        public static int AgeCalculator(DateTime birthday)
        {
            DateTime now = DateTime.UtcNow;
            int age = (DateTime.Now.Subtract(birthday).Days) / 365;
            if ((birthday.Date.Month == now.Date.Month) && (birthday.Date.Day == now.Day) && birthday.Date.Year != now.Year
                )
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Happy birthday!!!");
                Console.ResetColor();
                return age;
            }
            return age;
        }


    }
}
