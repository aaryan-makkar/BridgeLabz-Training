using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class StoreNumbersAndSum
    {
        public static void run()
        {
            double[] numbers = new double[10];
            double total = 0;
            int index = 0;

            while (true)
            {
                Console.Write("Enter Number: ");
                double num = Convert.ToDouble(Console.ReadLine());

                if (num <= 0)
                    break;

                if (index == 10)
                    break;

                numbers[index] = num;
                index++;
            }

            Console.WriteLine("\nNumbers Entered:");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }

            Console.WriteLine($"Sum = {total}");
        }
    }
}
