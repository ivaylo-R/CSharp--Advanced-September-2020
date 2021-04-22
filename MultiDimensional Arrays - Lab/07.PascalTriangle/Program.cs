using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());
            var jagged = new long[rows][];
            if (rows==0)
            {
                return;
            }
            jagged[0] = new long[1] { 1 };
            for (int row = 1; row < jagged.Length; row++)
            {
                jagged[row] = new long[row + 1];
                jagged[row][0] = 1;
                jagged[row][jagged[row].Length - 1] = 1;
                if (row != 1)
                {
                    for (int col = 1; col < jagged[row].Length - 1; col++)
                    {
                        jagged[row][col] = jagged[row - 1][col-1] + jagged[row - 1][col];
                    }
                }
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
