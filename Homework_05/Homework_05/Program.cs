using System;

namespace Homework_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver Bob = new Driver("Bob", 7);
            Driver Greg = new Driver("Greg", 4);
            Driver Jill = new Driver("Jill", 10);
            Driver Anne = new Driver("Anne", 8);


            Car Hyundai = new Car("Hyundai", 160);
            Car Mazda = new Car("Mazda", 150);
            Car Ferrari = new Car("Ferrari", 240);
            Car Porsche = new Car("Porsche", 200);

            Car[] cars = new Car[] { Hyundai, Mazda, Ferrari, Porsche };
            Driver[] drivers = new Driver[] { Bob, Greg, Jill, Anne };


            string inputCarNo1;

            string inputDriverNo1;

            string inputCarNo2;
         
            string inputDriverNo2;

            int temp = 0 ;
            while (true)
            {
                if (temp == 0)
                {
                    Console.WriteLine("Select two cars and two drivers");
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Choose a car no.1:");

                        inputCarNo1 = ChooseCar(cars);

                        if (!ValidateUserInput(inputCarNo1))
                        {
                            Console.WriteLine("Please enter valid number");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.WriteLine("Choose Driver ");
                        inputDriverNo1 = ChooseDriver(drivers);

                        if (!ValidateUserInput(inputDriverNo1))
                        {
                            Console.WriteLine("Please enter valid number");
                            continue;
                        }
                        Console.WriteLine();
                        break;
                    }

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Choose a car no.2:");

                        inputCarNo2 = ChooseCar(cars, inputCarNo1);

                        if (!ValidateUserInput(inputCarNo2))
                        {
                            Console.WriteLine("Please enter valid number");
                            continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.WriteLine("Choose Driver ");
                        inputDriverNo2 = ChooseDriver(drivers);

                        if (!ValidateUserInput(inputDriverNo2))
                        {
                            Console.WriteLine("Please enter valid number");
                            continue;
                        }
                        Console.WriteLine();
                        break;
                    }

                    cars[int.Parse(inputCarNo1) - 1].Driver = drivers[int.Parse(inputDriverNo1) - 1];
                    cars[int.Parse(inputCarNo2) - 1].Driver = drivers[int.Parse(inputDriverNo2) - 1];

                    RaceCars(cars[int.Parse(inputCarNo1) - 1], cars[int.Parse(inputCarNo2) - 1]);
                }

                temp++;

                Console.WriteLine("Do you want to race again?");
                Console.WriteLine("Y / N");
                string inputUser = Console.ReadLine().Trim().ToLower();
                
                if (inputUser != "y" && inputUser != "n")
                {
                    Console.WriteLine("Please type Y or N");
                    continue;
                }

                if(inputUser == "y")
                {
                    temp = 0;
                    continue;
                }
                else
                {
                    break;
                }
            }

        }




        public static bool ValidateUserInput(string userInput)
        {
            if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                return false;
            }
            return true;
        }

        public static string ChooseCar(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            Console.WriteLine();
            string inputCar = Console.ReadLine().Trim();
            Console.WriteLine();
            return inputCar;
        }


        public static string ChooseCar(Car[] cars, string userInput)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if((i+1).ToString() == userInput)
                {
                    continue;
                }
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            Console.WriteLine();
            string inputCar = Console.ReadLine().Trim();
            Console.WriteLine();
            return inputCar;
        }

        public static string ChooseDriver(Driver[] drivers)
        {
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            Console.WriteLine();
            string inputCarDriver = Console.ReadLine().Trim();
            Console.WriteLine();
            return inputCarDriver;
        }

        public static void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine("Car no. 1 was faster.");
                Console.WriteLine($"{car1.Model} is a winner with a speed of {car1.CalculateSpeed()}. The driver is {car1.Driver.Name}");
            }
            else
            {
                Console.WriteLine("Car no. 2 was faster.");
                Console.WriteLine($"{car2.Model} is a winner with a speed of {car2.CalculateSpeed()}. The driver is {car2.Driver.Name}");
            }
        }

    }
}
