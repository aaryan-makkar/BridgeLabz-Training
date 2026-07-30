using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class YoungestAndTallest
    {
        public static void run()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };

            int[] ages = new int[3];
            double[] heights = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of {names[i]}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter height of {names[i]}: ");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }

            int youngestIndex = 0;
            int tallestIndex = 0;

            for (int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[youngestIndex])
                    youngestIndex = i;

                if (heights[i] > heights[tallestIndex])
                    tallestIndex = i;
            }

            Console.WriteLine($"\nYoungest Friend: {names[youngestIndex]}");
            Console.WriteLine($"Tallest Friend: {names[tallestIndex]}");
        }
    }
}
