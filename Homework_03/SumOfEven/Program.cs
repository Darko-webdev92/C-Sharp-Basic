using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6];
            int sum = 0;
            while (true)
            {

                Console.WriteLine("Enter integer no.1");
                string input1 = Console.ReadLine();

                if (!int.TryParse(input1, out int number1))
                {
                    Console.WriteLine("Please enter valid number");
                    continue;
                }
                nums[0] = number1;
            SecondNumber:
                Console.WriteLine("Enter integer no.2");
                string input2 = Console.ReadLine();
                if (!int.TryParse(input2, out int number2))
                {

                    Console.WriteLine("Please enter valid number");
                    goto SecondNumber;

                }
                nums[1] = number2;

            ThirdNumber:
                Console.WriteLine("Enter integer no.3");
                string input3 = Console.ReadLine();
                if (!int.TryParse(input3, out int number3))
                {

                    Console.WriteLine("Please ente valid number");
                    goto ThirdNumber;

                }
                nums[2] = number3;
            FourthNumber:
                Console.WriteLine("Enter integer no.4");
                string input4 = Console.ReadLine();
                if (!int.TryParse(input4, out int number4))
                {

                    Console.WriteLine("Please enter valid number");
                    goto FourthNumber;

                }
                nums[3] = number4;


            FifthNumber:
                Console.WriteLine("Enter integer no.5");
                string input5 = Console.ReadLine();
                if (!int.TryParse(input5, out int number5))
                {

                    Console.WriteLine("Please enter valid number");
                    goto FifthNumber;

                }
                nums[4] = number5;

            SixthNumber:
                Console.WriteLine("Enter integer no.6");
                string input6 = Console.ReadLine();
                if (!int.TryParse(input6, out int number6))
                {

                    Console.WriteLine("Please enter valid number");
                    goto SixthNumber;

                }
                nums[5] = number6;
                break;

            }

            for (int i = 0; i < nums.Length; i++)
            {
                  if(nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }

            Console.WriteLine("The result is " + sum);
        }
    }
}
