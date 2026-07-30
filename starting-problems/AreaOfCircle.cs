using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class AreaOfCircle
    {
        public static void area()
        {
            const double pi = 3.14;
            Console.WriteLine("Enter radius of circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Area of circle is {pi * radius * radius}");
        }
    }
}
