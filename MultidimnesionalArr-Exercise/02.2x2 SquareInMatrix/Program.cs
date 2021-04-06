using System;
using System.Linq;

namespace _02._2x2_SquareInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            var matrix = ReadMat(rows, cols);
            int count = FindSquares(matrix);

            Console.WriteLine(count);

        }

        private static int FindSquares(char[,] arr)
        {
            int count = 0;
            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++)
                {
                    char currSym = arr[row, col];
                    if (currSym == arr[row, col + 1] && currSym == arr[row + 1, col]
                        && currSym == arr[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static char[,] ReadMat(int rows, int cols)
        {
            var arr = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] currSym = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    arr[row, col] = currSym[col];
                }
            }
            return arr;
        }
    }
}
