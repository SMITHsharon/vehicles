using System;
using System.Linq;
// using System.Collections.Generic;

namespace Vehicles 
{
    // public class TrekBicycle : IVehicle
    public class SoccerMomVan : IGroundBased, IWheelsDoors
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 5;
        public int PassengerCapacity { get; set; } = 8;
        public double MaxLandSpeed { get; set; } = 95.0;

        public void Drive()
        {
            Console.WriteLine("This van hauls kids around!");
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