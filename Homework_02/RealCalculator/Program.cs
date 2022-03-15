using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number");
            string firstNumber = Console.ReadLine();
            bool firstNumberConverted = double.TryParse(firstNumber, out double num1);

            Console.WriteLine("Enter the Second number");
            string secondNumber = Console.ReadLine();
            bool secondNumberConverted = double.TryParse(secondNumber, out double num2);

            Console.WriteLine("Enter the Operation");
            string operation = Console.ReadLine();


            double result;
            if ((firstNumberConverted == true && secondNumberConverted == true) && (operation == "+" || operation == "-" || operation == "*" || operation == "/"))
            {

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("The result is " + result);
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please enter valid numbers and a valid operator");
            }
        }
    }
}
