using System;
using System.Collections.Generic;
using System.Linq;

namespace Tagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var tagsCount = new Dictionary<string, int>();
            var totalLikes = new Dictionary<string, int>();
            while (input[0] != "end")
            {
                string username = input[0];
                if (input[0] == "ban")
                {
                    dict.Remove(input[1]);
                    input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    continue;
                }
                string tag = input[1];
                int likes = int.Parse(input[2]);

                if (!dict.ContainsKey(username))
                {
                    dict.Add(username, new Dictionary<string, int>());
                    tagsCount[username] = 0;
                    totalLikes[username] = 0;
                }
                if (!dict[username].ContainsKey(tag))
                {
                    dict[username].Add(tag, likes);
                    tagsCount[username]++;
                }
                else
                {
                    dict[username][tag] = likes;
                }
                totalLikes[username] += likes;
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var kvp in dict.OrderByDescending(x => totalLikes[x.Key]).ThenBy(x => tagsCount[x.Key]))
            {

                var username = kvp.Key;
                Console.WriteLine($"{username}");


                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .Select(a => $"- {a.Key}: {a.Value}")
                    ));


            }
        }
    }
}
