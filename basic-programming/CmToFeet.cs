using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class CmToFeet
    {
        public static void ConvertHeight()
        {
            Console.WriteLine("Enter height in cm: ");
            int height = Convert.ToInt32(Console.ReadLine());
            double totalInches = height * (1 / 2.4);
            int feet = (int)totalInches / 12;
            int inches = (int)totalInches % 12;
            Console.WriteLine($"Your height in cm is {height} while in feet is {feet} and inches {inches}");
        }
    }
}
