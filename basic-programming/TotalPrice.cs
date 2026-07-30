using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class TotalPrice
    {
        public static void calculateTotalPrice()
        {
            Console.WriteLine("Enter unitPrice: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The total purchase price is INR {unitPrice * quantity} and unit price is INR {unitPrice}");
        }
    }
}
