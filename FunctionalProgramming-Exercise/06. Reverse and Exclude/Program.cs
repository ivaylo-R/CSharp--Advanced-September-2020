using System;
using System.Linq;

namespace _06._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collection = Console.ReadLine().Split().Select(x => int.Parse(x)).Reverse().ToArray();
            int n = int.Parse(Console.ReadLine());
            Func<int, bool> isDivisible = x => x % n != 0;
            foreach (var item in collection)
            {
                if (isDivisible(item))
                {

                }
                Console.Write(item + " ");
            }
        }

        
    }
}
