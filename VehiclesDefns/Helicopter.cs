using System;
using System.Linq;

namespace Vehicles 
{
    public class Helicopter : Vehicle, IEngine, IWheelsDoors, IAirBased, IVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; }

        public Helicopter (string name, int doors, int passengerCapacity, 
                           string transmissionType, double engineVolume, 
                           double maxAirSpeed)
        {
            Name = name;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxAirSpeed = maxAirSpeed;
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} helicopter buzzes around with amazing agility!");
        }

        public void Start()
        {
            Console.WriteLine("Helicopter starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Helicopter stopping...");
        }
    }
}