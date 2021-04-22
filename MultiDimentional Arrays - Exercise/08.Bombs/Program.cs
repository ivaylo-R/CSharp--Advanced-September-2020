using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] field = new int[n, n];
        ReadField(field);
        var bombs = Console.ReadLine().Split();
        ExplodeBombs(field, bombs);
        FindAliveCells(field);
    }

    private static void FindAliveCells(int[,] field)
    {
        int cells = 0;
        int sum = 0;
        foreach (var cell in field)
        {
            if (cell>0)
            {
                cells++;
                sum += cell;
            }
        }
        PrintResult(cells, sum,field);
    }

    private static void PrintResult(int cells, int sum, int [,] field)
    {
        Console.WriteLine($"Alive cells: {cells}");
        Console.WriteLine($"Sum: {sum}");
        PrintField(field);
    }

    private static void ExplodeBombs(int[,] field, string[] bombs)
    {
        foreach (var item in bombs)
        {
            var bombsCoordinates = item.Split(',').Select(int.Parse).ToArray();
            var currentRow = bombsCoordinates[0];
            var currentCol = bombsCoordinates[1];
            var currentBomb = field[currentRow, currentCol];


            for (int row = currentRow - 1; row <= currentRow + 1; row++)
            {
                for (int col = currentCol - 1; col <= currentCol + 1; col++)
                {
                    if (row >= 0 && row < field.GetLength(0)
                        && col >= 0 && col < field.GetLength(1))
                    {
                        if (field[row, col] <= 0 || currentBomb < 0)
                        {
                            continue;
                        }
                        field[row, col] -= currentBomb;
                    }
                }
            }
        }
    }

    private static void PrintField(int[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                Console.Write(field[row, col] + " ");

            }
            Console.WriteLine();
        }
    }



    private static void ReadField(int[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = currentRow[col];
            }
        }
    }
}