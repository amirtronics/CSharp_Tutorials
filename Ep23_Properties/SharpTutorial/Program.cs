using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kampa", "Plays")
            {
                Age = 99               
            };

            int age = person.Age;
            person.FirstName = "name";

            Console.ReadLine();
        }
    }
}