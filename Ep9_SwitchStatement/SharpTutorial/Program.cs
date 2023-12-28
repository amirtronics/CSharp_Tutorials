using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;

            switch (condition)
            {
                case true:
                    {
                        Console.WriteLine("It's true");
                        break;
                    }

                case false:
                    {
                        Console.WriteLine("It's false");
                        break;
                    }

            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}