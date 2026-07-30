using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class AverageMarks
    {
        public static void findAverage()
        {
            int mathsMarks = 94;
            int PhysicsMarks = 95;
            int ChemistryMarks = 96;

            int average = (94 + 95 + 96) / 3;

            Console.WriteLine($"Sam's average mark in PCM is {average}.");
        }
    }
}
