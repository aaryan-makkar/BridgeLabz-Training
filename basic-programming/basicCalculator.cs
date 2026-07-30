using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class basicCalculator
    {
        public static void calculate()
        {
            Console.WriteLine("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The addition, subtraction, multiplication, and division value of two numbers {number1} and {number2} is {number1+number2}, {number1-number2}, {number1*number2}, {number1/number2}");
        }
    }
}
