using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Data.SqlClient;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace the following with your actual connection string
            string connectionString = "Your_Actual_Connection_String";

            // Sample data
            int employeeID = 1;
            string firstName = "John";
            string lastName = "Doe";
            DateTime birthDate = new DateTime(1990, 5, 15);
            decimal salary = 50000.00m;

            try
            {
                // Insert data into SQL Server using SqlKata
                InsertData(connectionString, employeeID, firstName, lastName, birthDate, salary);
                Console.WriteLine("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void InsertData(string connectionString, int employeeID, string firstName, string lastName, DateTime birthDate, decimal salary)
        {
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(new SqlConnection(connectionString), compiler);

            // Insert data into Employees table using SqlKata
            var query = db.Query("Employees").AsInsert(new
            {
                EmployeeID = employeeID,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Salary = salary
            });

            // Execute the SQL command
            db.Execute(query);
        }
    }
}