﻿using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findSmallest = x => x.Min();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(findSmallest(array));
        }
    }
}
