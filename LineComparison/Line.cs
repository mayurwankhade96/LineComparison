using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class Line
    {
        public void LengthOfLine(double x1,double y1,double x2, double y2)
        {
            double distanceBetwnTwoPoints = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(distanceBetwnTwoPoints);
        }
    }
}
