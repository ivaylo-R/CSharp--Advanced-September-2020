using System;
using System.Linq;
namespace _04._Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            string[,] matrix = new string[rows, cols];
            ReadMatrix(matrix);
            char symbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]==symbol.ToString())
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix ");
        }

        private static void ReadMatrix(string[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = line[row].ToString();
                }
            }
        }
    }
}
