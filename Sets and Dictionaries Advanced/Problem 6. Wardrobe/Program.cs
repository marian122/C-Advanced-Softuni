using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < input; i++)
            {
                var clothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = clothes[0];

                if (!dict.ContainsKey(color))
                {
                    dict[color] = new Dictionary<string, int>();
                }
                var currentColor = dict[color];

                string[] clothesData = clothes[1].Split(",", StringSplitOptions.RemoveEmptyEntries);


                for (int j = 0; j < clothesData.Length; j++)
                {
                    string cloth = clothesData[j];

                    if (!currentColor.ContainsKey(cloth))
                    {
                        currentColor[cloth] = 0;
                    }
                    currentColor[cloth]++;
                }
                
            }
            string[] searchedData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var colorNeeded = searchedData[0];
            var clothNeeded = searchedData[1];

            foreach (var colorKvp in dict)
            {
                string color = colorKvp.Key;
                var cloths = colorKvp.Value;

                Console.WriteLine($"{color} clothes:");
                foreach (var clothsKvp in cloths)
                {
                    string currentCloth = clothsKvp.Key;
                    int count = clothsKvp.Value;

                    if (color == colorNeeded && currentCloth == clothNeeded)
                    {
                        Console.WriteLine($"* {currentCloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {currentCloth} - {count}");
                    }
                }
            }

        }
    }
}
