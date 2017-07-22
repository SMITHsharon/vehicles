using System;
using System.Linq;

namespace Vehicles 
{
    public class JetSki : Vehicle, IEngine, IWaterBased, IVehicle
    
    {
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public JetSki (string name, int passengerCapacity, 
                       double engineVolume, int maxWaterSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxWaterSpeed = maxWaterSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} jetski zips through the waves with the greatest of ease!");
        }

        public void Start()
        {
            Console.WriteLine("JetSki starting...");
        }

        public void Stop()
        {
            Console.WriteLine("JetSki stopping...");
        }
    }
}