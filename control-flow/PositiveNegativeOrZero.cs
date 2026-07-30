using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class PositiveNegativeOrZero
    {
        public static void checkNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("The number is zero");
            }
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
        }
    }
}
