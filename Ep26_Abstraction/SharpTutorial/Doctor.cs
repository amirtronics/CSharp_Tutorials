namespace SharpTutorial
{
    internal class Doctor : Employee
    {
        public string Specialty { get; set; }

        public override string GetDescription()
        {
            return GetFullName() + ", " + EmployerNumber +  ", " + Specialty;
        }
    }
}


