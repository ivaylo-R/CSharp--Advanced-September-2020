using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int racks = 1;
            int sum = 0;
            while (stack.Any())
            {
                if (sum+stack.Peek()<=capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
