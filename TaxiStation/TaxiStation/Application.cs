using TaxiStation.Models;
using TaxiStation.Models.Helpers;
using TaxiStation.Services.Abstractions;

namespace TaxiStation
{
    public class Application
    {
        private ICreateTaxyStationService _createTaxyStationService;
        private ITaxiStationService _taxiStationService;

        public Application(ICreateTaxyStationService createTaxyStationService, ITaxiStationService taxiStationService)
        {
            _createTaxyStationService = createTaxyStationService;
            _taxiStationService = taxiStationService;
        }

        public void Run(Car[] listOfCars, int sizeOfStation, CarType carTypeForSearch)
        {
            var station = _createTaxyStationService.CreateTaxyStation(listOfCars, sizeOfStation);
            var taxyStationResidualValue = _taxiStationService.ReturnTaxiStationResidualValue(station);
            _taxiStationService.SortTaxyByFuelConsumption(ref station);
            var carsByTypeInTaxiStation = _taxiStationService.FindCarsByType(station, carTypeForSearch);
        }
    }
}
