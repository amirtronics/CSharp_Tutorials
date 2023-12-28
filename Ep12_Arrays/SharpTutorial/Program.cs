using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myInts = { 1, 2, 3, 4 };
            int[] myInts2 = new int[10];
            int[] myInts3;
            myInts3 = new int[] { 1, 2, 3, 4 };

            int myFirstInt = myInts[0];
            int myFourthInt = myInts[3];

            string[] myNames = { "Bill", "George", "Frank", "Nancy", "Pam" };

            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myNames[i]);
            }

            Console.ReadLine();
        }
    }
}