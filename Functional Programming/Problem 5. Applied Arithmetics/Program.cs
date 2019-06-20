using System;
using System.Linq;

namespace Problem_5._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    for (int i = 0; i < listNumbers.Count; i++)
                    {
                        listNumbers[i] += 1;
                    }
                }
                else if (command == "subtract")
                {
                    for (int i = 0; i < listNumbers.Count; i++)
                    {
                        listNumbers[i] -= 1;
                    }
                }
                else if (command == "multiply")
                {
                    for (int i = 0; i < listNumbers.Count; i++)
                    {
                        listNumbers[i] *= 2;
                    }
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", listNumbers));
                }
                command = Console.ReadLine();
            }
        }
    }
}
