using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
            double number2 = 8.5;

            // implicit casting (C# can do it for you)
            // the types have to be compatible for c# to take action
            double number3 = number1;

            //explicit casting (you have to tell it what to do)
            int number4 = (int)number2; //lose our precision!!! 8.5 -> 8

            Console.WriteLine(number4);
            Console.ReadLine();
        }
    }
}