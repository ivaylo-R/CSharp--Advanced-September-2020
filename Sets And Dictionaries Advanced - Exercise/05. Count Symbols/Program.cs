using System;
using System.Collections.Generic;
namespace _05._Count_Symbols
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var occurrences = new SortedDictionary<char, int>();
            for (int symbol = 0; symbol < text.Length; symbol++)
            {
                var currChar = text[symbol];
                if (!occurrences.ContainsKey(currChar))
                {
                    occurrences.Add(currChar, 0);
                }
                occurrences[currChar]+=1;
            }

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
