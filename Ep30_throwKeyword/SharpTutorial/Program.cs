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
                    ValidateInput(number);

                    Console.WriteLine(number);
                }
                catch (Exception ex)
                {
                    if (ex is FormatException)
                        Console.WriteLine("Error! You must enter a number!");
                    else if (ex is OverflowException)
                        Console.WriteLine("Error! Your number is too big!");
                    else if (ex is ArgumentOutOfRangeException || ex is ArgumentException)
                           Console.WriteLine("Error! Your number must and even be 2 and 10!");
                    else
                        Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }

        private static void ValidateInput(int number)
        {
            //make sure input is even
            if(number % 2 != 0)
            {
                //not even
                throw new ArgumentException();
            }

            if(number < 2 || number > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}