using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Kampa", "Plays", 1);

            Person person = employee;
            Console.WriteLine(person.GetDescription());

            Doctor doctor = new Doctor("Doc", "Holiday", 1, "Brain stuff");

            Person person2 = doctor;
            Console.WriteLine(person2.GetDescription());

            Console.ReadLine();
        }
    }
}