using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class volumeOfEarth
    {
        public static void Volume()
        {
            const double pi = 3.14;
            int radiusInKm = 6378;
            double radiusInMiles = radiusInKm * 1.6;
            Console.WriteLine($"The volume of earth in cubic kilometers is {(4 / 3) * pi * radiusInKm * radiusInKm * radiusInKm} and cubic miles is {(4 / 3) * pi * radiusInMiles * radiusInMiles * radiusInMiles}.");
        }
    }
}
