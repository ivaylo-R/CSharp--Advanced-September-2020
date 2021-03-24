using System;
using System.Collections.Generic;

namespace _07_Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] childrens = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());
            var circle = new Queue<string>(childrens);
            while (circle.Count>1)
            {
                for (int i = 1; i < count; i++)
                {
                    circle.Enqueue(circle.Dequeue());
                }
                Console.WriteLine($"Removed {circle.Dequeue()}");
            }
            Console.WriteLine($"Last is {circle.Peek()}");
        }
    }
}
