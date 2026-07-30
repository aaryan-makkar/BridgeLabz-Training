using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class AreaOfTriangle
    {
        public static void Area()
        {
            Console.WriteLine("Enter base of triangle: ");
            int baseOfTriangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter height of triangle: ");
            int heightOfTriangle = Convert.ToInt32(Console.ReadLine());
            double area = (baseOfTriangle * heightOfTriangle)/2;
            Console.WriteLine($"Area of triangle in square inches is {area} and in square centimeters is {area*2.4*2.4}");
        }
    }
}
