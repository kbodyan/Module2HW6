namespace TaxiStation.Models
{
    public abstract class ICECar : Car
    {
        public double EngineVolume { get; set; }
        public double FuelConsumption { get; set; }
        public bool HasGas { get; set; }
    }
}
