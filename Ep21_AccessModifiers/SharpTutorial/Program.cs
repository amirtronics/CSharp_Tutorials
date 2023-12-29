using System;

namespace SharpTutorial
{
    internal class Program
    {
        /*
         * 
         * Access Modifiers: Used to define where the item (class/method/field/etc) can be used 
         * Enables ENCAPSULATION (OOP Concept)
         *      - Keeping data together with its relevant methods
         *      - Restricting direct access to this data to keep things simple and safe from unwanted modifications.
         ------------------------------------------------------
                public: Can be used in any class
                private: Can only be used in the class it is in
        -------------------------------------------------------
                protected: Can only be used in the class it is in or classes derived from it.
                internal: Can be used in any class in the current assembly
                protected internal: Can be used in any class in the current assembly or classes in other assemblies derived from the class it is in 
                private protected: Can only be used in the class it is in or classes derived fromit within the current assembly.
        */



        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kampa";
            person.LastName = "Plays";
            person.Age = 20;

            Console.WriteLine(person.GetFullName());
            Console.ReadLine();
        }
    }
}