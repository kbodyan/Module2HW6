using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public class Coupe : ICECar
    {
        public Coupe()
        {
            CarType = CarType.Coupe;
        }

        public bool HasSecondRowSeats { get; set; }
        public bool IsCabriolet { get; set; }
    }
}
