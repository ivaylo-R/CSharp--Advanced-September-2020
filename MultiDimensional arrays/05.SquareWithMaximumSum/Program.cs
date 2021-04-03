using System;
using System.Linq;
namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = lenght[0];
            var cols = lenght[1];
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col]
                    + matrix[row, col + 1]
                    + matrix[row + 1, col]
                    + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine(matrix[maxRowIndex, maxColIndex] + " " + matrix[maxRowIndex, maxColIndex + 1]);
            Console.WriteLine(matrix[maxRowIndex+1, maxColIndex] + " " + matrix[maxRowIndex+1, maxColIndex + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
