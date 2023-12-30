using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");

                string input = Console.ReadLine();

                try
                {
                    int number = Convert.ToInt32(input);
                    Console.WriteLine(number);
                }
                catch (Exception ex)
                {
                    if(ex is FormatException)
                        Console.WriteLine("Error! You must enter a number!");
                    else if(ex is OverflowException)
                        Console.WriteLine("Error! Your number is too big!");
                    else
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}