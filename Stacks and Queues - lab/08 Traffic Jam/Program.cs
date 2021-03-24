using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int carsPassed = 0;
            while (true)
            {
                string line =Console.ReadLine();
                if (line == "end")
                {
                    Console.WriteLine($"{carsPassed} cars passed the crossroads.");
                    break;
                }
                else if (line == "green")
                {
                    if (count>queue.Count)
                    {
                        while (queue.Any())
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carsPassed++;
                        }
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                   
                    
                }
                else
                {
                    queue.Enqueue(line);
                }
               
            } 
        }
    }
}
