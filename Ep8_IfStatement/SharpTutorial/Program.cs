using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;

            if(isActive)
            {
                Console.WriteLine("The system is active");
            }
            else
            {
                Console.WriteLine("The system is not active!");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

}