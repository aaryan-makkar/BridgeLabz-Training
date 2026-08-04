using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Device
    {
        public int DeviceId { get; set; }
        public string Status { get; set; }

        public Device(int deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}");
            Console.WriteLine($"Status: {Status}");
        }
    }

  
    class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }

        public Thermostat(int deviceId, string status, double temperatureSetting)
            : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine("\n--- Thermostat Status ---");
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
        }
    }
}
