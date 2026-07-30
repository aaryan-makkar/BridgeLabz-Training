using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class NaturalSumUsingFor
    {
        public static void sum()
        {
            Console.Write("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            int formula = n * (n + 1) / 2;

            Console.WriteLine($"For Loop Sum = {sum}");
            Console.WriteLine($"Formula Sum = {formula}");
            Console.WriteLine($"Both are equal: {sum == formula}");
        }
    }
}
