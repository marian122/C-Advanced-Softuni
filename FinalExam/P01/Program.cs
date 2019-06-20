using System;
using System.Linq;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            char[,] matrix = new char[lines, lines];

            int[] firstPos = new int[2];
            int[] secondPlayerPosition = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] size = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = size[col];

                    if (matrix[row, col] == 'f')
                    {
                        firstPos[0] = row;
                        firstPos[1] = col;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        secondPlayerPosition[0] = row;
                        secondPlayerPosition[1] = col;
                    }
                }
            }
            string command = Console.ReadLine();
            while (true)
            {
                if (command.Length == 0)
                {
                    break;
                }

                string[] commands = command.Split();

                string firstPlayerCmd = commands[0];
                string secondPlayerCmd = commands[1];

                if (firstPlayerCmd == "up")
                {
                    firstPos = CommandUp(firstPos, matrix);

                    if (matrix[firstPos[0], firstPos[1]] == 's')
                    {
                        matrix[firstPos[0], firstPos[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[firstPos[0], firstPos[1]] = 'f';
                    }
                }
                else if (firstPlayerCmd == "down")
                {
                    firstPos = CommandDown(firstPos, matrix);

                    if (matrix[firstPos[0], firstPos[1]] == 's')
                    {
                        matrix[firstPos[0], firstPos[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[firstPos[0], firstPos[1]] = 'f';
                    }
                }
                else if (firstPlayerCmd == "left")
                {
                    firstPos = CommandLeft(firstPos, matrix);

                    if (matrix[firstPos[0], firstPos[1]] == 's')
                    {
                        matrix[firstPos[0], firstPos[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[firstPos[0], firstPos[1]] = 'f';
                    }
                }
                else if (firstPlayerCmd == "right")
                {
                    firstPos = CommandRight(firstPos, matrix);

                    if (matrix[firstPos[0], firstPos[1]] == 's')
                    {
                        matrix[firstPos[0], firstPos[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[firstPos[0], firstPos[1]] = 'f';
                    }
                }
                if (secondPlayerCmd == "up")
                {
                    secondPlayerPosition = CommandUp(secondPlayerPosition, matrix);

                    if (matrix[secondPlayerPosition[0], secondPlayerPosition[1]] == 'f')
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 's';
                    }
                }
                else if (secondPlayerCmd == "down")
                {
                    secondPlayerPosition = CommandDown(secondPlayerPosition, matrix);
                    if (matrix[secondPlayerPosition[0], secondPlayerPosition[1]] == 'f')
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 's';
                    }
                }
                else if (secondPlayerCmd == "left")
                {
                    secondPlayerPosition = CommandLeft(secondPlayerPosition, matrix);
                    if (matrix[secondPlayerPosition[0], secondPlayerPosition[1]] == 'f')
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 's';
                    }
                }
                else if (secondPlayerCmd == "right")
                {
                    secondPlayerPosition = CommandRight(secondPlayerPosition, matrix);

                    if (matrix[secondPlayerPosition[0], secondPlayerPosition[1]] == 'f')
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[secondPlayerPosition[0], secondPlayerPosition[1]] = 's';
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
        public static int[] CommandUp(int[] playerPosition, char[,] matrix)
        {
            if (playerPosition[0] - 1 >= 0)
            {
                playerPosition[0]--;
            }
            else
            {
                playerPosition[0] = matrix.GetLength(0) - 1;
            }
            return playerPosition;
        }
        public static int[] CommandDown(int[] playerPosition, char[,] matrix)
        {
            if (playerPosition[0] + 1 < matrix.GetLength(0))
            {
                playerPosition[0]++;
            }
            else
            {
                playerPosition[0] = 0;
            }
            return playerPosition;
        }
        public static int[] CommandLeft(int[] playerPosition, char[,] matrix)
        {
            if (playerPosition[1] - 1 >= 0)
            {
                playerPosition[1]--;
            }
            else
            {
                playerPosition[1] = matrix.GetLength(1) - 1;
            }
            return playerPosition;
        }
        public static int[] CommandRight(int[] playerPosition, char[,] matrix)
        {
            if (playerPosition[1] + 1 < matrix.GetLength(1))
            {
                playerPosition[1]++;
            }
            else
            {
                playerPosition[1] = 0;
            }
            return playerPosition;
        }
    }
}
