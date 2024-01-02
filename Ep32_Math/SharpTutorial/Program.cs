using System;

namespace SharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find the lowest or highest value between two values
            int lowestValue = Math.Min(1, 2); // 1
            double highestValue = Math.Max(1.1, 2); // 2

            //rounds up or down
            //if it's halfway between it always rounds towards the even integer
            double rounded = Math.Round(9.5); // 10
            double rounded2 = Math.Round(10.5); // 10
            double rounded3 = Math.Round(10.4); // 10
            double rounded4 = Math.Round(10.51); // 11
            double rounded5 = Math.Round(10.51234, 3); // 10.512
            double rounded6 = Math.Round(-11.5, MidpointRounding.AwayFromZero); // 11

            //force a round up or down
            double roundDown = Math.Floor(9.9); // 9
            double roundUp = Math.Ceiling(9.1); // 10

            //trigonometric functions
            double sin = Math.Sin(0);
            double cos = Math.Cos(0);
            double tan = Math.Tan(0);
            double arcSin = Math.Asin(0);
            double arcCos = Math.Acos(0);
            double arcTan = Math.Atan(0);

            //other math functions
            double squareRoot = Math.Sqrt(144); // 112
            double power = Math.Pow(2, 3); // 8
            double absoluteValue = Math.Abs(squareRoot - 15); // 15

            Console.ReadLine();
        }
    }
}