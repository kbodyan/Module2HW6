using TaxiStation.Models;
using TaxiStation.Models.Helpers;

namespace TaxiStation.Services.Abstractions
{
    public interface ITaxiStationService
    {
        Car[] FindCarsByType(Car[] station, CarType carType);
        double ReturnTaxiStationResidualValue(Car[] station);
        void SortTaxyByFuelConsumption(ref Car[] station);
    }
}