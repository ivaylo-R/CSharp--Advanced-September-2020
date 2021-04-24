using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tiresOfCar = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(2,3.2),
                new Tire(1 ,2.6),
                new Tire(1,2.5)
            };
            Car newCar = new Car();
            newCar.Tires = tiresOfCar;
            newCar.Engine = new Engine(139, 2000);

        }
    }
}
