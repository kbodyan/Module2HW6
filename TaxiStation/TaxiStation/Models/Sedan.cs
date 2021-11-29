using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public class Sedan : Regular
    {
        public Sedan()
        {
            CarType = CarType.Sedan;
        }
    }
}
