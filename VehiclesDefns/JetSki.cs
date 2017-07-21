using System;
using System.Linq;
// using System.Collections.Generic;

namespace Vehicles 
{
    // public class JetSki : IVehicle
    public class JetSki : IWaterBased, IEngine
    {
        // public int Wheels { get; set; } // DOES NOT APPLY
        // public int Doors { get; set; } // DOES NOT APPLY
        public int PassengerCapacity { get; set; } = 3; // IVehicle
        // public bool Winged { get; set; } // DOES NOT APPLY
        public string TransmissionType { get; set; } = "Automatic"; // IVehicle
        public double EngineVolume { get; set; } = 1498.0; // IVehicle
        public double MaxWaterSpeed { get; set; } = 50.0; // IWaterBased
        // public double MaxLandSpeed { get; set; } // DOES NOT APPLY
        // public double MaxAirSpeed { get; set; } // DOES NOT APPLY

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