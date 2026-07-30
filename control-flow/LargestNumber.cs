using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class LargestNumber
    {
        public static void Largest()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            bool isLargest1;
            bool isLargest2;
            bool isLargest3;

            if (num1 > num2 && num1 > num3)
            {
                isLargest1 = true;
            }

            else isLargest1 = false;

            if (num2 > num1 && num2 > num3)
            {
                isLargest2 = true;
            }

            else isLargest2 = false;

            if (num3 > num1 && num3 > num2)
            {
                isLargest3 = true;
            }

            else isLargest3 = false;

            Console.WriteLine($"Is the first number the Largest? {isLargest1}");

            Console.WriteLine($"Is the seccond number the Largest? {isLargest2}");

            Console.WriteLine($"Is the third number the Largest? {isLargest3}");
        }
    }
}
