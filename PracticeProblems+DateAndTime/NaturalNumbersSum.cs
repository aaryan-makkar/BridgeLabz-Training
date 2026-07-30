using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class NaturalNumbersSum
    {
        static int findSum(int number)
        {
            if(number == 0)
            {
                return 0;
            }
            return number + findSum(number - 1);
        }
        public static void run()
        {
            Console.Write("Enter a natural number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            int reccrusiveSum = findSum(number);

            int formulaSum = number*(number + 1) / 2;

            Console.WriteLine($"The sum by recursion is {reccrusiveSum} and the sum by formula is {formulaSum}. Are both same? {formulaSum == reccrusiveSum}");
        }
    }
}
