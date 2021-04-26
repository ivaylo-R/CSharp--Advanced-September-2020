using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class StartUp
    {
        static void Main()
        {
            List<int> data = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake stones = new Lake(data);

            Console.WriteLine(String.Join(", ", stones));
            

        }
    }
}
