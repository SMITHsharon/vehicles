namespace Vehicles 
{
    public interface IVehicle
    {
        string Name { get; set; }
        int Wheels { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();
    }

    
    

    

    
}
