using System;
using System.Collections.Generic;
using System.Linq;

namespace Sport_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardCommand = Console.ReadLine().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, Dictionary<string, decimal>>();
            while (cardCommand[0] != "end")
            {
                if (cardCommand[0] == "check")
                {
                    if (dict.ContainsKey(cardCommand[1]))
                    {
                        Console.WriteLine($"{cardCommand[1]} is available!");
                        cardCommand = Console.ReadLine().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{cardCommand[1]} is not available!");
                        cardCommand = Console.ReadLine().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }
                
                var card = cardCommand[0];
                var sport = cardCommand[1];
                var price = decimal.Parse(cardCommand[2]);

                if (!dict.ContainsKey(card))
                {
                    dict.Add(card, new Dictionary<string, decimal>());
                }
                
                if (!dict[card].ContainsKey(sport))
                {
                    dict[card].Add(sport, price);
                }
                else
                {
                    dict[card][sport] = price;
                }

                cardCommand = Console.ReadLine().Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count))
            {

                var cards = kvp.Key;
                Console.WriteLine($"{cards}:");


                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .OrderBy(x => x.Key)
                    .Select(a => $"  -{a.Key} - {a.Value:F2}")
                    ));

            }
        }
    }
}
