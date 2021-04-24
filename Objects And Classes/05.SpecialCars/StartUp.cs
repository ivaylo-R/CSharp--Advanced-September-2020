using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "No more tires")
                {
                    break;
                }
                var tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var currentTires = new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7]))

                };
                tires.Add(currentTires);
            }
            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Engines done")
                {
                    break;
                }
                var tokens = line.Split();

                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }
            List<Car> cars = new List<Car>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Show special")
                {
                    break;
                }
                var tokens = line.Split();
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);
                if (engineIndex >= 0 && engineIndex < engines.Count && tiresIndex >= 0 && tiresIndex < tires.Count)
                {
                    cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
                }
            }

            if (cars.Any())
            {
                foreach (var specialCar in cars.Where(x => x.Year >= 2017)
                    .Where(x => x.Engine.HorsePower >= 330)
                    .Where(x => x.Tires.Sum(x => x.Pressure) >= 9).Where(x => x.Tires.Sum(x => x.Pressure) <= 10)
                    )
                {
                    specialCar.Drive(20);
                    Console.WriteLine(specialCar.WhoAmI());
                }
            }
        }
    }
}
