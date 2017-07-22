namespace Vehicles
{
    public interface IWaterBased
    {
        double MaxWaterSpeed { get; set; }
        void Drive();
    }
}