using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var arr = ReadArr(input[0], input[1]);
            FindBestSum(arr);
        }

        private static void FindBestSum(int[,] arr)
        {
            int bestRow = 0;
            int bestCol = 0;
            int maxSum = 0;
            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < arr.GetLength(1) - 2; col++)
                {
                    int currNum = arr[row, col];
                    int currSum = currNum + arr[row, col + 1] + arr[row, col + 2]
                        + arr[row + 1, col] + arr[row + 1, col + 1]
                        + arr[row + 1, col + 2] + arr[row + 2, col]
                        + arr[row + 2, col + 1] + arr[row + 2, col + 2];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }

            }
            PrintResult(arr, bestRow, bestCol, maxSum);
        }

        private static void PrintResult(int[,] arr, int bestRow, int bestCol, int sum)
        {
            Console.WriteLine($"Sum = {sum}");

            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] ReadArr(int rows, int cols)
        {
            int[,] arr = new int[rows, cols];
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = input[col];
                }
            }

            return arr;
        }
    }
}
