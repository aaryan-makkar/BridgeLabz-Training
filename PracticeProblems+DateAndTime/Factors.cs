using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class Factors
    {

        static double sumOfSquares(int[] arr)
        {
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += Math.Pow(arr[i], 2);
            }
            return sum;
        }

        static int product(int[] arr)
        {
            int productOfFactors = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                productOfFactors*= arr[i];
            }

            return productOfFactors;
        }
        static int sum(int[] arr)
        {
            int sumOfFactors = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sumOfFactors += arr[i];
            }
            return sumOfFactors;
        }
        static int[] findFactors(int number)
        {
            int count = 0;
            for(int i = 1; i<= number; i++)
            {
                if(number%i == 0)
                {
                    count++;
                }
            }
            int[] arr = new int[count];
            int index = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    arr[index] = i;
                    index++;
                }
            }

            return arr;
        }
        public static void run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] factors = findFactors(number);

            Console.WriteLine("The factors are: ");
            foreach(int element in factors)
            {
                Console.WriteLine(element + " ");
            }
            int sumOfFactors = sum(factors);
            int productOfFactors = product(factors);
            double squareSum = sumOfSquares(factors);
            Console.WriteLine($"The sum of the factors is {sumOfFactors}, the product of factors is {productOfFactors} and the sum of square of factors is {squareSum}");
        }
    }
}
