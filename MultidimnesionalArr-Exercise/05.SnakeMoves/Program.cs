using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            var matrix = new string[rows,cols];
            char[] text =Console.ReadLine().ToCharArray();
            if (text.Length > matrix.GetLength(1))
            {
                ReadMatrix(text, matrix);
            }
            
        }

        private static void ReadMatrix(char[] text, string[,] matrix)
        {
            
        }
    }
}
