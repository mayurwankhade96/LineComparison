using System;

namespace LineComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line = new Line();
            Line line1 = new Line();
            double lineOne = line.LengthOfLine(5, 7, 10, 12);
            double lineTwo = line1.LengthOfLine(4, 10, 6, 8);

            //to check equality
            if (lineOne.Equals(lineTwo))
                Console.WriteLine("lines are equal");
            else
                Console.WriteLine("lines are not equal");

            //to compare
            double compareValue = (lineOne.CompareTo(lineTwo));
            if (compareValue == 0)
            {
                Console.WriteLine("lines are equal");
            }
            else if (compareValue == 1)
            {
                Console.WriteLine("lineTwo is smaller than lineOne");
            }
            else
            {
                Console.WriteLine("lineOne is smaller than lineTwo");
            }
        }
    }
}
