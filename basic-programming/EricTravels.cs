using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class EricTravels
    {
        public static void ToatalTimeAndDistance()
        {
            string name = "Eric";
            string fromCity = "Chennai", viaCity = "Vellore", toCity = "Banglore";

            double distanceFromToVia = 156.6;
            int timeFromToVia = 4 * 60 + 4;
            double distanceViaToDestination = 211.8;
            int timeViaToDestination = 4 * 60 + 25;

            double totalDistance = distanceFromToVia + distanceViaToDestination;
            int totalTime = timeFromToVia + timeViaToDestination;

            Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance}km and the total time taken is {totalTime}minutes");
        }
    }
}
