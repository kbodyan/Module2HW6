using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public class Minivan : Wagon
    {
        public Minivan()
        {
            CarType = CarType.Minivan;
        }

        public double CabinVolume { get; set; }
    }
}
