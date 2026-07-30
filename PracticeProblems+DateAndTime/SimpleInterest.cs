using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class SimpleInterest
    {
        public static double CalculateSimpleInterest(double principle, double rate, double time)
        {
            return (principle * rate * time) / 100;
        }
        public static void run()
        {
            Console.Write("Enter principle amount: ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = CalculateSimpleInterest(principle, rate,time);
            Console.WriteLine($"The simple interest is {simpleInterest} for principle {principle}, rate of interest {rate} and time {time}");
        }
    }
}
