using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class MultiplicationTable
    {
        public static void run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
}
}
