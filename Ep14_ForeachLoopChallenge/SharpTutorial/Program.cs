using System;

namespace SharpTutorial
{
    internal class Program
    {

        public static List<List<string>> listDataset = new List<List<string>>();

        static void Main(string[] args)
        {
            Console.Clear();

            while (true)
            {
                List<string> list = new List<string>();
                list = getUserName();

                if(checkAdmin(list))
                {
                    printNames(listDataset);
                }
                else
                {
                    listDataset.Add(new List<string> { list[0], list[1] });
                }

            }
        }

        public static List<string> getUserName()
        {
            Console.Clear();

            List<string> listName = new List<string> (new string[2]);


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("------------- SIGN UP FOR OUR GIVEAWAY! ----------");
            Console.WriteLine("--------------------------------------------------\n");

            Console.Write("First name: ");
            listName[0] = Console.ReadLine();

            Console.Write("Last name: ");
            listName[1] = Console.ReadLine();


            return listName;
        }

        public static bool checkAdmin(List<string> listUser)
        {
            if (listUser[0] == "admin" && listUser[1] == "print")
                return true;
            else 
                return false;
        }

        public static void printNames(List<List<string>> stringList)
        {
            Console.Clear();
            Console.WriteLine("Sign ups:\n---------------------");
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i][0] + " " + stringList[i][1]);                           
            }

            Console.WriteLine("\nPress enter to return:");
            Console.ReadLine();
        }
    }
}