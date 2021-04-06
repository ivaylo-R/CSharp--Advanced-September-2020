using System;
using System.Linq;

namespace _04.Matrix_Shuffling
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var arr=ReadMatrix(input[0], input[1]);
            ReadCommands(arr);
            
            
        }

        private static void PrintResult(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write($"{arr[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadCommands(string[,] arr)
        {
            while (true)
            {
                string line =Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                string[] lineSplitted = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                if (!line.Contains("swap") && line.Length!=5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = int.Parse(lineSplitted[1]);
                int col1 = int.Parse(lineSplitted[2]);
                int row2 = int.Parse(lineSplitted[3]);
                int col2 = int.Parse(lineSplitted[4]);
                if (row1>=arr.GetLength(0) || row2>=arr.GetLength(0) || col1>=arr.GetLength(1) || col2 >=arr.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string currElement = arr[row1, col1];
                arr[row1, col1] = arr[row2, col2];
                arr[row2, col2] = currElement;
                PrintResult(arr);
            }
        }

        private static string[,] ReadMatrix(int rows, int cols)
        {
            var matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] currRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            return matrix;
        }
    }
}
