using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            
            while (queue.Any())
            {
                int currentElement = queue.Peek();

                if (quantity < currentElement)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
                queue.Dequeue();
                quantity -= currentElement;
            }
            Console.WriteLine("Orders complete");


        }
    }
}
