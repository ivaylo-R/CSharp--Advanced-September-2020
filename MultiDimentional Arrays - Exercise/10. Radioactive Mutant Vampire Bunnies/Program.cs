using System;
using System.Linq;
namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowColPair = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowColPair[0];
            int cols = rowColPair[1];
            var field = new char[rows,cols];
            ReadMatrix(field);
            bool isDeadOrWon = ReadCommands(field);
            if (isDeadOrWon)
            {
                return;
            }
        }

        private static bool ReadCommands(char[,] field)
        {
            var commands = Console.ReadLine().ToCharArray();
            int[] rowColPair = FindPlayerIndex(field);
            int playrRow = rowColPair[0];
            int playrCol = rowColPair[1];
            for (int i = 0; i < commands.Length; i++)
            {
                var command = commands[i];
                if (command=='U')
                {
                    bool isDeadOrWon = MovePlayerUp(field, playrRow - 1, playrCol);
                    if (isDeadOrWon)
                    {
                        return true;
                    }
                    playrRow--;
                    MultiplyBunnies(field, playrRow - 1, playrCol);
                }
                else if (command=='D')
                {
                    bool isDeadOrWon= MovePlayerDown(field, playrRow + 1, playrCol);
                    if (isDeadOrWon)
                    {
                        return true;
                    }
                    playrRow++;
                    MultiplyBunnies(field, playrRow + 1, playrCol);
                }
                else if (command=='R')
                {
                    bool isDeadOrWon = MovePlayerRight(field, playrRow, playrCol+1);
                    if (isDeadOrWon)
                    {
                        return true;
                    }
                    playrCol++;
                    MultiplyBunnies(field, playrRow, playrCol+1);
                }
                else if (command=='L')
                {
                    bool isDeadOrWon = MovePlayerLeft(field, playrRow, playrCol-1);
                    playrCol--;
                    MultiplyBunnies(field, playrRow, playrCol-1);
                    if (isDeadOrWon)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool MovePlayerLeft(char[,] field, int newRow, int newCol)
        {
            if (isInsideTheField(field, newRow, newCol))
            {
                if (field[newRow, newCol] == '.')
                {
                    field[newRow, newCol] = 'P';
                    field[newRow, newCol+1] = '.';
                }
                else if (field[newRow, newCol] == 'B')
                {
                    field[newRow, newCol+1] = '.';
                    MultiplyBunnies(field, newRow, newCol);
                    PrintField(field);
                    Console.WriteLine($"dead: {newRow} {newCol}");
                    return true;
                }
            }
            else
            {
                if (newCol<0)
                {
                    newCol = 0;
                }
                field[newRow, newCol] = '.';
                PrintField(field);
                Console.WriteLine($"won: {newRow} {newCol}");
                return true;
            }
            return false;
        }

        private static bool MovePlayerRight(char[,] field, int newRow, int newCol)
        {
            if (isInsideTheField(field, newRow, newCol))
            {
                if (field[newRow, newCol] == '.')
                {
                    field[newRow, newCol] = 'P';
                    field[newRow, newCol-1] = '.';
                }
                else if (field[newRow, newCol] == 'B')
                {
                    field[newRow, newCol-1] = '.';
                    MultiplyBunnies(field, newRow, newCol);
                    PrintField(field);
                    Console.WriteLine($"dead: {newRow} {newCol}");
                    return true;
                }
            }
            else
            {
                if (newCol < 0)
                {
                    newCol = 0;
                }
                field[newRow, newCol] = '.';
                MultiplyBunnies(field, newRow, newCol);
                PrintField(field);
                Console.WriteLine($"won: {newRow} {newCol}");
                return true;
            }
            return false;
        }

        private static bool MovePlayerDown(char[,] field, int newRow, int newCol)
        {
            if (isInsideTheField(field, newRow, newCol))
            {
                if (field[newRow, newCol] == '.')
                {
                    field[newRow, newCol] = 'P';
                    field[newRow - 1, newCol] = '.';
                }
                else if (field[newRow, newCol] == 'B')
                {
                    field[newRow - 1, newCol] = '.';
                    PrintField(field);
                    Console.WriteLine($"dead: {newRow} {newCol}");
                    return true;
                }
            }
            else
            {
                if (newRow < 0)
                {
                    newRow = 0;
                }
                field[newRow, newCol] = '.';
                MultiplyBunnies(field, newRow, newCol);
                PrintField(field);
                Console.WriteLine($"won: {newRow} {newCol}");
                return true;
            }
            return false;
        }

        private static void MultiplyBunnies(char[,] field, int newRow, int newCol)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]=='B')
                    {
                        if (isInsideTheField(field,row,col-1))
                        {
                            if (field[row,col-1]=='.')
                            {
                                field[row, col - 1] = 'F';
                            }
                            else if (field[row, col - 1] == 'P')
                            {
                                field[newRow - 1, newCol] = '.';
                                MultiplyBunnies(field, newRow, newCol);
                                PrintField(field);
                                Console.WriteLine($"dead: {newRow} {newCol}");
                                return;
                            }
                        }
                        if (isInsideTheField(field, row, col + 1))
                        {
                            if (field[row, col + 1] == '.')
                            {
                                field[row, col + 1] = 'F';
                            }
                            else if (field[row, col + 1] == 'P')
                            {
                                field[newRow - 1, newCol] = '.';
                                MultiplyBunnies(field, newRow, newCol);
                                PrintField(field);
                                Console.WriteLine($"dead: {newRow} {newCol}");
                                return;
                            }
                        }
                        if (isInsideTheField(field, row-1, col))
                        {
                            if (field[row-1, col] == '.')
                            {
                                field[row-1, col] = 'F';
                            }
                            else if (field[row-1, col] == 'P')
                            {
                                field[newRow - 1, newCol] = '.';
                                MultiplyBunnies(field, newRow, newCol);
                                PrintField(field);
                                Console.WriteLine($"dead: {newRow} {newCol}");
                                return;
                            }
                        }
                        if (isInsideTheField(field, row+1, col))
                        {
                            if (field[row+1, col] == '.')
                            {
                                field[row+1, col] = 'F';
                            }
                            else if (field[row+1, col] == 'P')
                            {
                                field[newRow - 1, newCol] = '.';
                                MultiplyBunnies(field, newRow, newCol);
                                PrintField(field);
                                Console.WriteLine($"dead: {newRow} {newCol}");
                                return;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            ReplaceFWithB(field);
        }

        private static void ReplaceFWithB(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]=='F')
                    {
                        field[row, col] = 'B';
                    }
                }
            }
        }

        private static int[] FindPlayerIndex(char[,] field)
        {
            int[] rowColPair = new int[2];
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]=='P')
                    {
                        rowColPair[0] = row;
                        rowColPair[1] = col;
                    }
                }
            }
            return rowColPair;
        }

        private static bool MovePlayerUp(char[,] field,int newRow,int newCol)
        {

            if (isInsideTheField(field, newRow, newCol))
            {
                if (field[newRow, newCol] == '.')
                {
                    field[newRow, newCol] = 'P';
                    field[newRow + 1, newCol] = '.';
                }
                else if (field[newRow, newCol] == 'B')
                {
                    field[newRow + 1, newCol] = '.';
                    MultiplyBunnies(field, newRow, newCol);
                    PrintField(field);
                    Console.WriteLine($"dead: {newRow} {newCol}");
                    return true;
                }
            }
            else
            {
                if (newRow < 0)
                {
                    newRow = 0;
                }
                field[newRow, newCol] = '.';
                MultiplyBunnies(field, newRow, newCol);
                PrintField(field);
                Console.WriteLine($"won: {newCol} {newCol}");
                return true;
            }
            return false;
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool isInsideTheField(char [,] field, int plyrRow, int plyrCol)
        {
            if (plyrRow >= 0 && plyrRow < field.GetLength(0) && plyrCol >= 0 && plyrCol < field.GetLength(1)) return true;
            return false;
        }

        private static void ReadMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = line[col];
                }
            }
        }
    }
}
