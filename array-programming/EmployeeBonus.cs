using System;
using System.Collections.Generic;
using System.Text;

namespace array_programming
{
    internal class EmployeeBonus
    {
        public static void run()
        {
            double[] salary = new double[10];
            double[] years = new double[10];
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}");

                Console.Write("Enter Salary: ");
                salary[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Years of Service: ");
                years[i] = Convert.ToDouble(Console.ReadLine());

                if (salary[i] <= 0 || years[i] < 0)
                {
                    Console.WriteLine("Invalid Input. Enter Again.");
                    i--;
                    continue;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (years[i] > 5)
                    bonus[i] = salary[i] * 0.05;
                else
                    bonus[i] = salary[i] * 0.02;

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }

            Console.WriteLine("\nEmployee Details");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(
                    $"Employee {i + 1}: Old Salary = {salary[i]}, Bonus = {bonus[i]}, New Salary = {newSalary[i]}"
                );
            }

            Console.WriteLine($"\nTotal Old Salary = {totalOldSalary}");
            Console.WriteLine($"Total Bonus = {totalBonus}");
            Console.WriteLine($"Total New Salary = {totalNewSalary}");
        }
    }
}
