using System;
using System.Linq;

namespace Vehicles 
{
    public class Bicycle : Vehicle, IGroundBased, IVehicle
    {
        public int Wheels => 2;
        public int PassengerCapacity { get; set; }
        public double MaxLandSpeed { get; set; }

        public Bicycle (string name, int passengerCapacity, int maxLandSpeed)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            MaxLandSpeed = maxLandSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"This {Name} bicycle flies up those mountains!");
        }

        public void Start()
        {
            Console.WriteLine("Bicycle starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle stopping...");
        }
    }
}