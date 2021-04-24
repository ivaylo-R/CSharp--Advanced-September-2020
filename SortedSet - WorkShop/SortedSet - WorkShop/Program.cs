
using System;

namespace SortedSet___WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHashSet set = new StringHashSet(8);
            set.Add("hey");
            set.Add("6");
            set.Add("7");
            set.Add("fsd");
            set.Add("oshte");
            set.Add("g");
            set.Add("o");
            set.Add("33");
            set.Add("opa");
            set.Add("hey");
            set.Add("hey");
            set.Add("hey");

            Console.WriteLine(set.Contains("33"));
            Console.WriteLine(set.Contains("opa"));
            Console.WriteLine(set.Contains("ff"));
            Console.WriteLine(set.Contains("heyy"));
        }
    }
}
