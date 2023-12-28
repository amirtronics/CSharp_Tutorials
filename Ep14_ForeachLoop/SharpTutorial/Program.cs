using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myNames = new List<string> { "Paul", "Jimmy", "Wanda", "Beatrice"};
            List<int> myInts = new List<int> { 1, 2, 3, 4 };


            foreach (string name in myNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}