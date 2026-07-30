using System;
using System.Collections.Generic;
using System.Text;

namespace C__basics
{
    internal class TemperatureConversion
    {
        public static void CelciusToFahrenheit()
        {
            Console.WriteLine("Enter temperature in celcius: ");
            double celciusTemperature = Convert.ToDouble(Console.ReadLine());

            double fahrenheitTemperature = (celciusTemperature * 9 / 5) + 32;

            Console.WriteLine($"The {fahrenheitTemperature} Fahrenheit is {celciusTemperature} celcius.");
        }
    }
}
