using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V__Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Statistics")
                {
                    break;
                }
                else if (line.Contains("joined"))
                {
                    var lineSplitted = line.Split();
                    var vlogger = lineSplitted[0];
                    if (!data.ContainsKey(vlogger))
                    {
                        data.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                        data[vlogger].Add("followers", new SortedSet<string>());
                        data[vlogger].Add("following", new SortedSet<string>());
                    }
                }
                else
                {
                    var lineSplitted = line.Split();
                    var firstVlogger = lineSplitted[0];
                    var scndVlogger = lineSplitted[2];
                    if (data.ContainsKey(firstVlogger)&&data.ContainsKey(scndVlogger)&&!firstVlogger.Equals(scndVlogger))
                    {
                        data[scndVlogger]["followers"].Add(firstVlogger);
                        data[firstVlogger]["following"].Add(scndVlogger);
                    }
                }
            }
            PrintResult(data);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, SortedSet<string>>> data)
        {
            Console.WriteLine($"The V-Logger has a total of {data.Keys.Count} vloggers in its logs.");
            data = data.OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(x => x.Key, y => y.Value);
            var famous = data.Take(1).ToDictionary(x=>x.Key,u=>u.Value);
            var vloggersLast = data.TakeLast(data.Count - 1).ToDictionary(x=>x.Key,u=>u.Value);

            foreach (var vlogger in famous)
            {
                Console.WriteLine($"1. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                foreach (var follower in vlogger.Value["followers"])
                {
                    Console.WriteLine($"*  {follower}");
                }
            }

            int n = 2;
            foreach (var vlogger in vloggersLast)
            {
                Console.WriteLine($"{n}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                n++;
            }
        }
    }
}
