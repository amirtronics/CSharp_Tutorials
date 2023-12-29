namespace SharpTutorial
{
    //base class (parent)
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName() 
        { 
            return FirstName + " " + LastName; 
        }
    }
}
