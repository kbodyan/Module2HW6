using TaxiStation.Models;
using TaxiStation.Models.Helpers;
using TaxiStation.Services.Abstractions;

namespace TaxiStation.Services
{
    public class CreateListOfCarsService : ICreateListOfCarsService
    {
        public Car[] CreateListOfCars()
        {
            var list = new Car[]
            {
                new Sedan
                {
                    Id = 0, CarBrand = CarBrand.Honda, CarModel = CarModel.Accord, CarColor = CarColor.Black, EngineVolume = 2.4, FuelConsumption = 12,
                    Mileage = 1200000, ProductionYear = 2008, NumberOfSeats = 5, PurchasePrice = 30000, ResidualValue = 11000
                },
                new Minivan
                {
                    Id = 1, CarBrand = CarBrand.Honda, CarModel = CarModel.Odyssey, CarColor = CarColor.Black, EngineVolume = 3.5, FuelConsumption = 17,
                    Mileage = 70000, ProductionYear = 2017, NumberOfSeats = 8, PurchasePrice = 25000, ResidualValue = 21000, HasThirdRowSeats = true
                },
                new Hatchback
                {
                    Id = 3, CarBrand = CarBrand.Honda, CarModel = CarModel.Civic, CarColor = CarColor.Grey, EngineVolume = 1.8, FuelConsumption = 9,
                    Mileage = 110000, ProductionYear = 2014, NumberOfSeats = 5, PurchasePrice = 10000, ResidualValue = 9000
                },
                new ElectricCar
                {
                    Id = 4, CarBrand = CarBrand.Tesla, BatteryCapacity = 200000, EnginePower = 1000, NumberOfSeats = 5, Mileage = 30000, FullChargingTime = 8,
                    PurchasePrice = 70000, ResidualValue = 40000, CarColor = CarColor.White, ProductionYear = 2018
                },
                new Sedan
                {
                    Id = 5, CarBrand = CarBrand.Nissan, CarModel = CarModel.Primera, CarColor = CarColor.Black, EngineVolume = 1.8, FuelConsumption = 11,
                    Mileage = 60000, ProductionYear = 2004, NumberOfSeats = 5, PurchasePrice = 17000, ResidualValue = 5000
                },
                new Coupe
                {
                    Id = 6, CarBrand = CarBrand.Mersedes, CarModel = CarModel.S500, CarColor = CarColor.Red, EngineVolume = 2.5, FuelConsumption = 12,
                    Mileage = 75000, ProductionYear = 2054, NumberOfSeats = 2, PurchasePrice = 50000, ResidualValue = 35000, IsCabriolet = true
                },
                new SUV
                {
                    Id = 7, CarBrand = CarBrand.Honda, CarModel = CarModel.Pilot, CarColor = CarColor.Grey, EngineVolume = 3.5, FuelConsumption = 18,
                    Mileage = 55000, ProductionYear = 2018, NumberOfSeats = 7, PurchasePrice = 30000, ResidualValue = 27000, GroundClearance = 25
                }
            };
            return list;
        }
    }
}
