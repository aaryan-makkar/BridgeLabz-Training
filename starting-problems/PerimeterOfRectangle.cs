using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class PerimeterOfRectangle
    {
        public static void perimeter()
        {
            Console.WriteLine("Enter length of rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth of rectangle: ");
            int breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The perimeter of rectangle is {2 * (length + breadth)}");
        }
    }
}
