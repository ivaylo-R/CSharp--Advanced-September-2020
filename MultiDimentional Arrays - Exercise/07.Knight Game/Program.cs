using System;

class KnightGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var board = new char[n][];
        for (int i = 0; i < n; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        int maxAttacked = 0;
        int maxRow = 0;
        int maxColumn = 0;
        int countOfRemovedKnights = 0;

        do
        {
            if (maxAttacked > 0)
            {
                board[maxRow][maxColumn] = '0';
                maxAttacked = 0;
                countOfRemovedKnights++;
            }

            int currentAttacks = 0;

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    if (board[row][column] == 'K')
                    {
                        currentAttacks = CalculateAttacks(row, column, board);

                        if (currentAttacks > maxAttacked)
                        {
                            maxAttacked = currentAttacks;
                            maxRow = row;
                            maxColumn = column;
                        }
                    }
                }
            }
        }
        while (maxAttacked > 0);

        Console.WriteLine(countOfRemovedKnights);
    }

    private static int CalculateAttacks(int row, int column, char[][] board)
    {
        int result = 0;

        if (IsPositionAttacked(row - 2, column - 1, board)) result++;
        if (IsPositionAttacked(row - 2, column + 1, board)) result++;
        if (IsPositionAttacked(row - 1, column - 2, board)) result++;
        if (IsPositionAttacked(row - 1, column + 2, board)) result++;
        if (IsPositionAttacked(row + 1, column - 2, board)) result++;
        if (IsPositionAttacked(row + 1, column + 2, board)) result++;
        if (IsPositionAttacked(row + 2, column - 1, board)) result++;
        if (IsPositionAttacked(row + 2, column + 1, board)) result++;

        return result;
    }

    private static bool IsPositionAttacked(int row, int column, char[][] board)
    {
        return (row >= 0 && row < board.Length && column >= 0 && column < board.Length)
            && board[row][column] == 'K';
    }

    
}