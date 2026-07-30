using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class VotingEligibility
    {
        public static void check()
        {
            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nResult:");

            foreach (int age in ages)
            {
                if (age < 0)
                    Console.WriteLine("Invalid Age");
                else if (age >= 18)
                    Console.WriteLine($"The student with age {age} can vote.");
                else
                    Console.WriteLine($"The student with age {age} cannot vote.");
            }
        }
    }
}
