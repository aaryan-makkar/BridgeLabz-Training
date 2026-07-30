using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class FactorsOfNumber
    {
        public static void findFactors()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Factors of {number} are:");

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
