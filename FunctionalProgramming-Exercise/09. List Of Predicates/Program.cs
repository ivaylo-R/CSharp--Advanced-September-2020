using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var seq = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Func<int, int, bool> isDivisible = (x, y) => x % y == 0;
            List<int> result = new List<int>();
            Action<List<int>> printer = z => Console.WriteLine(String.Join(" ",z));
            for (int i = 1; i <= n; i++)
            {
                bool divisible = false;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (isDivisible(i, seq[j]))
                    {
                        divisible = true;
                        continue;
                    }
                    else
                    {
                        divisible = false;
                        break;
                    }
                }
                if (divisible)
                {
                    result.Add(i);
                }
            }
            printer(result);

        }


    }
}
