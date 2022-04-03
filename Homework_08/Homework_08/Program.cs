using System;
using System.Collections.Generic;

namespace Homework_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            while (true)
            {
                Console.WriteLine("Enter number");
                string input = Console.ReadLine().Trim();
                if(!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Please enter number");
                    continue;
                }
                numbers.Enqueue(number);

                while (true)
                {
                    Console.WriteLine("Do you want to enter another number Y/N");
                    input = Console.ReadLine().Trim();
                    if (input.ToLower() != "y" && input.ToLower() != "n")
                    {
                        Console.WriteLine("Please enter Y or N");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if(input.ToLower() == "n")
                {
                    break;
                }
            }

           foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }


    }
}
