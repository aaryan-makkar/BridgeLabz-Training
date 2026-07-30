using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class KilometersToMiles
    {
        public static void Convert()
        {
            double distanceInKilometers = 10.8;
            double distanceInMiles = distanceInKilometers * 1.6;
            Console.WriteLine($"The distance {distanceInKilometers} in miles is {distanceInMiles}");
        }
    }
}
