using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kampa";

            Employee employee = new Employee();
            employee.EmployeeNumber = 1;
            employee.FirstName = "Kampa";
            string name  = employee.GetFullName();

            Doctor doc = new Doctor();
            doc.FirstName = "";
            doc.EmployeeNumber = 1;
            doc.Specialty = "";

            Console.ReadLine();
        }
    }
}