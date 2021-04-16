using System;
using System.Linq;

namespace _07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var seq = Console.ReadLine().Split();
            Func<string, bool> isValid = x => x.Length <= n;
            Action<string[]> print = name => Console.WriteLine(String.Join(Environment.NewLine, name));
            seq = seq.Where(isValid).ToArray();
            print(seq);
        }
    }
}
