using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#'s random class provides "psuedo-random" number generator
            Random random = new Random();

            //random Int
            int randomInt = random.Next();

            //random Int between 0 and X
            int randomInt2 = random.Next(101); // 1 - 100

            //random Int between X and Y
            int randomInt3 = random.Next(1, 11); // 1 - 10

            //random double 
            double randomDouble = random.NextDouble(); //0 - 1

            string[] names = { "Bob", "Jim", "Sam", "Mary", "Kate" };
            int randomIndex = random.Next(names.Length);


            //generate 100 coin flips and see our results
            int heads = 0;
            int tails = 0;
            for (int i = 0; i < 100; i++)
            {
                int coinFlip = random.Next(2); // 0-1
                if (coinFlip == 1)
                    heads++;
                else
                    tails++;
            }

            Console.WriteLine(names[randomIndex]);
            Console.WriteLine($"Heads: {heads}, Tails: {tails}");

            Console.ReadLine();
        }
    }
}