using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                pumps.Enqueue(input);

            }
            int totalFuel = 0;
            for (int i = 0; i < n; i++)
            {
                string current = pumps.Dequeue();
                var info = current.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var petrol = info[0];
                var distance = info[1];
                totalFuel += petrol;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                pumps.Enqueue(current);
            }

            Console.WriteLine((pumps.Dequeue().Split().Select(int.Parse).ToArray())[2]);
        }
    }
}
