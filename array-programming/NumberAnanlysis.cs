using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class NumberAnanlysis
    {
        public static void check()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    if (num % 2 == 0)
                        Console.WriteLine($"{num} is Positive and Even");
                    else
                        Console.WriteLine($"{num} is Positive and Odd");
                }
                else if (num < 0)
                    Console.WriteLine($"{num} is Negative");
                else
                    Console.WriteLine($"{num} is Zero");
            }

            Console.WriteLine("\nComparison of First and Last Element:");

            if (numbers[0] == numbers[4])
                Console.WriteLine("Equal");
            else if (numbers[0] > numbers[4])
                Console.WriteLine("First element is Greater");
            else
                Console.WriteLine("First element is Less");
        }
    }
}
