using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Control_Flow
{
    internal class CanVoteOrNot
    {
        public static void canVote()
        {
            Console.WriteLine("Enter person's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            

            if (age >= 18)
            {
                Console.WriteLine($"The perosn's age is {age} and can vote");
            }
            else
            {
                Console.WriteLine($"The person's age is {age} and cannot vote.");
            }
            
        }
    }
}
