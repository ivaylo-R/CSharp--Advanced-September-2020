using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input);
            var output = new List<int>();
            while (queue.Any())
            {
                var currElement = queue.Dequeue();
                if (currElement % 2 == 0)
                {
                    output.Add(currElement);
                }
            }
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
