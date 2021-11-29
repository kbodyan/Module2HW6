using TaxiStation.Models;

namespace TaxiStation.Services.Abstractions
{
    public interface ICreateTaxyStationService
    {
        Car[] CreateTaxyStation(Car[] list, int size);
    }
}