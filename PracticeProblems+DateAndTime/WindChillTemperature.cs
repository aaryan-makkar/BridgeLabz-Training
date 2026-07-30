using System;
using System.Collections.Generic;
using System.Text;

namespace C__Methods
{
    internal class WindChillTemperature
    {
        static double CalculateWindChillTemperature(double temperature, double windSpeed)
        {
            return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * windSpeed * 0.16;
        }
        public static void run()
        {
            Console.Write("Enter temperature: ");
            double temperatue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter wind speed: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The wind chill temperature is: {CalculateWindChillTemperature(temperatue, windSpeed)}");
        }
    }
}
