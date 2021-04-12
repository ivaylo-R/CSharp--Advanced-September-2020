using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("word.txt"))
            {
                var line = new string[] { };
                while (true)
                {
                    var input = reader.ReadLine();
                    if (input == null)
                    {
                        break;
                    }
                    line = input.Split();
                }
                using (var textReader = new StreamReader("text.txt"))
                {
                    var dict = new Dictionary<string, int>();

                    using (var writer = new StreamWriter("outputText.txt"))
                    {
                        var text = textReader.ReadToEnd()
                            .Split(new char[] { ' ',',','.','-'}, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                        for (int i = 0; i < line.Length; i++)
                        {
                            var wordToCompare = line[i];
                            for (int z = 0; z < text.Length; z++)
                            {
                                
                                if (wordToCompare.ToLower()==text[z].ToString().ToLower())
                                {
                                    if (!dict.ContainsKey(wordToCompare))
                                    {
                                        dict.Add(wordToCompare, 0);
                                    }
                                    dict[wordToCompare]++;
                                }
                            }

                        }
                        dict = dict.OrderByDescending(x => x.Value).ToDictionary(y => y.Key, t => t.Value);
                        foreach (var word in dict)
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }

                    }
                }

            }
        }
    }
}
