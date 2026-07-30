using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class SimpleInterest
    {
        public static void CalculateSimpleInterest()
        {
            Console.WriteLine("Enter Principle amount: ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time: ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rate of interest: ");
            int interest = Convert.ToInt32(Console.ReadLine());

            double simpleInterest = (principle*interest*time)/100;

            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principle {principle}, Rate of Interest {interest} and time {time}.");
        }
    }
}
