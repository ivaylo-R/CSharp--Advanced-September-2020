
using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Make = "VW";
            newCar.Model = "MK3";
            newCar.Year = 1992;
            newCar.FuelQuantity = 200;
            newCar.FuelConsumption = 12;
            newCar.Drive(10);
            Console.WriteLine(newCar.WhoAmI());
        }
    }
}
