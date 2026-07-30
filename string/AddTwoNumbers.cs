using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class AddTwoNumbers
    {
        public static void add()
        {
            Console.WriteLine("Enter 1st number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of numbers is {number1 + number2}");
        }
    }
}
