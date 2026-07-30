using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class TotalIncome
    {
        public static void SalaryAndBonus()
        {
            Console.WriteLine("Enter salary of the individual: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Bonus of the individual: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            double totalIncome = salary + bonus;

            Console.WriteLine($"The salary is INR {salary} and the bonus  is INR {bonus}. Hence the salary is INR {totalIncome}.");
        }
    }
}
