using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class DayOfWeek
    {
        public static void check()
        {
            Console.Write("Enter month (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter day: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            
            int y0 = y - (14 - m) / 12;

            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

            int m0 = m + 12 * ((14 - m) / 12) - 2;

            int d0 = (d + x + (31 * m0) / 12) % 7;

            Console.WriteLine($"Day of week = {d0}");

            
            string[] days =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            Console.WriteLine($"The day is {days[d0]}");
        }
    }
}
