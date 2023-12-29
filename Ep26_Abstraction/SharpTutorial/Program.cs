using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Kampa";
            employee.LastName = "Plays";
            employee.EmployerNumber = 1;


            Person person = employee;
            Console.WriteLine(person.GetDescription());

            Doctor doctor = new Doctor();
            doctor.FirstName = "Doc";
            doctor.LastName = "Holiday";
            doctor.EmployerNumber = 1;
            doctor.Specialty = "Brain stuff";

            Person person2 = doctor;
            Console.WriteLine(person2.GetDescription());

            Console.ReadLine();
        }
    }
}