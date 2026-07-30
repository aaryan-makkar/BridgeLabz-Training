using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class SpringSeason
    {
        static bool isSpring(int month, int date)
        {
            if((month == 3 && date >= 20) ||
        (month == 4) ||
        (month == 5) ||
        (month == 6 && date <= 20))
            {
                return true;
            }
            else return false;
        }
        public static void run()
        {
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter date: ");
            int date = Convert.ToInt32(Console.ReadLine());

            if(isSpring(month, date))
            {
                Console.WriteLine("It's spring season");
            }
            else
            {
                Console.WriteLine("Not spring season");
            }

        }
    }
}
