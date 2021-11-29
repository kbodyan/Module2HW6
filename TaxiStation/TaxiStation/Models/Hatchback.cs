using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public class Hatchback : Regular
    {
        public Hatchback()
        {
            CarType = CarType.Hatchback;
        }

        public double TrunkLength { get; set; }
    }
}
