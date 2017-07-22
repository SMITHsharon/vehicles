using System;
using System.Linq;

namespace Vehicles 
{
    public class JetSki : WaterBased, IEngine, IWaterBased, IVehicle
    
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

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}