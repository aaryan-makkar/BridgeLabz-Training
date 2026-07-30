using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SumOfNaturalNumbers
    {
        public static void sum()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = number * (number + 1) / 2;

            if(number>0)
            {
                Console.WriteLine($"The sum of {number} natural numbers is {sum}");
            }
            else
            {
                Console.WriteLine($"The number {number} is not a natural number");
            }
        }
    }
}
