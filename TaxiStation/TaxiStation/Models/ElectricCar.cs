using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public class ElectricCar : Car
    {
        public ElectricCar()
        {
            CarType = CarType.Electric;
        }

        public int EnginePower { get; set; }
        public int BatteryCapacity { get; set; }
        public double FullChargingTime { get; set; }

        public override double GetFuelConsumption()
        {
            return 0;
        }
    }
}
