using System;
using System.Linq;

namespace Stack2
{
    public class Program
    {
        public static void Main()
        {
            CustomStack<int> stack = new CustomStack<int>();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0]=="END")
                {
                    break;
                }
                if (cmd[0] == "Push")
                {
                    var elements = cmd.Skip(1).Select(int.Parse).ToList();
                    stack.Push(elements);
                }
                else
                {
                    try
                    {
                    stack.Pop();

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }

            for (int r = 0; r < 2; r++)
            {
                foreach (var e in stack)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
