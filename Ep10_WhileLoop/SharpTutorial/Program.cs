﻿using System;

namespace SharpTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isTheUserSure = GetUserConfirmation(ConsoleReader);

            Console.WriteLine($"User is sure: {isTheUserSure}");
        }

        public static bool GetUserConfirmation(Func<string> consoleReader)
        {
            bool hasValidInput = false;
            bool isTheUserSure = false;

            while (!hasValidInput)
            {
                Console.WriteLine("Are you sure? Enter yes or no: ");
                string input = consoleReader();

                if (input == "yes" || input == "no")
                {
                    hasValidInput = true;
                    isTheUserSure = input == "yes";
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            return isTheUserSure;
        }

        public static string ConsoleReader()
        {
            return Console.ReadLine();
        }
    }
}