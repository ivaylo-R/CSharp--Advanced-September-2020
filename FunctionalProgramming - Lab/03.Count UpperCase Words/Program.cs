using System;
using System.Linq;

namespace _03.Count_UpperCase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text =Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var result = text.Where(FirstLetterUpper).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine,result));
        }

        private static bool FirstLetterUpper(string arg)
        {
            return arg[0] == Char.ToUpper(arg[0]);
        }
    }
}
