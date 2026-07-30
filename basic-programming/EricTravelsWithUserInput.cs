using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class EricTravelsWithUserInput
    {
        public static void TotalTimeAndDistance()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter From City: ");
            string fromCity = Console.ReadLine();
            Console.WriteLine("Enter via city: ");
            string viaCity = Console.ReadLine();
            Console.WriteLine("Enter destination city: ");
            string toCity = Console.ReadLine();
            Console.WriteLine("Enter Distance from FROM city to VIA city: ");
            double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time taken from FROM city to VIA city in minutes: ");
            int timeFromToVia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter distance from VIA city to DESTINATION city: ");
            double distanceViaToDestination = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time taken from FROM city to DESTINATION city in minutes: ");
            int timeViaToDestination = Convert.ToInt32(Console.ReadLine());

            double totalDistance = distanceFromToVia + distanceViaToDestination;
            int totalTime = timeFromToVia + timeViaToDestination;

            Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance}km and the total time taken is {totalTime}minutes");
        }
    }
}
