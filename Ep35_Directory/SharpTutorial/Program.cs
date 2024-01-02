using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string absoluteDirectoryPath = @"L:\Application\Files";
            string relativeDirectoryPath = @"logs\backupLogs";
            string destRelativeDirectoryPath = @"logs\backupLogs";

            /*
            string root = Directory.GetDirectoryRoot(absoluteDirectoryPath)


            //create directory
            Directory.CreateDirectory(absoluteDirectoryPath);
            //Directory.CreateDirectory(relativeDirectoryPath);

            string[] files;

            if(Directory.Exists(relativeDirectoryPath))
                files = Directory.GetFiles(relativeDirectoryPath);
            else //do something else
            */

            //Directory.Move(relativeDirectoryPath, destRelativeDirectoryPath);

            Directory.Delete(relativeDirectoryPath, true);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}