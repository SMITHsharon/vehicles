using System;
using System.Linq;

namespace Vehicles 
{
    public class SoccerMomVan : GroundBased, IWheelsDoors, IEngine, IGroundBased, IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public double MaxLandSpeed { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }

        public SoccerMomVan (string name, int wheels, int doors, int passengerCapacity, 
                             double maxLandSpeed, string transmissionType, 
                             double engineVolume)
        {
            Name = name;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            MaxLandSpeed = maxLandSpeed;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
        }

        public void Drive()
        {
            Console.WriteLine($"This {Name} van hauls piles of kids around!");
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