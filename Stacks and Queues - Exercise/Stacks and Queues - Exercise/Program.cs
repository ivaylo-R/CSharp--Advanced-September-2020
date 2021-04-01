using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int s = tokens[1];
            int x = tokens[2];
            
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(elements);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
                return;
            }
            else if (stack.Count!=0)
            {
                Console.WriteLine(stack.Min());
                return;
            }
            Console.WriteLine(0);
            
        }
    }
}
