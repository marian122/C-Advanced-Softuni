using System;
using System.Linq;

namespace DiagonalDifference 
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = currRow[col];

                }  
            }
            int FirstSum = 0;
            int secondSum = 0;
            for (int row = 0; row < size; row++)
            {
                FirstSum += matrix[row, row];


            }
            int start = size - 1;

            for (int secondRow = 0, col = size - 1; secondRow < size; secondRow++, col--)
            {
                secondSum += matrix[secondRow, col];
                

            }
            Console.WriteLine(Math.Abs(secondSum - FirstSum));

        }
    }
}
