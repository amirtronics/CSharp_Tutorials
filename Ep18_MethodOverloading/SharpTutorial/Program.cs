using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Add(1.2, 3.2);
            Console.ReadLine();
        }

        //Method Overloading - creating more than 1 method with the same name, but with different forms
        //Why user overloading? You need to do the same logic but have different inputs and/or outputs

        static int Add(int number, int number2)
        {
            int result = number + number2;
            return result;
        }

        //Ways to overload:
        //Change the number of parameters

        static int Add(int number, int number2, int number3)
        {
            int result = number + number2 + number3;
            return result;
        }

        //Change the data types of the parameters
        static double Add(double number, double number2)
        {
            double result = number + number2;
            return result;
        }

        //Change the order of the parameters

        static void Register(string name, int age)
        {

        }

        static void Register(string age, string name)
        {

        }
    }
}