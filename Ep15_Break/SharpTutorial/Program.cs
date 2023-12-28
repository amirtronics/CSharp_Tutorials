using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Adam", "Jamie", "Steve", "Kim", "Chelle", "Tom" };

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == "Chelle")
                {
                    break;
                }

            }

            while (true)
            {
                Console.Write("Give me your name: ");
                string inpu = Console.ReadLine();

                if (inpu == "exit")
                    break;

            }

            Console.WriteLine("We're done");
            Console.ReadLine();

        }
    }   
}