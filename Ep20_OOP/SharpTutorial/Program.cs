using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            while (true)
            {
                Console.Write("Enter your first name: ");
                string firstNameInput = Console.ReadLine();

                if (firstNameInput == "done")
                {
                    Console.Clear();
                    break;
                }

                Console.Write("Enter your last name: ");
                string lastNameInput = Console.ReadLine();
                Console.Write("Enter your age: ");
                int ageInput = Convert.ToInt32(Console.ReadLine());

                Person person = new Person();
                person.Firstname = firstNameInput;
                person.Lastname = lastNameInput;
                person.Age = ageInput;

                people.Add(person);

                Console.Clear();

            }

            foreach(Person person in people)
            {
                string fullname = person.GerFullName();
            }

        }
    }
}