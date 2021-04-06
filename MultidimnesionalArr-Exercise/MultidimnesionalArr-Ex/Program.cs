using System;
using System.Linq;

namespace MultidimnesionalArr_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var matrix = ReadMatrix(rows);
            int sumPrimaryDiagonal=PrimaryDiagonal(matrix);
            int sumSndaryDiagonal=SndaryDiagonal(matrix);
            Console.WriteLine(Math.Abs(sumPrimaryDiagonal-sumSndaryDiagonal));
        }

        private static int PrimaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int row = -1; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = row; col < matrix.GetLength(1)-1; col++)
                {
                    sum += matrix[row + 1, col + 1];
                    break;
                }
            }
            return sum;
        }

        private static int[,] ReadMatrix(int rows)
        {
            int cols = rows;
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var currCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currCol[col];
                }
            }
            return matrix;
        }

        private static int SndaryDiagonal(int [,] arr)
        {
            int sum = 0;
            int lastCol = arr.GetLength(1) - 1;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                sum += arr[row, lastCol];
                lastCol--;
            }
            return sum;
        }
    }
}
