using System;
using System.Linq;

namespace Vehicles 
{
    public class Helicopter : AirBased, IEngine, IWheelsDoors, IAirBased, IVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; }

        public Helicopter (int doors, int passengerCapacity, string transmissionType, 
                           double engineVolume, double maxAirSpeed)
        {
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxAirSpeed = maxAirSpeed;
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The helicopter buzzes around with amazing agility!");
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