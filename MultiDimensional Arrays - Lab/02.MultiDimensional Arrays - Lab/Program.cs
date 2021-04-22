using System;
using System.Linq;
namespace _02.MultiDimensional_Arrays___Lab
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = tokens[0];
            int cols = tokens[1];
            int[,] matrix = new int[rows, cols];
            int sum = 0;
            ReadMatrix(matrix,sum);

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }

        static int ReadMatrix(int [,] matrix,int sum)
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    sum += input[col];
                }
            }
            return sum;
        }
    }
}

