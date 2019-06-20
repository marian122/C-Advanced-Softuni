using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Loger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            var data = Console.ReadLine();
            while (data != "Statistics")
            {
                string[] input = data.Split();

                var vlogger = input[0];
                var command = input[1];

                if (command == "joined")
                {
                    if (!dict.ContainsKey(vlogger))
                    {
                        dict.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        dict[vlogger].Add("followers", new HashSet<string>());
                        dict[vlogger].Add("following", new HashSet<string>());
                       
                    }

                }
                else if (command == "followed")
                {
                    var member = input[2];

                    if (vlogger != member && dict.ContainsKey(vlogger) &&  dict.ContainsKey(member))
                    {
                        dict[vlogger]["following"].Add(member);
                        dict[member]["followers"].Add(vlogger);
                    }
                }
                data = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            int number = 1;

            foreach (var vlogger in dict.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }


        }
    }
}

