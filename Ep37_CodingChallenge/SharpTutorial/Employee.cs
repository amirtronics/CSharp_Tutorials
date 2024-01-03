namespace SharpTutorial
{
    internal class Employee :IPerson
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Specialty { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetDescription()
        {
            return GetFullName() + ", " + EmployeeID;
        }

        public string[] GetDescriptionArray()
        {
            string[] stringArray = { EmployeeID.ToString(), FirstName, LastName};

            return stringArray;
        }
    }
}
