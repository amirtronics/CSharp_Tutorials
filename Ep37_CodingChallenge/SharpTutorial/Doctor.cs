namespace SharpTutorial
{
    internal class Doctor : Employee, IPageable
    {
        public void PageStaff()
        {
            Console.WriteLine("Paging Doctor " + LastName + "!");
        }
    }
}
