namespace Vehicles
{
    public interface IGroundVehicle : IVehicle
    {
        double MaxSpeed { get; set; }
    }
}