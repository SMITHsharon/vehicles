using System;
using System.Linq;

namespace Vehicles 
{
    public class JetSki : IWaterVehicle, IDrivableVehicle
    
    {
        public int Wheels {get; set; } = 0;
        public int Doors {get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "Variable";
        public double EngineVolume { get; set; } = 3.1;
        public double MaxSpeed { get; set; } = 42;

        public JetSki (string name, int passengerCapacity, 
                       double engineVolume, int maxSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxSpeed = maxSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} jetski zips through the waves with the greatest of ease!");
        }

        public void Start()
        {
            Console.WriteLine("Hey y'all watch this.");
        }

        public void Stop()
        {
            Console.WriteLine("Beer Me!");
        }
    }
}