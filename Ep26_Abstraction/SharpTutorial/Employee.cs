namespace SharpTutorial
{
    internal class Employee : Person
    {
        public int EmployerNumber { get; set; }

        public override string GetDescription()
        {
            return GetFullName() + ", " + EmployerNumber;
        }
    }
}
