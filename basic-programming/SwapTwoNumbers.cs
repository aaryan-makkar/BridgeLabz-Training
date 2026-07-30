using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine($"The swapped numbers are {number1} and {number2}.");
        }
    }
}
