namespace Vehicles
{
    public interface IAirBased
    { 
        double MaxLandSpeed { get; set; }
        double MaxAirSpeed { get; set; }
        bool Winged { get; set; }
        void Drive();
        void Fly();
    }
}