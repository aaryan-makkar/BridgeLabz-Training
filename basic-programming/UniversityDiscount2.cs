using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class UniversityDiscount2
    {
        public static void discount()
        {
            Console.WriteLine("Enter University Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter discount percent: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());
            double discount = (discountPercent / 100) * fee;

            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fee - discount}");
        }
    }
}
