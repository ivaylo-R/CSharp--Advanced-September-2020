using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Sets_And_Dictionaries_Advanced___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
