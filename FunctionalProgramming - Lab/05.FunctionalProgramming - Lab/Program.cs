using System;
using System.Linq;

namespace _05.FunctionalProgramming___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(ParseNumber).ToArray();
            PrintResult(line, FindCount, FindSum);
            
        }

        private static int FindSum(int [] array)
        {
            return array.Sum();
        }

        private static int FindCount(int[] line)
        {
            return line.Length;
        }

        private static void PrintResult(int [] array,Func<int[],int> count,Func<int[],int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        private static int ParseNumber(string num)
        {
            return int.Parse(num);
        }
    }
}
