using System;
using System.Collections.Generic;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Revision")
                {
                    break;
                }

                var tokens = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }

            }

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
