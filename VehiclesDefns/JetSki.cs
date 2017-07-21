using System;
using System.Linq;

namespace Vehicles 
{
    public class JetSki : IWaterBased, IEngine
    {
        public int PassengerCapacity { get; set; } = 3;
        public string TransmissionType { get; set; } = "Automatic"; // IVehicle
        public double EngineVolume { get; set; } = 1498.0; // IVehicle
        public double MaxWaterSpeed { get; set; } = 50.0; // IWaterBased

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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