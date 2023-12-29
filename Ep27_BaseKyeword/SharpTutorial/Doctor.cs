namespace SharpTutorial
{
    internal class Doctor : Employee
    {
        public Doctor(string first, string last, int number, string specialty) : base(first, last, number)
        {
            Specialty = specialty;
        }

        public string Specialty { get; private set; }


        public override string GetDescription()
        {
            return base.GetDescription() + ", " + Specialty;
        }
    }
}


