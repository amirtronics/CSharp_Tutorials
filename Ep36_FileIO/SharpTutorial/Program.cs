using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\testFiles";
            Directory.CreateDirectory(path);

            string fileName = "log.txt";
            string filePath = Path.Combine(path, fileName);

            File.WriteAllText(filePath, "hello world");

            Console.WriteLine(filePath);

            Console.ReadLine();
        }
    }
}