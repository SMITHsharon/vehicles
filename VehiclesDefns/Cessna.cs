using System;
using System.Linq;

namespace Vehicles 
{
    public class Cessna : Vehicle, IEngine, IWheelsDoors, IAirBased, IVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public Cessna (string name, int passengerCapacity, double engineVolume, 
                       double maxLandSpeed, double maxAirSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxLandSpeed = maxLandSpeed;
            MaxAirSpeed = maxAirSpeed;
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} Cessna effortlessly glides through the clouds like a gleaming god of the Sun!");
        }

        public void Start()
        {
            Console.WriteLine("Cessna starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Cessna stopping...");
        }
    }
}