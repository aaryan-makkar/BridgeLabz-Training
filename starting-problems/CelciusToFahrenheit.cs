using System;
using System.Collections.Generic;
using System.Text;

namespace startingProblems
{
    internal class CelciusToFahrenheit
    {
        public static void convert()
        {
            Console.WriteLine("Enter temperature in celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celcius * 9 / 5) + 32;

            Console.WriteLine($"The temperature {celcius} degree in celcius is {fahrenheit} degree in fahreheit");
        }
    }
}
