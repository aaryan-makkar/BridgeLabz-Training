using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class SumUntil0
    {
        public static void sum()
        {
            double total = 0;
            double number;

            Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToDouble(Console.ReadLine());

            while (number != 0)
            {
                total += number;

                Console.Write("Enter a number (0 to stop): ");
                number = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Total = {total}");
        }
    }
}
