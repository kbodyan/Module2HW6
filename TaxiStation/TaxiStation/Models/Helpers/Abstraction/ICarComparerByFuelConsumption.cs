namespace TaxiStation.Models.Helpers.Abstraction
{
    public interface ICarComparerByFuelConsumption
    {
        int Compare(Car x, Car y);
    }
}