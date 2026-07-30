using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class PoundsToKilogram
    {
        public static void weightConversion()
        {
            Console.WriteLine("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kilos = pounds / 2.2;

            Console.WriteLine($"The weight of the person in pounds is {pounds} and in kgs is {kilos}");
        }
    }
}
