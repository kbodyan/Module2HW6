using System.Collections.Generic;
using TaxiStation.Models.Helpers.Abstraction;

namespace TaxiStation.Models.Helpers
{
    public class CarComparerByFuelConsumption : IComparer<Car>, ICarComparerByFuelConsumption
    {
        public int Compare(Car x, Car y)
        {
            return x.GetFuelConsumption().CompareTo(y.GetFuelConsumption());
        }
    }
}
