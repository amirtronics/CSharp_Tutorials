namespace SharpTutorial
{
    internal class Employee : Person
    {
        public int EmployerNumber { get; set; }

        public Employee(string first, string last, int number)
        {
            FirstName = first;
            LastName = last;
            EmployerNumber = number;
        }

        public override string GetDescription()
        {
            return GetFullName() + ", " + EmployerNumber;
        }
    }
}
