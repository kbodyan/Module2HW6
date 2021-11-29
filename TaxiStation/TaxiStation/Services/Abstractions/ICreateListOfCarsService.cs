using TaxiStation.Models;

namespace TaxiStation.Services.Abstractions
{
    public interface ICreateListOfCarsService
    {
        Car[] CreateListOfCars();
    }
}