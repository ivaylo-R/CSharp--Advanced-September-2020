using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            ReadJagged(jagged);
            ReadCommands(jagged);
        }

        private static void ReadCommands(int[][] jagged)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                else if (line.Contains("Add"))
                {

                    var lineSplitted = line.Split();
                    int row = int.Parse(lineSplitted[1]);
                    int col = int.Parse(lineSplitted[2]);
                    int value = int.Parse(lineSplitted[3]);
                    if (col < jagged.Length && col >= 0 && row < jagged.Length && row >= 0)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    
                }
                else if (line.Contains("Subtract"))
                {
                    var lineSplitted = line.Split();
                    int row = int.Parse(lineSplitted[1]);
                    int col = int.Parse(lineSplitted[2]);
                    int value = int.Parse(lineSplitted[3]);
                    if (col < jagged.Length && col >= 0 && row < jagged.Length && row >= 0)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }
            PrintJaggedArray(jagged);
        }

        private static void PrintJaggedArray(int[][] jagged)
        {

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }

        private static void ReadJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[line.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = line[col];
                }
            }
        }
    }
}
