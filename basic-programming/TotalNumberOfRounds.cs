using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class TotalNumberOfRounds
    {
        public static void TotalRounds()
        {
            Console.WriteLine("Enter the length of side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length of side 2: "); ;
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            int distance = 5;
            double perimeter = side1 + side2 + side3;
            double rounds = distance / perimeter;

            Console.WriteLine($"The total number of rounds the athelete will run is {rounds} to complete 5km.");
        }
    }
}
