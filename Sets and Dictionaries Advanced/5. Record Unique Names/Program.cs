﻿using System;
using System.Collections.Generic;

namespace _5._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
