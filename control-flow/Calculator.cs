using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class Calculator
    {
        public static void calculate()
        {
            Console.Write("Enter first number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result = {first + second}");
                    break;

                case "-":
                    Console.WriteLine($"Result = {first - second}");
                    break;

                case "*":
                    Console.WriteLine($"Result = {first * second}");
                    break;

                case "/":
                    if (second != 0)
                    {
                        Console.WriteLine($"Result = {first / second}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
