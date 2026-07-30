using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class AverageOfThreeNumbers
    {
        public static void average()
        {
            Console.WriteLine("Enter 1st number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The average of three numbers is {(number1 + number2 + number3) / 3}");

        }
    }
}
