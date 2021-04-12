using System;
using System.Collections.Generic;
namespace _06.Wardrobe
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            ReadInput(count, wardrobe);
            CheckIfItemExist(wardrobe);
        }

        private static void CheckIfItemExist(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            var colorItemPair = Console.ReadLine().Split();
            var color = colorItemPair[0];
            var item = colorItemPair[1];
            if (wardrobe.ContainsKey(color))
            {
                if (wardrobe[color].ContainsKey(item))
                {
                    PrintResultAndFoundSearchedItem(wardrobe,color,item);
                }
            }
            else
            {
                PrintResult(wardrobe);
            }
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
            return;
        }

        private static void PrintResultAndFoundSearchedItem(Dictionary<string, Dictionary<string, int>> wardrobe, string searchdColor, string searchedItem)
        {
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {
                    if (kvp.Key == searchdColor && searchedItem == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }

        private static void ReadInput(int count, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < count; i++)
            {
                var colorItemsPair = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var color = colorItemsPair[0];
                var items = colorItemsPair[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < items.Length; j++)
                {
                    var currentItem = items[j];
                    if (!wardrobe[color].ContainsKey(currentItem))
                    {
                        wardrobe[color].Add(currentItem, 0);
                    }
                    wardrobe[color][currentItem]++;
                }
            }
        }
    }
}
