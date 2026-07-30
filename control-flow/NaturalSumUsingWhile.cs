using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class NaturalSumUsingWhile
    {
        public static void sum()
        {
            Console.Write("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
            {
                int sum = 0;
                int i = 1;

                while (i <= n)
                {
                    sum += i;
                    i++;
                }

                int formula = n * (n + 1) / 2;

                Console.WriteLine($"While Loop Sum = {sum}");
                Console.WriteLine($"Formula Sum = {formula}");
                Console.WriteLine($"Both are equal: {sum == formula}");
            }
        }
    }
}
