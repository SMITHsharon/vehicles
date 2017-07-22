namespace Vehicles
{
    public interface IGroundBased 
    { 
        double MaxLandSpeed { get; set; }
        void Drive();
    }
}