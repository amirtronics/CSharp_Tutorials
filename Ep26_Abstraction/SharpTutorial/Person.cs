namespace SharpTutorial
{
    //abstraction - OOP concept
    // hide away certain logic, expose only what we need at any given level
    // you can create an object of an abstract class
    //base class (parent)

    abstract internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string GetDescription();

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
