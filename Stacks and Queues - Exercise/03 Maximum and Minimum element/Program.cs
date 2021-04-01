using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Maximum_and_Minimum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            while (n != 0)
            {
                var line = Console.ReadLine().Split();
                if (line.Length == 2 && int.Parse(line[0]) == 1)
                {
                    int element = int.Parse(line[1]);
                    stack.Push(element);
                }
                else if (line[0] == "2")
                {
                    stack.Pop();
                }
                else if (line[0] == "3" && stack.Count != 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (line[0] == "4" && stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                }
                n--;
            }

            Console.WriteLine(String.Join(", ", stack));

        }
    }
}
