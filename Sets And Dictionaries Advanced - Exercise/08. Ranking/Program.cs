
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestPasswordPair = ReadInput();
            var data = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }
                var tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                var contest = tokens[0];
                var password = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contestPasswordPair.ContainsKey(contest)
                    && contestPasswordPair[contest] == password)
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string, int>());
                        data[name][contest] = points;
                    }
                    else
                    {
                        if (!data[name].ContainsKey(contest))
                        {
                            data[name].Add(contest, 0);
                        }
                        if (data[name][contest] < points)
                        {
                            data[name][contest] = points;
                        }
                    }
                }
            }
            PrintResult(data);
        }

        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> data)
        {
            var bestCandidate = string.Empty;
            var maxPoints = 0;
            foreach (var user in data)
            {
                int currPoints = 0;
                foreach (var contest in user.Value)
                {
                    currPoints += contest.Value;
                }
                if (maxPoints<currPoints)
                {
                    maxPoints = currPoints;
                    bestCandidate = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in data)
            {
                Console.WriteLine($"{user.Key}");
                foreach (var item in user.Value.OrderByDescending(i=>i.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }

        private static Dictionary<string, string> ReadInput()
        {
            var data = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end of contests")
                {
                    break;
                }
                var tokens = line.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var contest = tokens[0];
                var password = tokens[1];
                if (!data.ContainsKey(contest))
                {
                    data.Add(contest, password);
                }
            }
            return data;
        }
    }
}