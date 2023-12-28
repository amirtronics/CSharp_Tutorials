using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();

            while (true)
            {
                string fullname = GetUsersFullName();

                Console.WriteLine(fullname);
                Console.WriteLine();
            }

        }

        // static - modifer, don't worry about this yet, you just have to have it for now
        // void - return type, what our method gives back, it can be any type but if you want to return nothing, use void
        // method name, case sensitive, can be anything (not reserved)
        // parameter list (arguments), don't worry about these yet
        // method's code block

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to our program!");
            Console.WriteLine("-----------------------------------");

        }

        static string GetUsersFullName()
        {
            Console.Write("Enter your fist name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;

            return fullName;
        }
    }

}