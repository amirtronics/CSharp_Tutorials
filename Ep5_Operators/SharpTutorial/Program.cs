﻿using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //math
            // + - * /
            double number1 = 3;
            double number2 = 4;
            double result = number1 / number2;

            //increment (++) adds 1 to a number
            // decrement (--) subtracts 1 from a number
            //pre/post matters, e.g. ++number; is different than number++;

            int number3 = 5;
            //Console.WriteLine(++number3); // 6 - increment happens first
            Console.WriteLine(number3++); // 5 - Writing happens first




            //assignment 


            //relational 


            //logical
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}