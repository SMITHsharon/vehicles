using System;
using System.Linq;

namespace Vehicles 
{
    public class HangGlider : Vehicle, IEngine, IAirBased, IVehicle
    {
        public int PassengerCapacity { get; set; } = 1;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; } = 0.0;
        public double MaxAirSpeed { get; set; }

        public HangGlider (string name, int passengerCapacity, double engineVolume, double maxAirSpeed)
        {
            Name = name; 
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxAirSpeed = maxAirSpeed;
        }

        public void Fly()
        {
            Console.WriteLine($"This {Name} hang glider effortlessly glides through the air like a bird ~~");
        }

        public void Start()
        {
            Console.WriteLine("Hang glider starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Hang glider stopping...");
        }
    }
}