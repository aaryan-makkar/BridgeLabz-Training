using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class VolumeOfCylinder
    {
        public static void volume()
        {
            const double pi = 3.14;
            Console.WriteLine("Enter radius of cylinder: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of cylinder: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Volume of cylinder is {pi * radius * radius * height}");
        }
    }
}
