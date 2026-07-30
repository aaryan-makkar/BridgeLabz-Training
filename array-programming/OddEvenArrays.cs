using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class OddEvenArrays
    {
        public static void run()
        {
            Console.Write("Enter a Natural Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int[] odd = new int[number / 2 + 1];
            int[] even = new int[number / 2 + 1];

            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    even[evenIndex++] = i;
                else
                    odd[oddIndex++] = i;
            }

            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
                Console.Write(odd[i] + " ");

            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
                Console.Write(even[i] + " ");
        }
    }
}
