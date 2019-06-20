using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstNum = input[0];
            var secondNum = input[1];
            var command = Console.ReadLine().Trim().ToLower();
            List<int> listNumbs = new List<int>();
            Predicate<int> predicate = x => command == "odd" ? x % 2 != 0 : x % 2 == 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                listNumbs.Add(i);
            }

            Console.WriteLine(string.Join(" ", listNumbs.Where(x => predicate(x))));
        }

    }
}
