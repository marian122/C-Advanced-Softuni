using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();

            string line = Console.ReadLine();

            while (line != "Revision")
            {
                string[] productsInfo = line.Split(", ");
                string shop = productsInfo[0];
                string product = productsInfo[1];
                double price = double.Parse(productsInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
                line = Console.ReadLine();
            }
            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in orderedShops)
            {
                var market = item.Key;
                var product = item.Value;
                Console.WriteLine($"{market} ->");

                foreach (var prod in product)
                {
                    Console.WriteLine($"Product: {prod.Key}, Price: {prod.Value} ");
                }
            }
        }
    }
}
