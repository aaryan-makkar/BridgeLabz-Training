using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class DivisibleBy5
    {
        public static void divisible()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isDivisible;

            if (number % 5 == 0)
            {
                isDivisible = true;
                //Console.WriteLine($"Is the {number} divisible by 5? Yes")
            }
            else isDivisible = false;

            Console.WriteLine($"Is the {number} divisble by 5? {isDivisible}");
        }
    }
}
