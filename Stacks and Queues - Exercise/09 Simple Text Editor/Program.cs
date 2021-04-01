using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var line =Console.ReadLine().Split();
                if (line[0] == "1")
                {
                    string someString = line[1];
                    stack.Push(sb.ToString());
                    sb.Append(someString);
                }
                else if (line[0] == "2")
                {
                    int count = int.Parse(line[1]);
                    stack.Push(sb.ToString());
                    sb.Remove(sb.Length - count, count);
                }
                else if (line[0] == "3")
                {
                    int index = int.Parse(line[1]);
                    if (index >= 0 && index <= sb.Length)
                    {
                        Console.WriteLine(sb[index - 1]);
                    }
                }
                else if (line[0]=="4")
                {
                    sb.Clear();
                    sb.Append(stack.Pop());
                }
            }
        }
    }
}
