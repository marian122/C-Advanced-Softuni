using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(currentNumber))
                {
                    dict[currentNumber] = 0;
                }

                dict[currentNumber]++;
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
        
    }
}
