using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

       
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }

        public double Drive(int distance)
        {
            double neededFuel = this.FuelConsumption * distance / 100;
            if (this.FuelQuantity >= neededFuel)
            {
                this.FuelQuantity -= neededFuel;
            }
            return this.FuelQuantity;
        }

        public string WhoAmI()
        {
            var specialCar = new StringBuilder();
            specialCar.AppendLine($"Make: {this.Make}");
            specialCar.AppendLine($"Model: {this.Model}");
            specialCar.AppendLine($"Year: {this.Year}");
            specialCar.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            specialCar.AppendLine($"FuelQuantity: {this.FuelQuantity}");
            return specialCar.ToString();
        }

        
    }
}
