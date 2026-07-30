using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class ProfitAndLoss
    {
        public static void ProfitLoss()
        {
            double costPrice = 129;
            double sellingPrice = 191;
            //int profit = sellingPrice - costPrice;

            Console.WriteLine($"The cost price is INR {costPrice} and selling price is INR {sellingPrice} \nThe Profit is INR {sellingPrice - costPrice} and the profit percentage is {((sellingPrice-costPrice)/sellingPrice)*100}");
        }
    }
}
