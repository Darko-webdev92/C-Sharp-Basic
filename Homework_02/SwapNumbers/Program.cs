using System;

namespace SwapNumbers
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
                Console.WriteLine();
                double temp = number1;
                number1 = number2;
                number2 = temp;

                Console.WriteLine("After swapping");
                Console.WriteLine("First number" + number1);
                Console.WriteLine("Second number" + number2);

                break;
            }


            //Soluton 02
            //Console.WriteLine("Enter the First number");
            //string firstNumber = Console.ReadLine();
            //bool firstNumberConverted = double.TryParse(firstNumber, out double num1);



            //Console.WriteLine("Enter the Second number");
            //string secondNumber = Console.ReadLine();
            //bool secondNumberConverted = double.TryParse(secondNumber, out double num2);

            //Console.WriteLine();
            //double temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine("After swapping");
            //Console.WriteLine("First number" + num1);
            //Console.WriteLine("Second number" + num2);

        }
    }
}
