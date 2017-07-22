using System;
using System.Linq;

namespace Vehicles 
{
    public class Motorcycle : Vehicle, IEngine, IGroundBased, IVehicle
    {
        public int Wheels => 2;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public Motorcycle (string name, int passengerCapacity, string transmissionType, 
                           double engineVolume, double maxLandSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxLandSpeed = maxLandSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} motorcycle screams down the highway!");
        }

        public void Start()
        {
            Console.WriteLine("Motorcycle starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle stopping...");
        }
    }
}