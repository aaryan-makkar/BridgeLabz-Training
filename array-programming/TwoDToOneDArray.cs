using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class TwoDToOneDArray
    {
        public static void run()
        {
            Console.Write("Enter Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter Matrix Elements:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] array = new int[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[index++] = matrix[i, j];
                }
            }

            Console.WriteLine("1D Array:");

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
