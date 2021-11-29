using TaxiStation.Models.Helpers;

namespace TaxiStation.Models
{
    public class SUV : ICECar
    {
        public SUV()
        {
            CarType = CarType.SUV;
        }

        public double GroundClearance { get; set; }
    }
}
