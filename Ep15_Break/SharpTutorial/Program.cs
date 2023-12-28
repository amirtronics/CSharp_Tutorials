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
                    continue; // Will immediately take us to the next iteration of the loop, you might use to skip or filter out parts of you loop
                    //break;  // Will immediately take us out of the loop, you might use it to end a loop when you finish early
                }

                Console.WriteLine(names[i]);
            }

            foreach (string name in names) 
            {
                if (name == "Chelle")
                {
                    continue; // Will immediately take us to the next iteration of the loop, you might use to skip or filter out parts of you loop
                    //break;  // Will immediately take us out of the loop, you might use it to end a loop when you finish early
                }

                Console.WriteLine(name);
            }
            /*
            while (true)
            {
                Console.Write("Give me your name: ");
                string inpu = Console.ReadLine();

                if (inpu == "exit")
                    break;

            }
            */

            Console.WriteLine("We're done");
            Console.ReadLine();

        }
    }   
}