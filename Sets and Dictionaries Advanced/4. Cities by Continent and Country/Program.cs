using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)                      
            {
                string line = Console.ReadLine();
                string[] productsInfo = line.Split(" ");
                string continent = productsInfo[0];
                string country = productsInfo[1];
                string city = productsInfo[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                    
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }
                dict[continent][country].Add(city);
               
            }
            
            foreach (var item in dict)
            {
                var continent = item.Key;
                Console.WriteLine($"{continent}:");

                foreach (var prod in item.Value)
                {
                    var countryName = prod.Key;
                    var cities = prod.Value;
                    Console.WriteLine($"  {countryName} -> {string.Join(", ", cities)} ");
                }
            }
        }
    }
}
