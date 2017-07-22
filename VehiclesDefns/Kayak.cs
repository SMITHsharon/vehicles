using System;
using System.Linq;

namespace Vehicles 
{
    public class Kayak : Vehicle, IWaterBased, IVehicle
    
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

        public void Start()
        {
            Console.WriteLine("Kayak starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Kayak stopping...");
        }
    }
}