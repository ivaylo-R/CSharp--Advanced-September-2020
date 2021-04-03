using System;

namespace _04._SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] matrix = new char[N, N];
            for (int rows = 0; rows < N; rows++)
            {
                string currentRow =Console.ReadLine();
                for (int cols = 0; cols < currentRow.Length; cols++)
                {
                    char currentCol = char.Parse(currentRow[cols].ToString());
                    matrix[rows, cols] = currentCol;
                }
                
            }
            bool isFind = false;
            char sym = char.Parse(Console.ReadLine());

            for (int rows = 0; rows < N; rows++)
            {
                for (int cols = 0; cols < N; cols++)
                {
                    var currentSym =matrix[rows,cols];
                    if (currentSym==sym)
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        return;

                    }
                }

            }
            if (!isFind)
            {
                Console.WriteLine($"{sym} does not occur in the matrix ");
            }
        }
    }
}
