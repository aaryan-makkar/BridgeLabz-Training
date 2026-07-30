using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class CountTo1
    {
        public static void count()
        {
            Console.Write("Enter starting number: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
        }
    }
}
