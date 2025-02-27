﻿using System;

namespace CarManufacturer
{
    public class Car
    {
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make,string model,int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make,string model,int year, double fuelQuantity,double fuelConsumption):this(make, model ,year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            double totalConsumption = distance * this.FuelConsumption;
            double result = this.FuelQuantity - (totalConsumption);
            if (result > 0)
            {
                this.FuelQuantity -= totalConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}
