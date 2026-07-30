using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class SmallestAndLargest
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int largest = number1;
            int smallest = number1;

            if(number2>number1 && number2>number3)
            {
                largest = number2;
            }
            if(number3 > number2 && number3 > number1)
            {
                largest = number3;
            }
            if(number2<smallest)
            {
                smallest = number2;
            }
            if(number3<smallest)
            {
                smallest = number3;
            }

            return new int[] {smallest, largest};
        }
        public static void run()
        {
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int[] result = FindSmallestAndLargest(number1, number2, number3);

            Console.WriteLine($"The smallest number is {result[0]} and the largest number is {result[1]}");
        }
    }
}
