using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<int>();
            var secondSet = new HashSet<int>();

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstDigit = input[0];
            var secondDigit = input[1];
            for (int i = 0; i < firstDigit; i++)
            {
                var n = int.Parse(Console.ReadLine());
                set.Add(n);
                
            }
            for (int i = 0; i < secondDigit; i++)
            {
                var n = int.Parse(Console.ReadLine());
                secondSet.Add(n);
            }
            Console.WriteLine(string.Join(" ", set.Intersect(secondSet)));
        }
    }
}
