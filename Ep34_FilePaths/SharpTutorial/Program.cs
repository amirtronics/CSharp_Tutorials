using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //absolute path
            string testFile1 = @"C:\test\testFile1.txt"; //complete path to a specific location

            //relative paths
            string testFile2 = @"testFile2.txt"; // same directory as your executable
            string testFile3 = @"..\testFile3.txt"; // one folder up from your executable
            string testFile4 = @"testFiles\testFile4.txt"; // inside a directory "testfile" in same directory as your executable

            Console.ReadLine();

        }
    }
}