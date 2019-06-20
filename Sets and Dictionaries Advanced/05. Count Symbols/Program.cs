using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            var counts = new SortedDictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                char current = words[i];
                
                if (!counts.ContainsKey(current))
                {
                    counts.Add(current, 0);
                }
                counts[current] += 1;
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key}: {num.Value} time/s");
            }
        }
    }
}
