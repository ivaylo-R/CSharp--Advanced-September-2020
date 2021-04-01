using System;
using System.Collections.Generic;
using System.Linq;

namespace balancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] parenthesis = new char[] { '(', '[', '{' };
            Stack<char> stack = new Stack<char>();
            char[] input =Console.ReadLine().ToCharArray();
            bool isValid = true;
            foreach (var item in input)
            {
                if (parenthesis.Contains(item))
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                else if (stack.Peek()== '(' && item == ')')
                {
                    stack.Pop();
                    continue;
                }
                else if (stack.Peek()=='[' && item== ']')
                {
                    stack.Pop();
                    continue;
                }
                else if (stack.Peek()=='{'&& item=='}')
                {
                    stack.Pop();
                    continue;
                }
                else
                {
                    isValid = false;
                    break;
                }
                
            }

            if (isValid)
            {
                Console.WriteLine("YES");
                return;
            }
            Console.WriteLine("NO");
        }
    }
}

