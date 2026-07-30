using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SpringSeason
    {
        public static void checkSeason()
        {
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            bool spring =
                (month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20);

            Console.WriteLine(spring ? "Its a Spring Season" : "Not a Spring Season");
        }
    }
}
