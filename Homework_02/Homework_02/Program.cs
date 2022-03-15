using System;

namespace Homework_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 01
            double num1, num2, res;
            num1 = 17D;
            num2 = 12D;

            res = num1 / num2;

            int int1, int2, res1;
            int1 = 17;
            int2 = 12;
            res1 = int1 / int2;

            Console.WriteLine("The quotient of " + num1 + " / " + num2 + " is " + res + "  The data type of the result variable is of type double");

            Console.WriteLine("The quotient of " + int1 + " / " + int2 + " is " + res1 + "  The data type of the result variable is of type int ");

            Console.WriteLine();

            //Exercise 02
            int n = 102;
            int m = 5;
            int numOfSMS = n / m;
            Console.WriteLine("You can send " + numOfSMS + " mesages.");
            Console.WriteLine("You have " + (n % m)  + "  denars left on your account.");

        }
    }
}
