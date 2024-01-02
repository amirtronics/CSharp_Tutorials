using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string absoluteDirectoryPath = @"C:\Application\Files";
            string relativeDirectoryPath = @"logs\errorlogs";

            ////create directory
            //Directory.CreateDirectory(absoluteDirectoryPath);
            //Directory.CreateDirectory(relativeDirectoryPath);

            bool exists = Directory.Exists(relativeDirectoryPath);
            string[] files = Directory.GetFiles(relativeDirectoryPath);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}