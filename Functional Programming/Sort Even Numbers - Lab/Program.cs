using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Even_Numbers___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)));

        }
    }
}
