namespace SharpTutorial
{
    internal interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetFullName();
        string GetDescription();


        /*
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string GetDescription();

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        */
    }
}