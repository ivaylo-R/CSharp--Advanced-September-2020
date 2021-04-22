using System;
using System.Linq;

namespace _05._Square_With_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[tokens[0], tokens[1]];
            ReadMatrix(matrix);
            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    sum = matrix[row, col] 
                        + matrix[row, col + 1]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            PrintResult(matrix, maxSum, maxRow, maxCol);
            
        }

        private static void PrintResult(int[,] matrix, int maxSum, int maxRow, int maxCol)
        {
            for (int row = maxRow; row < maxRow + 2; row++)
            {
                for (int col = maxCol; col < maxCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                var line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = line[row];
                }
            }
        }
    }
}
