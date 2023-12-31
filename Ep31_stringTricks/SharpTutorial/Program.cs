using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Kampa";
            string lastName = "Plays";
            int age = 99;

            string concatenatedString = "Description: " + firstName + " " + lastName + ", " + age;

            Console.WriteLine(concatenatedString);

            string quote = "He said: \"something\"";
            Console.WriteLine(quote);

            string path = "C:\\SomeFolder\\SomeFile.txt";
            Console.WriteLine(path);

            string newLine = "This is line1.\nThis is line 2.";
            Console.WriteLine(newLine);

            //verbatim string literals
            string literal = @"C:\SomeFolder\SomeFile.txt";
            Console.WriteLine(literal);

            //string interpolation

            //concatenation
            string concatenatedString_ = "Description: " + firstName + " " + lastName + ", " + age;
            string interpolatedString = $"Descritption: {firstName} {lastName}, {age}";
            Console.WriteLine(interpolatedString);




            Console.ReadLine();
        }
    }
}