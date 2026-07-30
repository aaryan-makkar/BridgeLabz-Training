using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class KilometersToMiles
    {
        public static void convert()
        {
            Console.WriteLine("Enter distance in kilometers: ");
            int kilometers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The given distance in miles is {kilometers * 0.621371}");
        }
    }
}
