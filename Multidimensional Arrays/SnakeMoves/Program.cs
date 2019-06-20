using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[][] matrix = new char[rows][];

            var text = Console.ReadLine().ToCharArray();
            Queue<char> snakeQue = new Queue<char>(text);
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                for (int col = 0; col < cols; col++)
                {
                    char charToAdd = snakeQue.Dequeue();
                    matrix[row][col] = charToAdd;
                    snakeQue.Enqueue(charToAdd);

                }
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
    }
}
