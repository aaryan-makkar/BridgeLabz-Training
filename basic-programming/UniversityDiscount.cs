using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class UniversityDiscount
    {
        public static void discount()
        {
            double fee = 125000;
            double discountPercent = 10;
            double discount = (discountPercent / 100) * 125000;

            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fee - discount}");
        }
    }
}
