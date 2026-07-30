using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class MultiplicationTable6To9
    {
        public static void run()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] result = new int[4];

            int index = 0;

            for (int i = 6; i <= 9; i++)
            {
                result[index++] = number * i;
            }

            index = 0;

            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {result[index++]}");
            }
        }
    }
}
