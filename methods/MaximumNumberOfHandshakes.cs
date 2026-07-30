using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class MaximumNumberOfHandshakes
    {
        int CalculateHandshakes(int students)
        {
            return students * (students - 1) / 2;
        }
        public static void run()
        {
            MaximumNumberOfHandshakes handshakes = new MaximumNumberOfHandshakes();
            Console.Write("Enter number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The total number of handshakes are {handshakes.CalculateHandshakes(students)}");
        }
    }
}
