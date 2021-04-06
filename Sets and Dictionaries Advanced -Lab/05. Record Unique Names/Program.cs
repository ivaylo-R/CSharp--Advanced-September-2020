using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
