using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    internal class Circle
    {
        public double radius;
        public const double pi = Math.PI;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return pi * radius * radius;
        }

        public double Circumference()
        {
            return 2 * pi * radius;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"The area of the circle is {Area()} and the circumference of the circle is {Circumference()}");
        }
    }
}
