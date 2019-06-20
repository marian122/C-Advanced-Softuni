using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, Dictionary<string, int>>();
            var tagsCount = new Dictionary<string, int>();
            var totalLikes = new Dictionary<string, int>();

            var username = input[0];
            var tags = input[1];
            var likes = int.Parse(input[2]);

            while (input[0] != "end")
            {
                if (input.Length == 3)
                {
                    username = input[0];
                    tags = input[1];
                    likes = int.Parse(input[2]);

                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, new Dictionary<string, int>());
                        totalLikes[username] = 0;
                        tagsCount[username] = 0;
                    }

                    if (!dict[username].ContainsKey(tags))
                    {
                        dict[username].Add(tags, likes);
                        tagsCount[username]++;
                    }
                    else
                    {
                        dict[username][tags] = likes;

                    }

                    totalLikes[username] += likes;
                }
                if (input.Length == 2)
                {
                    var ban = input[0];
                    var itemToBan = input[1];

                    if (ban == "ban")
                    {
                        dict.Remove(itemToBan);
                    }
                }

                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }

            foreach (var item in dict.OrderByDescending(x => totalLikes[x.Key]).ThenBy(x => tagsCount[x.Key]))
            {
                Console.WriteLine($"{item.Key}");

                Console.WriteLine(string.Join(Environment.NewLine, item.Value
                    .Select(a => $"- {a.Key}: {a.Value}")
                    ));
            }

        }
    }
}
