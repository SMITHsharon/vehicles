using System;
using System.Linq;
// using System.Collections.Generic;

namespace Vehicles 
{
    // public class TrekBicycle : IVehicle
    public class TrekBicycle : IGroundBased, IWheelsDoors
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public double MaxLandSpeed { get; set; } = 45.0;

        public void Drive()
        {
            Console.WriteLine("This bicycle flies up those mountains!");
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