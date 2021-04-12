using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader=new StreamReader(@"Input.txt"))
            {
                int count = 0;
                using (var writer = new StreamWriter(@".\..\..\..\LineNumbersOutput.txt"))
                {
                    while (true)
                    {
                        var lineOfText = reader.ReadLine();
                        if (lineOfText==null)
                        {
                            break;
                        }
                        count++;
                        writer.WriteLine($"{count}. {lineOfText}");
                    }
                }
            }
        }
    }
}
