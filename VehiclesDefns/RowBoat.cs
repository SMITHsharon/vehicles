using System;
using System.Linq;

namespace Vehicles 
{
    public class RowBoat : IWaterVehicle
    
    {
        public double MaxSpeed { get; set; } = 1;
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Arms";
        public double EngineVolume { get; set; } = 2;

        public RowBoat (string name, int passengerCapacity)
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
            Console.WriteLine("RowRow Row Your Boat");
        }
    }
}