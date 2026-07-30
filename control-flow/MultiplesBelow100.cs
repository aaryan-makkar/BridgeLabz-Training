using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class MultiplesBelow100
    {
        public static void multiples()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiples of {number} below 100:");

            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
