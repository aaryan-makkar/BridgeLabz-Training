using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class LeapYearUsingMultipleConditions
    {
        public static void checkLeap()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 1582)
            {
                Console.WriteLine("Please enter a year greater than or equal to 1582.");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}
