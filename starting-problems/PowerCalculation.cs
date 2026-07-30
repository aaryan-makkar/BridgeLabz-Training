using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class PowerCalculation
    {
        public static void power()
        {
            Console.Write("Enter the base: ");
            double baseNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine($"{baseNumber} raised to the power {exponent} is {result}");
        }
    }
}
