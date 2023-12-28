using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myNames;

            myNames = new List<string> { "JIM", "STEVE", "MARSHA" };

            string myFirstName = myNames[0];
            string myThirdName = myNames[2];

            for (int i = 0; i < myNames.Count; i++)
            {
                Console.WriteLine(myNames[i]);
            }

            myNames.Add("KEVIN");
            myNames.Add("PAM");

            myNames.RemoveAt(0);
            myNames.Clear();

            for (int i = 0; i < myNames.Count; i++)
            {
                Console.WriteLine(myNames[i]);
            }

            
            Console.ReadLine();

        }
    }
}