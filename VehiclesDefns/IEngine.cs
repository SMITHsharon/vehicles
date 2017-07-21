namespace Vehicles
{
    public interface IEngine
    {
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
    }
}