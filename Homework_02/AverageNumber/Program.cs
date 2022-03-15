using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter the First number");
                string input1 = Console.ReadLine();

                if (!double.TryParse(input1, out double number1))
                {
                    Console.WriteLine("Please enter valid number");
                    continue;
                }
            SecondNumber:
                Console.WriteLine("Enter the Second number");
                string input2 = Console.ReadLine();
                if (!double.TryParse(input2, out double number2))
                {

                    Console.WriteLine("Please enter valid number");
                    goto SecondNumber;

                }

            ThirdNumber:
                Console.WriteLine("Enter the Third number");
                string input3 = Console.ReadLine();
                if (!double.TryParse(input3, out double number3))
                {

                    Console.WriteLine("Please ente valid number");
                    goto ThirdNumber;

                }

            FourthNumber:
                Console.WriteLine("Enter the Fourth number");
                string input4 = Console.ReadLine();
                if (!double.TryParse(input4, out double number4))
                {

                    Console.WriteLine("Please enter valid number");
                    goto FourthNumber;

                }

                double result = (number1 + number2 + number3 + number4) / 4;
                Console.WriteLine("The average of " + number1 + ", " + number2 + ", " + number3 + ", " + number4 + " is: " + result);
                break;

            }


            //Solution 02
            //Console.WriteLine("Enter the First number");
            //string firstNumber = Console.ReadLine();
            //bool firstNumberConverted = double.TryParse(firstNumber, out double num1);

            //Console.WriteLine("Enter the Second number");
            //string secondNumber = Console.ReadLine();
            //bool secondNumberConverted = double.TryParse(secondNumber, out double num2);

            //Console.WriteLine("Enter the Third number");
            //string thirdNumber = Console.ReadLine();
            //bool thirdNumberConverted = double.TryParse(thirdNumber, out double num3);

            //Console.WriteLine("Enter the Fourth number");
            //string fourthNumber = Console.ReadLine();
            //bool fourthNumberConverted = double.TryParse(fourthNumber, out double num4);

            //if (firstNumberConverted == true && secondNumberConverted == true && thirdNumberConverted == true && fourthNumberConverted == true)
            //{
            //    double result = (num1 + num2 + num3 + num4) / 4;
            //    Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + ", " + num4 + " is: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid numbers");
            //}




        }
    }
}
