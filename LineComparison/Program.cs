﻿using System;

namespace LineComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line = new Line();
            Line line1 = new Line();
            line.LengthOfLine(5, 7, 10, 12);
            line1.LengthOfLine(4, 10, 6, 8);

            //to check equality
            if (line.Equals(line1))
                Console.WriteLine("lines are equal");
            else
                Console.WriteLine("lines are not equal");
        }
    }
}
