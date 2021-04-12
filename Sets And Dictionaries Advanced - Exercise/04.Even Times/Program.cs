using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var seq = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (!seq.ContainsKey(currentNum))
                {
                    seq.Add(currentNum, 0);
                }
                seq[currentNum]++;
            }
            foreach (var num in seq.Where(x=>x.Value%2==0))
            {
                Console.WriteLine(num.Key);
            }
        }
    }
}
