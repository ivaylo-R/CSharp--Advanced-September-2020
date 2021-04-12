using System;
using System.IO;

namespace _06.Folder_Size___with_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();
            Console.WriteLine(GetDirectorySize(directoryPath));
        }

        private static double GetDirectorySize(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;

            string[] directories = Directory.GetDirectories(directoryPath);

            for (int i = 0; i < directories.Length; i++)
            {
                sum += GetDirectorySize(directories[i]);
            }
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{info.FullName} => {info.Length} bytes");
                sum += info.Length;
            }

            return sum;
        }
    }
}
