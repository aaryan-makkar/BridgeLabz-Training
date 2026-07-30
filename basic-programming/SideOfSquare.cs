using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class SideOfSquare
    {
        public static void Side()
        {
            Console.WriteLine("Enter perimeter of square: ");
            int perimeter = Convert.ToInt32(Console.ReadLine());

            int side = perimeter / 4;

            Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
        }
    }
}
