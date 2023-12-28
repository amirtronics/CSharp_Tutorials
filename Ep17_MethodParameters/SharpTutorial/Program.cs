using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 1234;
            int userNumber2 = 2345;
            string userName = "Kampa";


            PrintResult(userNumber, userNumber2, userName);
        }

        // parameter - type variablename
        // optional parameters have to be at the end of your parameter list
        // optional - type variableName = defaultValue

        static void PrintResult(int number, int number2 = 20, string name = "User")
        {
            Console.WriteLine(1);
        }
    }
}