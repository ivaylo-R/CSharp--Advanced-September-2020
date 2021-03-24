using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = new Queue<string>();
            while (true)
            {
                string line =Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                else if (line=="Paid")
                {
                    while (seq.Any())
                    {
                        Console.WriteLine(seq.Dequeue());
                    }
                    continue;
                }

                seq.Enqueue(line);
            }

            Console.WriteLine($"{seq.Count} people remaining.");
        }
    }
}
