namespace SharpTutorial
{
    internal class Doctor : Employee, IPageable
    {
        public string Specialty { get; set; }

        public void PageStaff()
        {

        }
    }
}
