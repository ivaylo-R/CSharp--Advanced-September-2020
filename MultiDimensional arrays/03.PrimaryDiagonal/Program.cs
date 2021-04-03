using System;
using System.Linq;
namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var matrix = new int[count, count];

            int sum = 0;
            for (int row = 0; row < count; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < count; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            
            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < count-1; col++)
                {
                    sum += matrix[row, col + row];
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
