using System;
using System.Linq;

namespace _01._SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .Where(Even)
                .OrderBy(x=>x)
                .ToArray();
            Console.WriteLine(String.Join(", ", input));
        }


        private static bool Even(int arg)
        {
            return arg % 2 == 0;
        }

        static int Parse(string num)
        {
            return int.Parse(num);
        }

    }
}
