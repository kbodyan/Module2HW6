using Microsoft.Extensions.DependencyInjection;
using TaxiStation.Models.Helpers;
using TaxiStation.Models.Helpers.Abstraction;
using TaxiStation.Services;
using TaxiStation.Services.Abstractions;

namespace TaxiStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICreateListOfCarsService, CreateListOfCarsService>()
                .AddTransient<ICreateTaxyStationService, CreateTaxyStationService>()
                .AddTransient<ITaxiStationService, TaxiStationService>()
                .AddTransient<ICarComparerByFuelConsumption, CarComparerByFuelConsumption>()
                .AddTransient<Starter>()
                .AddTransient<Application>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Start(serviceProvider);
        }
    }
}
