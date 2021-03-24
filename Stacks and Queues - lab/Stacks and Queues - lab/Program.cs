using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___lab
{
    class Program
    {
        static void Main()
        {
            string input =Console.ReadLine();
            Stack<char> stack = new Stack<char>(input);
            while (stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
