using System;
using System.Linq;

namespace Vehicles 
{
    public class Helicopter : IAirVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 3;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Fixed";
        public double EngineVolume { get; set; } = 20;
        // public double MaxLandSpeed { get; set; } = 0;
        public double MaxSpeed { get; set; } = 96;

        public Helicopter (string name, int doors, int passengerCapacity, 
                           string transmissionType, double engineVolume, 
                           double maxSpeed)
        {
            Name = name;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxSpeed = maxSpeed;
        }

        public void Fly()
        {
            Console.WriteLine($"Wheee! The {Name} helicopter is buzzing around!");
        }

        public void Lnd()
        {
            Console.WriteLine("Aren't you glad I didn't turn off the engine???");
        }

        public void Start()
        {
            Console.WriteLine($"Get to the {Name} Choppa!");
        }
    }
}