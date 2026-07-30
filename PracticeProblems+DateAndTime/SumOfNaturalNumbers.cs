using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class SumOfNaturalNumbers
    {
        static int sum(int number)
        {
            int sum = 0;
            for(int i = 1; i <= number; i++)
            {
                sum+= i;
            }
            return sum;
        }
        public static void run()
        {
            Console.Write("Enter a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of {number} natural number is {sum(number)}");
        }
    }
}
