using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class IntegerOperations
    {
        public static void IntOperations()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int operation1 = number1 + number2 * number3;
            int operation2 = number1 * number2 + number3;
            int operation3 = number3 + number1 / number2;
            int operation4 = number1 % number2 + number3;

            Console.WriteLine($"The results of the Int Operations are {operation1}, {operation2}, {operation3} and {operation4}");
        }
    }
}
