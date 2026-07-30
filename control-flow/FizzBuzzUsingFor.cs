using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class FizzBuzzUsingFor
    {
        public static void fizzBuzz()
        {
            Console.Write("Enter a positive integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= number; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
        }
    }
}
