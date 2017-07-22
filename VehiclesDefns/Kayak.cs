using System;
using System.Linq;

namespace Vehicles 
{
    public class Kayak : WaterBased, IWaterBased, IVehicle
    
    {
        public int PassengerCapacity { get; set; }
        public double MaxWaterSpeed { get; set; } = 5;

        public Kayak (string name, int passengerCapacity)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} kayak is the most amazing of all for solitude and serenity in the wilderness!");
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