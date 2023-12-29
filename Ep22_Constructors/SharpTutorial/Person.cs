namespace SharpTutorial
{
    internal class Person
    {
        private readonly string firstName;
        private readonly string lastName;
        private int age;

        public Person()
        {
                
        }

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName; 
        }
    }
}
