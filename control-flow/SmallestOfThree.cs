using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SmallestOfThree
    {
        public static void smallest()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            bool isSmall;

            if(num1 < num2 && num1 < num3)
            {
                isSmall = true;
            }

            else isSmall = false;

            Console.WriteLine($"Is the first number the smallest? {isSmall}");
        }
    }
}
