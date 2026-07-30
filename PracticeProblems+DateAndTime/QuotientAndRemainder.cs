using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class QuotientAndRemainder
    {
        static int[] findRemainderAndQuotient(int num1, int num2)
        {
            int quotient = num1 / num2;
            int remainader = num1 % num2;

            return new int[] { quotient, remainader };
        }
        public static void run()
        {
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int[] result = findRemainderAndQuotient(number1, number2);

            Console.WriteLine($"The quotient is {result[0]} and the remainder is {result[1]}");
        }
    }
}
