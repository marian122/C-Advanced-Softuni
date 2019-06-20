using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                foreach (var item in input)
                {
                    set.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", set.OrderBy(x => x)));
        }
    }
}
