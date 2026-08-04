using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    interface Refuelable
    {
        void Refuel();
    }
    internal class VehicleBase
    {
        public int MaxSpeed { get; set; }
        public string Model { get; set; }

        public VehicleBase(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
        }
    }

    class ElectricVehicle : VehicleBase
    {
        public ElectricVehicle(int maxSpeed, string model)
            : base(maxSpeed, model)
        {
        }

        public void Charge()
        {
            Console.WriteLine($"{Model} is charging.");
        }
    }

    class PetrolVehicle : VehicleBase, Refuelable
    {
        public PetrolVehicle(int maxSpeed, string model)
            : base(maxSpeed, model)
        {
        }

        public void Refuel()
        {
            Console.WriteLine($"{Model} is being refueled.");
        }
    }
}
