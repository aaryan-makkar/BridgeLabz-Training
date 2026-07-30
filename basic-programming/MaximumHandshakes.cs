using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class MaximumHandshakes
    {
        public static void countHandshakes()
        {
            Console.WriteLine("Enter number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Maximum number of possible handshakes are {(numberOfStudents * (numberOfStudents - 1) / 2)}");
        }
    }
}
