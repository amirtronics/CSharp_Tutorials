namespace SharpTutorial
{
    internal class Nurse : Employee, IPageable
    {
        public void PageStaff()
        {
            Console.WriteLine("Paging Nurse " + LastName + "!");
        }
    }
}
