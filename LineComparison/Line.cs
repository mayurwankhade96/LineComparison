using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public abstract class Line
    {
        public abstract double LengthOfLine(double xOne, double yOne, double xTwo, double yTwo);
    }
    public class LineLength : Line
    {
        public override double LengthOfLine(double xOne,double yOne,double xTwo, double yTwo)
        {
            double distanceBetwnTwoPoints = Math.Sqrt(Math.Pow(xTwo - xOne, 2) + Math.Pow(yTwo - yOne, 2));
            Console.WriteLine(distanceBetwnTwoPoints);
            return distanceBetwnTwoPoints;
        }
    }
}
