using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Set_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            
            for (int i = 0; i < n; i++)
            {
                var currentElement = int.Parse(Console.ReadLine());
                first.Add(currentElement);
            }

            for (int i = 0; i < m; i++)
            {
                var num = int.Parse(Console.ReadLine());
                second.Add(num);
            }

            Console.WriteLine(String.Join(" ", first.Intersect(second)));
        }
    }
}
