using System;
using System.Linq;

namespace Vehicles 
{
    public class Motorcycle : IGroundVehicle, IDrivable
    {
        public int Wheels => 2;
        public int Door {get; set; } => 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; } = 1.3;
        public double MaxSpeed { get; set; } = 160.4;

        public Motorcycle (string name, int passengerCapacity, string transmissionType, 
                           double engineVolume, double maxSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxSpeed = maxSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} motorcycle screams down the highway!");
        }

        public void Start()
        {
            Console.WriteLine("Born to be WiIiIiLd!");
        }

        public void Stop()
        {
            ConsoleWriteLine("Gee officer, no I don't know how fast I was going ...");
        }
    }
}