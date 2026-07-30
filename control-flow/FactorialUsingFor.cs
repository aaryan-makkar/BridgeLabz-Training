using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class FactorialUsingFor
    {
        public static void factorial()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial = {factorial}");
        }
    }
}
