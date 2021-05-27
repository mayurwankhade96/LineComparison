using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class Line
    {
        public double LengthOfLine(double xOne,double yOne,double xTwo, double yTwo)
        {
            double distanceBetwnTwoPoints = Math.Sqrt(Math.Pow(xTwo - xOne, 2) + Math.Pow(yTwo - yOne, 2));
            Console.WriteLine(distanceBetwnTwoPoints);
            return distanceBetwnTwoPoints;
        }
    }
}
