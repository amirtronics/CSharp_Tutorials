﻿using System;

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
            double number3 = (number1 + number2);

            //explicit casting (you have to tell it what to do)
            int number4 = (int)number2; //lose our precision!!! 8.5 -> 8
            int number5 = (int)(number2 + number3);

            // Covert methods
            int number6 = Convert.ToInt32(number2);

            string textNumber5 = "5";
            int integer5 = Convert.ToInt32(textNumber5);

            Console.WriteLine(integer5);
            Console.ReadLine();
        }
    }
}