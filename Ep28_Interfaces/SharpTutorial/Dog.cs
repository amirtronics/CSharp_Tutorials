namespace SharpTutorial
{
    internal class Dog : Animal, IMove, IMakeSound
    {
        public void Move()
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }
}
