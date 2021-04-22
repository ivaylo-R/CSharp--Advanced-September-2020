using System;
using System.Linq;

namespace _02.MultiDimentional_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            var matrix = new int[rows, cols];
            ReadMatrix(matrix);
            
            PrintDifference(FindSecondaryDiagonal(matrix), FindPrimaryDiagonal(matrix));

        }

        private static void PrintDifference(int sum1, int sum2) => Console.WriteLine(Math.Abs(sum1-sum2));
        

        private static int FindSecondaryDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int row =0 ; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1)-1-row; col >=0 ; col--)
                {
                    sum += matrix[row, col];
                    break;
                }
            }
            return sum;
        }

        private static int FindPrimaryDiagonal(int[,] matrix)
        {
            int sumOfPrimaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    sumOfPrimaryDiagonal += matrix[row, col];
                    break;
                }
            }

            return sumOfPrimaryDiagonal;
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
