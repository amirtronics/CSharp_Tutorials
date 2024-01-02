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

            //File.WriteAllText(filePath, "hello world");
            //File.WriteAllText(filePath, "A");

            //File.AppendAllText(filePath, "Log item 1\n");
            //File.AppendAllText(filePath, "Log item 1\n");
            //File.AppendAllText(filePath, "Log item 1\n");
            //File.AppendAllText(filePath, "Log item 1\n");

            bool exists = File.Exists(filePath);
            if (exists)
            {
                string contents = File.ReadAllText(filePath);

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                string copyPath = @"C:\testFiles\copiedFile.txt";
                if (!File.Exists(filePath))
                    File.Copy(filePath, copyPath);
                else
                {
                    //promp/warn
                }

                //string renamePath = @"C:\testFiles\renamedFile.txt";
                //File.Move(copyPath, renamePath);

                File.Delete(copyPath);


                // File.Create();
            }


            //Console.WriteLine(contents);

            Console.ReadLine();
        }
    }
}