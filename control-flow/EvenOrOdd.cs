using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class EvenOrOdd
    {
        public static void checkEvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} is Even");
                else
                    Console.WriteLine($"{i} is Odd");
            }
        }
    }
}
