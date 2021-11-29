using System;
using TaxiStation.Models;
using TaxiStation.Models.Helpers;
using TaxiStation.Models.Helpers.Abstraction;
using TaxiStation.Services.Abstractions;

namespace TaxiStation.Services
{
    public class TaxiStationService : ITaxiStationService
    {
        private ICarComparerByFuelConsumption _carComparerByFuelConsumption;
        public TaxiStationService(ICarComparerByFuelConsumption carComparerByFuelConsumption)
        {
            _carComparerByFuelConsumption = carComparerByFuelConsumption;
        }

        public double ReturnTaxiStationResidualValue(Car[] station)
        {
            var value = 0.0;
            foreach (var car in station)
            {
                value += car.ResidualValue;
            }

            return value;
        }

        public void SortTaxyByFuelConsumption(ref Car[] station)
        {
            Array.Sort<Car>(station, (System.Collections.Generic.IComparer<Car>)_carComparerByFuelConsumption);
        }

        public Car[] FindCarsByType(Car[] station, CarType carType)
        {
            var result = new Car[station.Length];
            var quantity = 0;
            foreach (var car in station)
            {
                if (car.CheckCarByType(carType) != null)
                {
                    result[quantity++] = car;
                }
            }

            if (quantity > 0)
            {
                Array.Resize<Car>(ref result, quantity);
                return result;
            }

            return null;
        }
    }
}
