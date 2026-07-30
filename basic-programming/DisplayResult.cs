using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class DisplayResult
    {
        public static void ShowResult()
        {
            string name = "Sam";
            int rollNumber = 1;
            double percentMarks = 99.99;
            char result = 'P';
            Console.WriteLine($"Displaying Result:\n{name} with Roll Number {rollNumber} has Scored {percentMarks}% Marks and the Reslult is {result}.");
        }
    }
}
