using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace C__basics
{
    internal class RemainderAndQuotient
    {
        public static void DisplayRemainderAndQuotient()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The quotient is {number1 / number2} and the remainder is {number1 % number2} of two numbers {number1} and {number2}.");
        }
    }
}
