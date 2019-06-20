using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            int[][] arr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                arr[row] = currRow;
                for (int col = 0; col < rows; col++)
                {

                    arr[row][col] = currRow[col];

                }
            }
            
            while (true)
            {
                var input = Console.ReadLine();
                
                if (input.ToLower() == "end")
                {
                    break;
                }
                string[] data = input.Split();
                var command = data[0];
                int cmdRow = int.Parse(data[1]);
                int cmdCol = int.Parse(data[2]);
                int value = int.Parse(data[3]);
                
                if (cmdRow < 0 || cmdCol < 0 || cmdRow >= arr.Length || cmdCol >= arr[cmdRow].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (command == "Add")
                {
                    arr[cmdRow][cmdCol] += value;
                }
                else if (command == "Subtract")
                {
                    arr[cmdRow][cmdCol] -= value;
                }
            }
            foreach (var row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
