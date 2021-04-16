using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            Action<string[]> printResult = name => Console.WriteLine("Sir " + String.Join(Environment.NewLine + "Sir ",name)); ;

            printResult(line);

        }
    }
}
