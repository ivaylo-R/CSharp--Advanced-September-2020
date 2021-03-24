using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Stack_Sum
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            while (true)
            {
                string line = Console.ReadLine().ToLower();
                if (line == "end")
                {
                    break;
                }

                string[] lineSplitted = line.Split();
                if (lineSplitted.Length == 3)
                {
                    stack.Push(int.Parse(lineSplitted[1]));
                    stack.Push(int.Parse(lineSplitted[2]));
                }
                else if (lineSplitted.Length==2)
                {
                    int count = int.Parse(lineSplitted[1]);
                    if (stack.Any())
                    {
                        if (count<=stack.Count)
                        {
                            while (count!=0)
                            {
                                stack.Pop();
                                count--;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            PrintSumOfTheStack(stack);
        }

        private static void PrintSumOfTheStack(Stack<int> stack)
        {
            int sum = 0;
            foreach (var item in stack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
