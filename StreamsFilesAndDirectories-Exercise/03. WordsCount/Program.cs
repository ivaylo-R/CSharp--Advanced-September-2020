using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/StreamsAndFiles/03.WordsCount/words.txt");
            string[] text = File.ReadAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/StreamsAndFiles/03.WordsCount/text.txt")
                .Split(new string[] { "!", " ", "-", ",", "." }, StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i];
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j].ToLower() == word)
                    {
                        if (!dict.ContainsKey(word))
                        {
                            dict.Add(word, 0);
                        }

                        dict[word]++;
                    }
                }
            }

            string[] outpt = new string[lines.Length];
            int linesCount = 0;
            foreach (var item in dict)
            {
                var word = item.Key;
                var count = item.Value;
                outpt[linesCount] = $"{word} - {count}";
                linesCount++;
            }
            File.WriteAllLines(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/StreamsAndFiles/03.WordsCount/actualResult.txt",outpt);

            linesCount = 0;
            foreach (var item in dict.OrderByDescending(x=>x.Value))
            {
                var word = item.Key;
                var count = item.Value;
                outpt[linesCount] = $"{word} - {count}";
                linesCount++;
            }
            File.WriteAllLines(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/StreamsAndFiles/03.WordsCount/expectedResult.txt", outpt);
            
        }
    }
}
