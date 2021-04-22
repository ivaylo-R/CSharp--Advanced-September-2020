using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new string[tokens[0], tokens[1]];
            ReadMatrix(matrix);
            ReadCommands(matrix);

        }

        private static void ReadCommands(string[,] matrix)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    return;
                }
                else if (!line.Contains("swap"))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if (line.Contains("swap"))
                {
                    var tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    int currRow = int.Parse(tokens[1]);
                    int currCol = int.Parse(tokens[2]);
                    int newRow = int.Parse(tokens[3]);
                    int newCol = int.Parse(tokens[4]);

                    if (currRow >= 0 && currRow < matrix.GetLength(0)
                        && currCol >= 0 && currCol < matrix.GetLength(1)
                        && newRow >= 0 && newRow < matrix.GetLength(0)
                        && newCol >= 0 && newCol < matrix.GetLength(1))
                    {
                        string currElement = matrix[currRow, currCol];
                        matrix[currRow, currCol] = matrix[newRow, newCol];
                        matrix[newRow, newCol] = currElement;
                        PrintMatrix(matrix);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }

            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
