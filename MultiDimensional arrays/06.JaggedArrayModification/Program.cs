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
            for (int row = 0; row < rows; row++)
            {
                int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[inputNums.Length]; 
                for (int col = 0; col < inputNums.Length; col++)
                {
                    jagged[row][col] = inputNums[col];

                }
            }
            
            while (true)
            {
                string line =Console.ReadLine();

                if (line == "END")
                {
                    foreach (var row in jagged)
                    {
                        Console.WriteLine(String.Join(" ", row));
                    }
                    break;
                }

                string[] tokens = line.Split();
                if (tokens[0] == "Add")
                {
                    int currRow = int.Parse(tokens[1]);
                    int currCol = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);

                    if (currRow >= 0 
                        && currCol>=0 
                        && currRow<jagged.Length
                        && currCol<jagged.Length)
                    {
                        jagged[currRow][currCol] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (tokens[0]=="Subtract")
                {
                    int currRow = int.Parse(tokens[1]);
                    int currCol = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);
                    if (currRow >= 0
                        && currCol >= 0
                        && currRow < jagged.Length
                        && currCol < jagged.Length)
                    {
                        jagged[currRow] [currCol] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }
        }
    }
}
