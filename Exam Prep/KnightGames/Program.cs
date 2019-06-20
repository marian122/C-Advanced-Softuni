using System;
using System.Linq;

namespace KnightGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] lines = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = lines[col];
                }


            }

            while (true)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            if (IsInMatrix(row - 1 , col - 2, matrix.Length))
                            {

                            }
                        }
                        
                    }
                }
            }
        }

        //if (IsInMatrix(row - 1, col - 2,matrix.Length) && matrix[row - 1][col - 2] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row - 1, col + 2, matrix.Length) && matrix[row - 1][col + 2] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row - 1, col - 2, matrix.Length) && matrix[row - 1][col - 2] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row + 1, col - 2, matrix.Length) && matrix[row + 1][col - 2] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row - 2, col + 1, matrix.Length) && matrix[row - 2][col + 1] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row + 2, col - 1, matrix.Length) && matrix[row + 2][col - 1] == 'K')
        //    {
        //        attacks++;
        //    }
        //    if (IsInMatrix(row + 2, col + 1, matrix.Length) && matrix[row + 2][col + 1] == 'K')
        //    {
        //        attacks++;
        //    }

        private static bool IsInMatrix(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}
