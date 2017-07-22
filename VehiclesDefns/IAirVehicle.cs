namespace Vehicles
{
    public interface IAirVehicle : IVehicle
    {
        double MaxSpeed { get; set; }
        bool Winged { get; set; }
        void Fly();
        void Land();
    }
}