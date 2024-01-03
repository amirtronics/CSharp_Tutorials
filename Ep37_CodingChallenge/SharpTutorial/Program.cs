using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace SharpTutorial
{
    internal class Program
    {
        public static string employeesFilePath = @".\employeeFiles.csv";
        public static List<Employee> employees = new List<Employee>();
        public static string[] jobTitles = { "doctor", "nurse", "custodian" };
        private static bool running = true;

        static void Main(string[] args)
        {
            Initialize();

            while (running)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if(input != "")
                    ProcessInput(input);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        static void Initialize()
        {

            if (File.Exists(employeesFilePath))
                employees = ReadCsv<Employee>(employeesFilePath);
            
                

            RefreshScreen();
        }

        static void RefreshScreen()
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

                case "load":
                    LoadEmployee();
                    break;

                case "view":
                    ViewEmployee();
                    break;

                case "page":
                    PageEmployee();
                    break;

                case "clear":
                    RefreshScreen();
                    break;

                case "save":
                    SaveData();
                    break;

                case "quit":
                    QuitApp();
                    break;

                default:
                    PrintInvalidCommand();
                    break;
            }
        }

        #region Adding Employees

        private static void AddEmployee()
        {
            Employee employeeSample = new Employee();

            Console.Write("\nEmployee ID: ");
            string ID = Console.ReadLine();
            try
            {
                employeeSample.EmployeeID = Convert.ToInt32(ID);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n");
                return;
            }

            Console.Write("\nFirst Name: ");
            string firstname = Console.ReadLine();
            try
            {
                employeeSample.FirstName = firstname;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n");
                return;
            }

            Console.Write("Last Name: ");
            string lastname = Console.ReadLine();
            try
            {
                employeeSample.LastName = lastname;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n");
                return;
            }
            Console.Write("Job Title (doctor, nurse, custodian): ");
            string title = Console.ReadLine();
            try
            {
                employeeSample.JobTitle = title;
                if (!jobTitles.Contains(title))
                    throw new InvalidOperationException("Invalid job title, try again!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n");
                return;
            }

            if(title == "doctor" || title == "nurse")
            {
                Console.Write("Specialty: ");
                string specialty = Console.ReadLine();
                Console.Write("\n");
                employeeSample.Specialty = specialty;
                if (title == "doctor")
                {
                    employees.Add(new Doctor
                    {
                        EmployeeID = employeeSample.EmployeeID,
                        FirstName = employeeSample.FirstName,
                        LastName = employeeSample.LastName,
                        JobTitle = employeeSample.JobTitle,
                        Specialty = employeeSample.Specialty
                    });
                }
                else if(title == "nurse")
                {
                    employees.Add(new Nurse
                    {
                        EmployeeID = employeeSample.EmployeeID,
                        FirstName = employeeSample.FirstName,
                        LastName = employeeSample.LastName,
                        JobTitle = employeeSample.JobTitle,
                        Specialty = employeeSample.Specialty
                    });
                }
            }
            else
            {
                employeeSample.Specialty = "NA";
                employees.Add(new Custodian 
                { 
                    EmployeeID = employeeSample.EmployeeID,
                    FirstName = employeeSample.FirstName,
                    LastName = employeeSample.LastName,
                    JobTitle = employeeSample.JobTitle,
                    Specialty = employeeSample.Specialty
                });
            }
            

        }


        #endregion

        #region Loading Employees

        private static void LoadEmployee()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetDescription());
            }
            Console.WriteLine();
        }

        #endregion

        #region CSV Management

        static List<T> ReadCsv<T>(string filePath)
        {
            // Configure CsvReader
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

            // Read data from the CSV file
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                // Read records from the CSV file
                return csv.GetRecords<T>().ToList();
            }
        }

        static void WriteToCsv<T>(string filePath, IEnumerable<T> records)
        {
            // Configure CsvWriter
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

            // Write data to the CSV file
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, csvConfig))
            {
                // Write records to the CSV file
                csv.WriteRecords(records);
            }

            Console.WriteLine($"CSV file created at: {filePath}\n");
        }

        #endregion

        private static void RemoveEmployee()
        {
            Console.Write("\nEmployee ID: ");
            string stringID = Console.ReadLine();
            int intID;
            try
            {
                intID = Convert.ToInt32(stringID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\n");
                return;
            }

            foreach (Employee staff in employees)
            {
                if(staff.EmployeeID == intID)
                {
                    employees.Remove(staff);
                    return;
                }
                else
                {
                    Console.WriteLine("Employee not found!");
                    return;
                }
            }
        }

        private static void ViewEmployee()
        {
            //
        }

        private static void PageEmployee()
        {
            foreach (Employee staff in employees)
            {
                if (staff.JobTitle == "doctor" || staff.JobTitle == "nurse")
                    Console.WriteLine("Paging " + staff.JobTitle + " " + staff.LastName);
            }
        }

        static void SaveData()
        {
            WriteToCsv(employeesFilePath, employees);
        }

        static void PrintHelp()
        {
            Console.WriteLine("\tAvailable Commands:");
            Console.WriteLine("\tadd - Add a new employee to the portal.");
            Console.WriteLine("\tremove - Remove an employee from the portal");
            Console.WriteLine("\tload - Load existing employees from file.");
            Console.WriteLine("\tview - View an employee.");
            Console.WriteLine("\tpage - Page all medical employees.");
            Console.WriteLine("\tsave - Save all data.");
            Console.WriteLine("\tquit - Quit application.\n");
        }

        static void PrintInvalidCommand()
        {
            Console.WriteLine("Command not recognized, please try again.");
            Console.WriteLine("Type \"help\" for available commands.\n");
        }

        static void QuitApp()
        {
            int exitCode = 0; 
            Environment.Exit(exitCode);
        }
    }
}