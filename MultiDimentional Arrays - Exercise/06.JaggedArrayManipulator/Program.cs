using System;
using System.Linq;
namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var jagged = new double[rows][];
            ReadJagged(jagged);
            MultiplyAndDivideElementsInMatrix(jagged);
            ReadCommands(jagged);
        }

        private static void ReadCommands(double[][] jagged)
        {
            while (true)
            {
                var command =Console.ReadLine();
                if (command == "End")
                {
                    PrintJagged(jagged);
                    return;
                }
                else if (command.Contains("Add"))
                {
                    var cmdSplitted = command.Split().ToArray();
                    int row = int.Parse(cmdSplitted[1]);
                    int col = int.Parse(cmdSplitted[2]);
                    int value = int.Parse(cmdSplitted[3]);
                    if (row >= 0 && row <= jagged.Length
                        && col >= 0 && col <= jagged.Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command.Contains("Subtract"))
                {
                    var cmdSplitted = command.Split().ToArray();
                    int row = int.Parse(cmdSplitted[1]);
                    int col = int.Parse(cmdSplitted[2]);
                    int value = int.Parse(cmdSplitted[3]);
                    if (row >= 0 && row <= jagged.Length
                        && col >= 0 && col <= jagged.Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }
        }

        private static void PrintJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void MultiplyAndDivideElementsInMatrix(double [][] jagged)
        {
            for (int row = 0; row < jagged.Length-1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    Multiply(jagged, row);
                }
                else
                {
                    Divide(jagged, row);
                }
            }
        }

        private static void Divide(double[][] jagged, int currRow)
        {
            for (int row = currRow; row < currRow + 2; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] /= 2;
                }
            }
        }

        private static void Multiply(double[][] jagged,int currRow)
        {
            for (int row = currRow; row < currRow+2; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] *= 2;
                }
            }
        }

        private static void ReadJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jagged[row] = new double[input.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }
        }
    }
}
