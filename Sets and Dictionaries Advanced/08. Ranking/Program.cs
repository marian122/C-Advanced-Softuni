using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAndPassInput = Console.ReadLine();
            var contestPass = new Dictionary<string, string>();
            while (nameAndPassInput != "end of contests")
            {
                string[] tokens = nameAndPassInput.Split(":");
                string contest = tokens[0];
                string password = tokens[1];

                contestPass.Add(contest, password);
                nameAndPassInput = Console.ReadLine();
            }
            string courseInfo = Console.ReadLine();
            var submissions = new SortedDictionary<string, Dictionary<string, int>>();

            while (courseInfo != "end of submissions")
            {
                string[] tokens = courseInfo.Split("=>");
                string course = tokens[0];
                string password = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contestPass.ContainsKey(course) ||
                    contestPass[course] != password)
                {
                    courseInfo = Console.ReadLine();
                    continue;
                }
                if (!submissions.ContainsKey(name))
                {
                    submissions[name] = new Dictionary<string, int> {{ course, points }};
                }
                if (!submissions[name].ContainsKey(course))
                {
                    submissions[name].Add(course, points);
                }
                if (submissions[name][course] < points)
                {
                    submissions[name][course] = points;
                }
                courseInfo = Console.ReadLine();
            }

            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in submissions)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestCandidate = usernameTotalPoints
                .Keys
                .Max();
            int bestPoints = usernameTotalPoints
                .Values
                .Max();
          
            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }

            

            Console.WriteLine("Ranking:");
            foreach (var kvp in submissions)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .OrderByDescending(x => x.Value)
                    .Select(a => $"#  {a.Key} -> {a.Value}")
                    ));
            }
        }
    }
}
