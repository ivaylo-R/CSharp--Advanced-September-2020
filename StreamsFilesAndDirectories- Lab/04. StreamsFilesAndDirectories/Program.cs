using System;
using System.IO;

namespace _04._StreamsFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"Resources\01. Odd Lines\FirstProblem.txt"))
            {
                using (var writer = new StreamWriter(@"Resources\01. Odd Lines\Output.txt"))
                {
                    int n = 1;
                    while (true)
                    {
                        var line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (n % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        n++;
                    }

                }

            }
        }
    }
}
