using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int row = 0; row < size; row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = arr;
            }

            var coordinates = Console.ReadLine().Split();

            BombExplode(matrix, coordinates);

            List<int> aliveCells = AliveCells(matrix);

            Console.WriteLine($"Alive cells: {string.Join("", aliveCells.Count)}");
            Console.WriteLine($"Sum: {aliveCells.Sum()}");

            foreach (var numbers in matrix)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }

        private static List<int> AliveCells(int[][] matrix)
        {
            var positiveNumbers = new List<int>();
            foreach (var number in matrix)
            {
                foreach (var num in number.Where(x => x > 0))
                {
                    positiveNumbers.Add(num);
                }
            }
            return positiveNumbers;
        }

        private static void BombExplode(int[][] matrix, string[] bombCoordinates)
        {
            for (int i = 0; i < bombCoordinates.Length; i++)
            {
                var currentCoordinates = bombCoordinates[i].Split(',');

                int rowCoordinate = int.Parse(currentCoordinates[0]);
                int colCoordinate = int.Parse(currentCoordinates[1]);

                var bombDamage = matrix[rowCoordinate][colCoordinate];

                if (bombDamage > 0)
                {
                    for (int row = rowCoordinate - 1; row <= rowCoordinate + 1; row++)
                    {
                        for (int col = colCoordinate - 1; col <= colCoordinate + 1; col++)
                        {
                            if (IsInside(matrix, row, col))
                            {
                                if (matrix[row][col] > 0)
                                {
                                    matrix[row][col] -= bombDamage;

                                }
                            }
                        }
                    }
                }

            }
        }

        private static bool IsInside(int[][] matrix, int bombRow, int bombCol)
        {
            return bombRow >= 0 && bombRow < matrix.Length && bombCol >= 0 && bombCol < matrix[bombRow].Length;
        }
    }
}