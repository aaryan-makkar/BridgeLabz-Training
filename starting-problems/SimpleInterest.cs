using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class SimpleInterest
    {
        public static void calculateSI()
        {
            Console.WriteLine("Enter Principle amount: ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate of Interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The simple interest is {(principle * rate * time) / 100}");
        }
    }
}
