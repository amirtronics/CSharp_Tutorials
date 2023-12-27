namespace SharpTutorial
{
    internal class Challenge
    {
        public static decimal num1, num2;

        static void Main(string[] args)
        {
            bool canConvert = false;

            while (!canConvert)
            {
                Console.Write("Please enter first number: ");
                string numString1 = Console.ReadLine();

                decimal numberTemp = 0;

                canConvert = decimal.TryParse(numString1, out numberTemp);
                if (canConvert)
                    num1 = numberTemp;
                else
                    Console.WriteLine(numString1 + " is not a valid decimal, try again!");

                Console.Write("Please enter second number: ");
                string numString2 = Console.ReadLine();

                canConvert = decimal.TryParse(numString2, out numberTemp);
                if (canConvert)
                    num2 = numberTemp;
                else
                    Console.WriteLine(numString2 + " is not a valid decimal, try again!");
            }

            decimal product = num1 * num2;
            Console.WriteLine("The answer is: " + product);

            Console.ReadLine();
        }
    }
}