using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split();
            var field = new char[n][];
            ReadField(field);
            ReadCommands(field, commands);
        }

        private static void ReadCommands(char[][] field, string[] commands)
        {
            int coals = FindCoalsCount(field);
            int [] startPoint=FindStartPoint(field);
            int currentRow = startPoint[0];
            int currentCol = startPoint[1];
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    if (IsInsideTheField(currentRow-1,currentCol,field.Length))
                    {
                        if (field[currentRow-1][currentCol]=='*')
                        {
                            currentRow--;
                        }
                        else if (field[currentRow - 1][currentCol] == 'c')
                        {
                            currentRow--;
                            coals--;
                            field[currentRow][currentCol] = '*';
                            if (coals==0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                        }
                        else if (field[currentRow - 1][currentCol] == 'e')
                        {
                            currentRow--;
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }
                        
                    }
                }
                else if (commands[i] == "down")
                {
                    if (IsInsideTheField(currentRow+1, currentCol, field.Length))
                    {
                        if (field[currentRow + 1][currentCol] == '*')
                        {
                            currentRow++;
                        }
                        else if (field[currentRow + 1][currentCol] == 'c')
                        {
                            currentRow++;
                            coals--;
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }

                            field[currentRow][currentCol] = '*';
                        }
                        else if (field[currentRow + 1][currentCol] == 'e')
                        {
                            currentRow++;
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }

                    }
                }
                else if (commands[i] == "right")
                {
                    if (IsInsideTheField(currentRow, currentCol+1, field.Length))
                    {
                        if (field[currentRow][currentCol+1] == '*')
                        {
                            currentCol++;
                        }
                        else if (field[currentRow][currentCol+1] == 'c')
                        {
                            coals--;
                            currentCol++;
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                            field[currentRow][currentCol] = '*';
                        }
                        else if (field[currentRow][currentCol+1] == 'e')
                        {
                            currentCol++;
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }

                    }
                }
                else if (commands[i] == "left")
                {
                    if (IsInsideTheField(currentRow, currentCol-1, field.Length))
                    {
                        if (field[currentRow][currentCol-1] == '*')
                        {
                            currentCol--;
                        }
                        else if (field[currentRow][currentCol-1] == 'c')
                        {
                            currentCol--;
                            coals--;
                            if (coals == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                return;
                            }
                            field[currentRow][currentCol] = '*';
                        }
                        else if (field[currentRow - 1][currentCol] == 'e')
                        {
                            currentRow--;
                            Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                            return;
                        }

                    }
                }
            }

            Console.WriteLine($"{coals} coals left. ({currentRow}, {currentCol})");
        }

        private static bool IsInsideTheField(int startRow, int startCol, int length)
        {
            if (startRow >= 0 && startRow < length && startCol >= 0 && startCol < length) return true;
            return false;
        }

        private static int[] FindStartPoint(char[][] field)
        {
            int[] rowColPair = new int[2];
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col]=='s')
                    {
                        rowColPair[0] = row;
                        rowColPair[1] = col;
                    }
                }
            }
            return rowColPair;
        }

        private static int FindCoalsCount(char[][] field)
        {
            int coals = 0;
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'c')
                    {
                        coals++;
                    }
                }
            }
            return coals;
        }

        private static void ReadField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                var line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                field[row] = new char[line.Length];
                for (int col = 0; col < field[row].Length; col++)
                {
                    field[row][col] = line[col];
                }
            }
        }
    }
}
