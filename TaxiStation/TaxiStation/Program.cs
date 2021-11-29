using System;
using Microsoft.Extensions.DependencyInjection;

namespace TaxiStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICreateParkService, CreateParkService>()
                .AddTransient<ICreateSectionService, CreateSectionService>()
                .AddTransient<INumberOfKindsInSectionService, NumberOfKindsInSectionService>()
                .AddTransient<ISortByWeightService, SortByWeightService>()
                .AddTransient<IFindAnimalByKindService, FindAnimalByKindService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
