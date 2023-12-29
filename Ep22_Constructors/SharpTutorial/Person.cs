namespace SharpTutorial
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {

        }

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public Person(string first, string last, int age)
        {

        }

        public string GetFullName()
        { 
            return firstName + " " + lastName; 
        }
    }
}
