using System;

namespace LineComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line = new LineLength();
            double firstLine = line.LengthOfLine(5, 7, 10, 12);
            double secondLine = line.LengthOfLine(4, 10, 6, 8);

            //to check equality
            if (firstLine.Equals(secondLine))
                Console.WriteLine("lines are equal");
            else
                Console.WriteLine("lines are not equal");

            //to compare
            double compareValue = (firstLine.CompareTo(secondLine));
            if (compareValue == 0)
            {
                Console.WriteLine("lines are equal");
            }
            else if (compareValue == 1)
            {
                Console.WriteLine("Second line is smaller than first line");
            }
            else
            {
                Console.WriteLine("First line is smaller than second line");
            }
        }
    }
}
