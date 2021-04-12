using System;
using System.Collections.Generic;
namespace _03.Periodic_Table
{
    class Program
    {
        static void Main()
        {
            SortedSet<string> set = new SortedSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var seq = Console.ReadLine().Split();
                for (int k = 0; k < seq.Length; k++)
                {
                    set.Add(seq[k]);
                }
            }

            Console.WriteLine(String.Join(" ",set));
        }
    }
}
