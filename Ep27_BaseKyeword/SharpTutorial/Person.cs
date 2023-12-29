namespace SharpTutorial
{
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
