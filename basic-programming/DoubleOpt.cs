using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class DoubleOpt
    {
        public static void DoubleOperations()
        {
            Console.WriteLine("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double operation1 = number1 + number2 * number3;
            double operation2 = number1 * number2 + number3;
            double operation3 = number3 + number1 / number2;
            double operation4 = number1 % number2 + number3;

            Console.WriteLine($"The results of the Double Operations are {operation1}, {operation2}, {operation3} and {operation4}");
        }
    }
}
