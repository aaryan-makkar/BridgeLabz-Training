using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class Power
    {
        public static void findPower()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            Console.WriteLine($"{number}^{power} = {result}");
        }
    }
}
