using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class NumberAnalysis
    {
        static int checkNumber(int number)
        {
            if (number > 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                return -1;
            }
            else return 0;
        }
        public static void run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{checkNumber(number)}");
        }
    }
}
