using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public abstract class Car
    {
        public int Id { get; init; }
        public CarType CarType { get; init; }
        public CarBrand CarBrand { get; set; }
        public CarModel CarModel { get; set; }
        public int ProductionYear { get; set; }
        public int Mileage { get; set; }
        public CarColor CarColor { get; set; }
        public int NumberOfSeats { get; set; }
        public double TrunkVolume { get; set; }
        public double PurchasePrice { get; set; }
        public double ResidualValue { get; set; }
        public abstract double GetFuelConsumption();
    }
}
