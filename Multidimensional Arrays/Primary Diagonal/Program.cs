using System;
using System.Linq;

namespace Sum_Matrix_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = currRow[col];

                }
            }
            int sum = 0;
            for (int row = 0; row < size; row++)
            {
                sum += matrix[row, row];

                    
            }
                Console.WriteLine(sum);
            
        }
    }
}
