using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new Dictionary<string, Dictionary<string, double>>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                string extension = files[i].Extension;
                string file = files[i].Name;
                double fileCapacity = files[i].Length;
                if (!fileInfo.ContainsKey(extension))
                {
                    fileInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!fileInfo[extension].ContainsKey(file))
                {
                    fileInfo[extension].Add(file, fileCapacity / 1024);
                }
            }

            using (var writer = new StreamWriter($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/StreamsAndFiles/05.DirectoryTraversal/report.txt"))
            {
                foreach (var kvp in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine($"{kvp.Key}");
                    foreach (var file in kvp.Value)
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value}kb");
                    }
                }
            }
            


        }
    }
}
