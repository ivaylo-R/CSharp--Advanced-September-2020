using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._StreamsFilesAndDirectories_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tokens = new char[] { '-', ',', '.', '!', '?' };
            using (var reader = new StreamReader(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\StreamsAndFiles\01. Even Lines\Text.txt"))
            {
                using (var wrter = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\StreamsAndFiles\01. Even Lines\output.txt"))
                {
                    var count = 0;
                    while (true)
                    {
                        var input = reader.ReadLine();

                        if (input == null)
                        {
                            break;
                        }

                        if (count % 2 == 0)
                        {
                            var line = input.Split().ToList();
                            var outputLine = new List<string>();
                            for (int i = line.Count-1; i >=0; i--)
                            {
                                var currentElement = line[i];
                                string newElement = CheckIfToken(tokens, currentElement);
                                if (!newElement.Equals(currentElement))
                                {
                                    outputLine.Add(newElement);
                                }
                                else
                                {
                                    outputLine.Add(currentElement);
                                }
                            }

                            wrter.Write(string.Join(" ", outputLine));
                            wrter.WriteLine();
                        }
                        count++;
                    }

                }
            }
        }

        private static string CheckIfToken(char[] tokens, string currentElement)
        {
            for (int k = 0; k < tokens.Length; k++)
            {
                if (currentElement.Contains(tokens[k]))
                {
                    var currSymbolReplaced= currentElement.Replace(tokens[k], '@');
                    if (currSymbolReplaced.Contains(',')||
                        currSymbolReplaced.Contains('-')||
                        currSymbolReplaced.Contains('?')||
                        currSymbolReplaced.Contains('.')||
                            currSymbolReplaced.Contains('!'))
                    {
                        var newString=CheckIfToken(tokens, currSymbolReplaced);
                        return newString;
                    }
                    return currSymbolReplaced;
                }
            }
            return currentElement;
        }
    }
}
