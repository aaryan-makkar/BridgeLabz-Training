using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class FactorialUsingWhile
    {
        public static void factorial()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            int i = 1;

            while (i <= n)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"Factorial = {factorial}");
        }
    }
}
