using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasValidInput = false;
            bool isTheUserSure = false;

            while(!hasValidInput)
            {
                Console.WriteLine("Are you sure? Enter yes or no: ");
                string input = Console.ReadLine();

                if(input == "yes" || input == "no")
                {
                    hasValidInput = true;
                    if(input == "yes")
                    {
                        isTheUserSure = true;
                    }
                    else
                    {
                        isTheUserSure = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");

                }

                Console.ReadLine();

            }
        }
    }
}