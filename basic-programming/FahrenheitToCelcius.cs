using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class FahrenheitToCelcius
    {
        public static void TemperatureConversion()
        {
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            double fahrenheitTemperature = Convert.ToDouble(Console.ReadLine());
            double celciusTemperature = (fahrenheitTemperature - 32) * 5 / 9;

            Console.WriteLine($"The {fahrenheitTemperature} fahrenheit is {celciusTemperature} celcius.");
        }
    }
}
