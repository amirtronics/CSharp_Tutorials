namespace SharpTutorial
{
    internal class Boat : Vehicle, IMove, IMakeSound
    {
        public void Move()
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("honk");
        }
    }
}
