using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            while (true)
            {
                string line =Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else if (line == "add")
                {
                    sequence = sequence.Select(n => n += 1).ToArray();
                }
                else if (line=="multiply")
                {
                    sequence = sequence.Select(Multiply()).ToArray();
                }
                else if (line=="subtract")
                {
                    sequence = sequence.Select(Subtract()).ToArray();
                }
                else if (line=="print")
                {
                    Action<int[]> printer = Printer();
                    printer(sequence);
                }
            }
        }

        private static Action<int[]> Printer()
        {
            return x => Console.WriteLine(String.Join(" ",x));
        }

        private static Func<int, int> Subtract()
        {
            return n => n -= 1;
        }

        private static Func<int, int> Multiply()
        {
            return x => x *= 2;
        }
    }
}
