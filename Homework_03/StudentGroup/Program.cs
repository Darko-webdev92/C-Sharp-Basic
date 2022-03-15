using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "John Doe", "Jane Doe", "Joe Blow", "Lorem ipsum", "Petko" };

            string input;

            while (true)
            {
                Console.WriteLine("Enter student group: ( there are 1 and 2 )");
                input = Console.ReadLine().Trim();

                if (input != "1" && input != "2")
                 // Another way of comparing 
                //if ((!input.Equals("1")) && (!input.Equals("2")))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                break;
            }

           if(input == "1")
            {
                for(int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }
            else
            {
                for(int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
         }
    }
}
