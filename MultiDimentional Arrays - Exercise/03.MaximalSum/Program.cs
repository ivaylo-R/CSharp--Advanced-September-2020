using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new int[tokens[0], tokens[1]];
            ReadMatrix(matrix);
            FindBest3x3Matrix(matrix);
            
        }

        private static void FindBest3x3Matrix(int[,] matrix)
        {
            int bestSum = 0;
            int sum = 0;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row, col + 2] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, +col] + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (sum>bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            PrintBestSum(bestSum);
            PrintBest3x3Mat(matrix, bestRow, bestCol);
        }

        private static void PrintBest3x3Mat(int[,] matrix, int bestRow, int bestCol)
        {
            for (int row = bestRow; row < bestRow+3; row++)
            {
                for (int col = bestCol; col < bestCol+3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void PrintBestSum(int bestSum) => Console.WriteLine($"Sum = {bestSum}");
        
        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
