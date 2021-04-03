using System;

namespace _02.MultiDimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int startCount = 1; startCount <= size; startCount++)
            {
                PrintRow(size, startCount);
            }
            for (int startCount = size-1; startCount >= 1; startCount--)
            {
                PrintRow(size, startCount);
            }
        }

        private static void PrintRow(int size, int startCount)
        {
            for (int i = 0; i < size-startCount; i++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col < startCount; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}
