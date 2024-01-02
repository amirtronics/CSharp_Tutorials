namespace SharpTutorial
{
    internal class Employee :IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public int EmployerNumber { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetDescription()
        {
            return GetFullName() + ", " + EmployerNumber;
        }
    }
}
