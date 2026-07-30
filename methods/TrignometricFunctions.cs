using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class TrignometricFunctions
    {
        static double[] CalculateTrignometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;

            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            return new double[] { sine, cosine, tangent };
        }
        public static void run()
        {
            Console.Write("Enter angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            double[] result = CalculateTrignometricFunctions(angle);

            Console.WriteLine($"Sin({angle}) = {result[0]} \nCosine({angle}) = {result[1]} \nTangent({angle}) = {result[2]}");
        }
    }
}
