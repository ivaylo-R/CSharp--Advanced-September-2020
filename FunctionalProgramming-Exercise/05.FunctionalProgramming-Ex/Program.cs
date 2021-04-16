using System;
using System.Linq;

namespace _05.FunctionalProgramming_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var line =Console.ReadLine().Split();
            Action<string[]> printNames = names => Console.WriteLine(String.Join(Environment.NewLine, names));
            printNames(line);
        }

       
    }
}
