namespace Vehicles 
{
    public interface IVehicle
    {
        string Name { get; set; }
        int PassengerCapacity { get; set; }
        void Start();
        void Stop();
    }
}