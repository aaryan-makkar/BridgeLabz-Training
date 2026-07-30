using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class NumberOfChocolates
    {
        public static void DivideChocolates()
        {
            Console.WriteLine("Enter the number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The number of chocolates each child gets is {numberOfChocolates/numberOfChildren} and the number of remaining chocolates is {numberOfChocolates%numberOfChildren}.");
        }
    }
}
