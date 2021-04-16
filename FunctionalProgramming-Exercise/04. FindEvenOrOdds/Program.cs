using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = tokens[0];
            int end = tokens[1];
            string evenOrOdd =Console.ReadLine();
            List<int> sequence = new List<int>();
            for (int i = start; i <= end; i++)
            {
                sequence.Add(i);
            }
            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;
            Action<List<int>> printResult = num => Console.WriteLine(String.Join(" ",num));
            if (evenOrOdd == "odd")
            {
                sequence = sequence.Where(x => isOdd(x)).ToList();
            }
            else
            {
                sequence = sequence.Where(x => isEven(x)).ToList();
            }

            printResult(sequence);
        }
    }
}
