using System;
using System.Linq;

namespace Vehicles 
{
    public class Bicycle : GroundBased, IGroundBased, IVehicle
    {
        public int Wheels => 2;
        public int PassengerCapacity { get; set; }
        public double MaxLandSpeed { get; set; }

        public Bicycle(int passengerCapacity, int maxLandSpeed)
        {
            PassengerCapacity = passengerCapacity;
            MaxLandSpeed = maxLandSpeed;
        }

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