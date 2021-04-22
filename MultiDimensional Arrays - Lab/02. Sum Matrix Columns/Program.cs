using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[tokens[0], tokens[1]];
            ReadMatrix(matrix);
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

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
