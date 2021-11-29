using TaxiStation.Models;
using TaxiStation.Services.Abstractions;

namespace TaxiStation.Services
{
    public class CreateTaxyStationService : ICreateTaxyStationService
    {
        public Car[] CreateTaxyStation(Car[] list, int size)
        {
            Car[] station;
            if (size > list.Length)
            {
                station = new Car[list.Length];
            }
            else
            {
                station = new Car[size];
            }

            for (var i = 0; i < station.Length && i < list.Length; i++)
            {
                station[i] = list[i];
            }

            return station;
        }
    }
}
