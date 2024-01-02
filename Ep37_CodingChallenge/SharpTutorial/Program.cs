using System;
using System.IO;

namespace SharpTutorial
{
    internal class Program
    {
        public static string employeesFilePath = @"employeeFiles";
        public static List<Employee> employees = new List<Employee>();
        private static bool running = true;

        static void Main(string[] args)
        {
            Initialize();

            while (running)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                ProcessInput(input);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        static void Initialize()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Welcome to the Hospital Management Portal");
            Console.WriteLine("Type \"help\" for available commands.");
            Console.WriteLine("----------------------------------------------");

            int employeesCount = employees.Count;
            string employeeNumString = $"Loaded {employeesCount.ToString()} employees.\n";

            Console.WriteLine(employeeNumString);
        }

        static void WriteHeader()
        {

        }

        static void ProcessInput(string input)
        {
            switch (input)
            {
                case "help":
                    PrintHelp(); 
                    break;

                case "add":
                    AddEmployee();
                    break;

                case "remove":
                    RemoveEmployee();
                    break;

                case "laod":
                    LoadEmployee();
                    break;

                case "view":
                    ViewEmployee();
                    break;

                case "page":
                    PageEmployee();
                    break;

                case "clear":
                    Initialize();
                    break;

                default:
                    PrintInvalidCommand();
                    break;
            }
        }

        #region Adding Employees

        private static void AddEmployee()
        {
            //
        }


        #endregion

        #region Loading Employees

        private static void LoadEmployee()
        {
            //
        }

        #endregion

        #region Management

        static void CreateCSV(string fileName)
        {

        }

        static void LoadCSV(string fileName) 
        { 

        }

        static void WriteCSV(Employee employee)
        {

        }

        #endregion
        private static void RemoveEmployee()
        {
            //
        }

        private static void ViewEmployee()
        {
            //
        }

        private static void PageEmployee()
        {
            //
        }

        static void PrintHelp()
        {
            Console.WriteLine("\tAvailable Commands:");
            Console.WriteLine("\tadd - Add a new employee to the portal.");
            Console.WriteLine("\tremove - Remove an employee from the portal");
            Console.WriteLine("\tload - Load existing employees from file.");
            Console.WriteLine("\tview - View an employee.");
            Console.WriteLine("\tpage - Page all medical employees.\n");
        }

        static void PrintInvalidCommand()
        {
            Console.WriteLine("Command not recognized, please try again.");
            Console.WriteLine("Type \"help\" for available commands.\n");
        }
    }
}