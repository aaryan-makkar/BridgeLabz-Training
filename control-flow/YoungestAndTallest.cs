using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow
{
    internal class YoungestAndTallest
    {
        public static void check()
        {
            Console.Write("Enter Amar's age: ");
            int amarAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Akbar's age: ");
            int akbarAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Anthony's age: ");
            int anthonyAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amar's height (in cm): ");
            double amarHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Akbar's height (in cm): ");
            double akbarHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Anthony's height (in cm): ");
            double anthonyHeight = Convert.ToDouble(Console.ReadLine());

            
            string youngestFriend;
            int youngestAge;

            if (amarAge <= akbarAge && amarAge <= anthonyAge)
            {
                youngestFriend = "Amar";
                youngestAge = amarAge;
            }
            else if (akbarAge <= amarAge && akbarAge <= anthonyAge)
            {
                youngestFriend = "Akbar";
                youngestAge = akbarAge;
            }
            else
            {
                youngestFriend = "Anthony";
                youngestAge = anthonyAge;
            }

            
            string tallestFriend;
            double tallestHeight;

            if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
            {
                tallestFriend = "Amar";
                tallestHeight = amarHeight;
            }
            else if (akbarHeight >= amarHeight && akbarHeight >= anthonyHeight)
            {
                tallestFriend = "Akbar";
                tallestHeight = akbarHeight;
            }
            else
            {
                tallestFriend = "Anthony";
                tallestHeight = anthonyHeight;
            }

            Console.WriteLine();
            Console.WriteLine($"Youngest Friend: {youngestFriend} (Age: {youngestAge})");
            Console.WriteLine($"Tallest Friend: {tallestFriend} (Height: {tallestHeight} cm)");
        }
    }
}
