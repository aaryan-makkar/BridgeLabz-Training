using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class KmToMiles
    {
        public static void Distance()
        {
            Console.WriteLine("Enter distance in km: ");
            double kmDistance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total miles is {kmDistance * 1.6} mile for the given {kmDistance} km");
        }
    }
}
