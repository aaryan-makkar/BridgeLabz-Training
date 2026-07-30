using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class CountNumberOfDigits
    {
        public static void count()
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            int count = 0;

            
            if (number == 0)
            {
                count = 1;
            }
            else
            {
                while (number != 0)
                {
                    number = number / 10; 
                    count++;            
                }
            }

            Console.WriteLine($"Number of digits = {count}");
        }
    }
}
