using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class sumUntil0WithBreak
    {
        public static void sum()
        {
            double total = 0;

            while (true)
            {
                Console.Write("Enter a number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number <= 0)
                    break;

                total += number;
            }

            Console.WriteLine($"Total = {total}");
        }
    }
}
