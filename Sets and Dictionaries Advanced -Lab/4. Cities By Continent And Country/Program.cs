using System;
using System.Collections.Generic;

namespace _4._Cities_By_Continent_And_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var continent = line[0];
                var country = line[1];
                var city = line[2];
                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }
                dict[continent][country].Add(city);
            }


            foreach (var kvp in dict)
            {
                var continent = kvp.Key;
                Console.WriteLine($"{continent}:");
                foreach (var item in kvp.Value)
                {
                    var country = item.Key;
                    var city = item.Value;
                    Console.Write($"{country} -> {String.Join(", ", city)}");
                    Console.WriteLine();
                }

            }
        }
    }
}
