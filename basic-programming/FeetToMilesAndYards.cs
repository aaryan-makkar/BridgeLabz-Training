using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class FeetToMilesAndYards
    {
        public static void ConvertDistance()
        {
            Console.WriteLine("Enter distance in feet: ");
            int feet = Convert.ToInt32(Console.ReadLine());

            double yards = feet / 3;

            double miles = yards / 1760;

            Console.WriteLine($"The distance in feet is {feet}, {miles} in miles, {yards} in yards.");
        }
    }
}
