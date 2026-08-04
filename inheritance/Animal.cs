using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Animal
    {
        private string name;
        private int age;
        internal virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    internal class Dog:Animal
    {
        internal override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    internal class Cat:Animal
    {
        internal override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Bird:Animal
    {
        internal void MakeSound()
        {
            Console.WriteLine("Bird Chirps");
        }
    }
}
