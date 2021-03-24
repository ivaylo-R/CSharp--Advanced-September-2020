using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Matching_Brackets
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString()=="(")
                {
                    stack.Push(i);
                }
                else if (text[i].ToString()==")")
                {
                    var startIndex = stack.Pop();
                    Console.WriteLine(text.Substring(startIndex,i-startIndex+1));
                }
            }
            
        }
    }
}
