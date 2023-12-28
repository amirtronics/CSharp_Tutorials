using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive = false;

            Console.WriteLine("Are you sure? Enter yes or no: ");
            string input = Console.ReadLine();

            if(input == "yes")
            {
                Console.WriteLine("You are sure.");
            }
            else if(input == "no")
            {
                Console.WriteLine("You are NOT sure.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

}