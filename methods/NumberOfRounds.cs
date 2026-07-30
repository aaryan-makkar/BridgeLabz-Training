using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class NumberOfRounds
    {
        double rounds(double side1, double side2, double side3, int distance)
        {
            return distance/(side1+side2+side3);
        }
        public static void run()
        {
            NumberOfRounds athelte = new NumberOfRounds();
            int distance = 5;

            Console.Write("Enter length of side1 of triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of side2 of triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of side3 of triangle: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The number of rounds the athelete has to run is: {athelte.rounds(side1, side2, side3, distance)}");
        }
    }
}
