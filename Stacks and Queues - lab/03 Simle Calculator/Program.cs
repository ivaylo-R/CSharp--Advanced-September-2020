using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Simle_Calculator
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(input.Reverse());
            int sum = 0;
            while (stack.Any())
            {
                string currentChar = stack.Pop();
                if (currentChar == "+")
                {
                    sum += int.Parse(stack.Pop());
                }
                else if (currentChar == "-")
                {
                    sum -= int.Parse(stack.Pop());
                }
                else
                {
                    sum += int.Parse(currentChar);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
