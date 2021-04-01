using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elementsToEnqueue = seq[0];
            var elementsToDequeue = seq[1];
            var number = seq[2];
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            for (int i = 0; i < elementsToEnqueue; i++)
            {
                queue.Enqueue(nums[i]);
            }
            for (int i = 0; i < elementsToDequeue; i++)
            {
                queue.Dequeue();
            }
            if (!queue.Any())
            {
                Console.WriteLine("0");
                return;
            }
            if (queue.Contains(number))
            {
                Console.WriteLine("true");
                return;
            }
            else if (!queue.Contains(number))
            {
                int min = int.MaxValue;
                foreach (var num in queue)
                {
                    if (num<min)
                    {
                        min = num;
                    }
                }
                Console.WriteLine(min);
                return;
            }
            

        }
    }
}
