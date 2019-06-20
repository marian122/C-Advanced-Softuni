using System;
using System.Linq;

namespace Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowCol[0];
            int cols = rowCol[1];

            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new string[cols];
                matrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);               
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                

                if (data[0] != "swap" || data.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                var cmdRow = int.Parse(data[1]);
                var cmdCol = int.Parse(data[2]);
                var currentSwap = int.Parse(data[3]);
                var secondSwap = int.Parse(data[4]);
                

                if (cmdRow < 0 || cmdCol < 0
                    || cmdRow >= rows || cmdCol >= cols
                    || currentSwap < 0 || secondSwap < 0
                    || currentSwap >= rows || secondSwap >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                string newRowIndex = matrix[cmdRow][cmdCol];
                string newColIndex = matrix[currentSwap][secondSwap];

                matrix[cmdRow][cmdCol] = newColIndex;
                matrix[currentSwap][secondSwap] = newRowIndex;

                input = Console.ReadLine();

                foreach (var item in matrix)
                {
                    Console.WriteLine(string.Join(" ", item));
                }
            }
        }
    }
}
