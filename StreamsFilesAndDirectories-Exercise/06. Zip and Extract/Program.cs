using System;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\StreamsAndFiles",
                @$"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\newFile.zip");
        }
    }
}
