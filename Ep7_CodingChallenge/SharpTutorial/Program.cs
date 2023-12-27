using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void programMain(string[] args)
        {
            Console.Write("Please enter your name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is: " + firstName + " " + lastName + ".");


            Console.ReadLine();
        }
    }
}