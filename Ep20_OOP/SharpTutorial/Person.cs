namespace SharpTutorial
{
    internal class Person
    {
        public string Firstname;
        public string Lastname;
        public int Age;
        public string FavouriteColor;

        public string GerFullName()
        {
            return Firstname + " " + Lastname;
        }

    }
}
