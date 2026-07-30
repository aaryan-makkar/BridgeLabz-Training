using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class AbundantNumber
    {
        public static void check()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            int sum = 0;

            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            
            if (sum > number)
            {
                Console.WriteLine($"{number} is an Abundant Number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Abundant Number.");
            }
        }
    }
}
