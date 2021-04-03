using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var arr = new int[rows][];
            arr[0] = new int[1];
            arr[0][0] = 1;
            for (int row = 0; row < rows; row++)
            {
                arr[row] = new int[row+1];
                arr[row][0] = 1;
                arr[row][arr[row].Length - 1] = 1;
                for (int col = 1; col < arr[row].Length-1; col++)
                {
                    arr[row][col] += arr[row - 1][col] + arr[row - 1][col - 1];
                }
            }
            foreach (var row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
