using System;
using System.Collections.Generic;

namespace _07_Hot_potato_2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Remove {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
