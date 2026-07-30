using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class LeapYearOrNot
    {
        static bool checkLeap(int year)
        {
            if (year < 1582)
            {
                return false;
            }
            else if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else return false;
        }
        public static void run()
        {
            Console.Write("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is the entered year leap? {checkLeap(year)}");
        }
    }
}
