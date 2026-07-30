using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class CountTo1UsingFor
    {
        public static void count()
        {
            Console.Write("Enter starting number: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
