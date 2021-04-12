using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/StreamsAndFiles/02.Line Numbers/Text.txt");
            var output = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                
                var currentLine = lines[i];
                int countOfPunctuationMarks = FindCountOfPunctuationMarks(currentLine);
                int countOfletters = FindCountOfLetters(currentLine);
                output[i] = $"Line {i + 1}: {lines[i]} ({countOfletters})({countOfPunctuationMarks})";
            }

            File.WriteAllLines(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\StreamsAndFiles\02.Line Numbers\output.txt", output);
        }

        private static int FindCountOfLetters(string currentLine)
        {

            var matchLetters = new Regex(@"[A-Za-z]");
            MatchCollection matchesOfLetters = matchLetters.Matches(currentLine);
            return matchesOfLetters.Count;
        }

        private static int FindCountOfPunctuationMarks(string currentLine)
        {
            
            var match = new Regex(@"[-]|[,]|[.]|[!]|[']|[?]");
            MatchCollection matches = match.Matches(currentLine);
            return matches.Count;
        }
    }
}
