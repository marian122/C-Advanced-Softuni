using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
                       
            for (int row = 0; row < size; row++)
            {
               string currRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = currRow[col];
                    
                }
            }
            var symbolToFind = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col  = 0; col  < matrix.GetLength(0); col ++)
                {
                    if (symbolToFind == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{symbolToFind} does not occur in the matrix");
        }
    }
}
