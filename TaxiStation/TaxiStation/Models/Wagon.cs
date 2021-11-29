namespace TaxiStation.Models
{
    public abstract class Wagon : ICECar
    {
        public bool HasThirdRowSeats { get; set; }
        public double TrunkLength { get; set; }
    }
}
