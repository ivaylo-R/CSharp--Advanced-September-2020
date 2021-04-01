using System;
using System.Linq;
using System.Collections.Generic;
namespace _12.Cups_And_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBotles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cups = new Queue<int>(inputCups);
            var bottles = new Stack<int>(inputBotles);
            int wastedLittersOfWater = 0;
            while (true)
            {
                if (!cups.Any())
                {
                    break;
                }
                if (!bottles.Any())
                {
                    break;
                }

                int currentCup = cups.Peek();
                int currentBottle = bottles.Peek();
                if (currentBottle >= currentCup)
                {
                    wastedLittersOfWater += currentBottle - currentCup;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    while (currentCup > 0)
                    {
                        if (bottles.Any())
                        {
                            currentCup -= bottles.Pop();

                        }
                        else
                        {
                            break;
                        }
                    }
                    wastedLittersOfWater += Math.Abs(currentCup);
                    cups.Dequeue();

                }
            }
            if (!cups.Any())
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
            }
        }
    }
}
