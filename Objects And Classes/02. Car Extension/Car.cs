using System;

namespace CarManufacturer
{
    public class Car
    {
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }


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
