using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            int[,] matrix = new int[rows, cols];
            ReadMatrix(matrix);
            int primaryDiagonalTotal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    primaryDiagonalTotal += matrix[row, col];
                    break;
                }
            }
            Console.WriteLine(primaryDiagonalTotal);
        }
        private static void ReadMatrix(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = line[row];
                }
            }
        }
    }
}
