using System;
using System.IO;

namespace _05._SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int filesCount = 4;
            using (var fileStream = new FileStream(@"..\..\..\sliceMe.txt", FileMode.Open))
            {
                long size = fileStream.Length / filesCount;
                for (int i = 0; i < filesCount; i++)
                {
                    using (var pieceStream = new FileStream($"Part-{i+1}.txt", FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];
                        int count = 0;
                        while (count<=size)
                        {
                            fileStream.Read(buffer, 0, buffer.Length);
                            pieceStream.Write(buffer, 0, buffer.Length);
                            count+=buffer.Length;
                        }
                    }
                }
            }
        }
    }
}
