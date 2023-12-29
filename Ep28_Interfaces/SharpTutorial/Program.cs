using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Boat boat = new Boat();

            List<IMove> movableEntities = new List<IMove>() { dog, boat};
            foreach (var entity in movableEntities)
                entity.Move();

            List<IMakeSound> soundables = new List<IMakeSound>() { dog, boat };
            foreach (var entity in soundables)
                entity.MakeSound();

            //foreach thing that CAN move
            // thing.Move()

            /*
            Employee employee = new Employee
            {
                FirstName = "Kampa",
                LastName = "Plays",
                EmployerNumber = 99
            };

            IPerson myPerson = employee;

            Console.WriteLine(myPerson.GetDescription());
            */

            Console.ReadLine();
        }
    }
}