using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(input);
            while (queue.Any())
            {
                string command =Console.ReadLine();
                string[] line = command.Split();
                if (line[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if (line[0] == "Add")
                {

                    var commandSplitted = command.Split("Add ").ToArray();
                    var song = commandSplitted[1];
                    
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (line[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ",queue));
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
