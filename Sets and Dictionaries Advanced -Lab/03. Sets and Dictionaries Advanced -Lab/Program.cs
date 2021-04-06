using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Sets_and_Dictionaries_Advanced__Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var dict = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 1);
                }
                else
                {
                    dict[input[i]]++;
                }
            }

            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
