using System;

namespace SharpTutorial
{
    internal class Program
    {
        static List<string> names = new List<string> { "Adam", "Bill", "Chelle", "David", "Ellen", "Francesa" };

        // step in - we keep going deeper and deeper in the code
        // step over - we're going to stay at the same level in the code
        // step out - we want to go back to the previous level in the code

        static void Main(string[] args)
        {
            for (int i = 0; i < names.Count; i++)
            {
                PrintNumberedName(i+1, names[i]);
            }

            Console.ReadLine();
           
        }

        static void PrintNumberedName(int number, string name)
        {
            Console.WriteLine(number + " " + name);
        }
    }
}