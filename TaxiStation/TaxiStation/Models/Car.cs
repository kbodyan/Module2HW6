using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public abstract class Car
    {
        public int Id { get; set; }
        public CarType CarType { get; set; }
        public CarBrand CarBrand { get; set; }
        public int MyProperty { get; set; }
        public int ProductionYear { get; set; }
        public int Mileage { get; set; }
        public CarColor CarColor { get; set; }
        public int NumberOfSeats { get; set; }
        public double TrunkVolume { get; set; }
        public double PurchasePrice { get; set; }
        public double ResidualValue { get; set; }
    }


}
