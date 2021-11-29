using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using TaxiStation.Models.Helpers;
using TaxiStation.Services.Abstractions;

namespace TaxiStation
{
    public class Starter
    {
        private const int _sizeOfStation = 7;
        private const CarType _carTypeForSearch = CarType.Sedan;
        private ICreateListOfCarsService _createListOfCarsService;
        public Starter(ICreateListOfCarsService createListOfCars)
        {
            _createListOfCarsService = createListOfCars;
        }

        public void Start(ServiceProvider serviceProvider)
        {
            var listOfCars = _createListOfCarsService.CreateListOfCars();
            var application = serviceProvider.GetService<Application>();
            application.Run(listOfCars, _sizeOfStation, _carTypeForSearch);
        }
    }
}
