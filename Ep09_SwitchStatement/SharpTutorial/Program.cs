using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you like cake?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "yes":
                case "yeah":
                case "sure":
                    Console.WriteLine("Me too!");
                    break;

                case "no":
                case "nah":
                    Console.WriteLine("What? You don't?");
                    break;


                default:
                    Console.WriteLine("I didn't understand that ...");
                    break;



            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}