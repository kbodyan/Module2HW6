namespace TaxiStation.Models.Helpers
{
    public static class Extentions
    {
        public static Car CheckCarByType(this Car car, CarType type)
        {
            if (car.CarType == type)
            {
                return car;
            }
            else
            {
                return null;
            }
        }
    }
}
