using System;
using System.Linq;

namespace Vehicles 
{
    public class Cessna : AirBased, IEngine, IWheelsDoors, IAirBased, IVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        // public double MaxLandSpeed { get; set; }
        public double MaxSpeed { get; set; } = 309.0;

        public Cessna (string name, int passengerCapacity, double engineVolume, 
                       double maxSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            // MaxLandSpeed = maxLandSpeed;
            MaxAirSpeed = maxAirSpeed;
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} Cessna effortlessly glides through the clouds like a gleaming god of the Sun!");
        }

        public void Start()
        {
            Console.WriteLine("Clear!");
        }

        public void Land()
        {
            Console.WriteLine("Bump....Bump...Bump..Bump.Bump.Skid");
        }
    }
}