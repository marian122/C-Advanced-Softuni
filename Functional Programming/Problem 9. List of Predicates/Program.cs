using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

            var list = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                if (DevidersInfo(i, dividers))
                {
                    list.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
        private static bool DevidersInfo(int n, List<int> divider)
        {
            bool isTrue = true;
            foreach (int dividerNum in divider)
            {
                if (n % dividerNum != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
