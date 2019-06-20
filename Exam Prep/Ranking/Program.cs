using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(":");


            var entryDictionary = new Dictionary<string, string>();

            while (firstInput[0] != "end of contests")
            {
                var contest = firstInput[0];
                var password = firstInput[1];
                if (!entryDictionary.ContainsKey(contest))
                {
                    entryDictionary.Add(contest, password);
                }
                firstInput = Console.ReadLine().Split(":");
            }

            string[] secondInput = Console.ReadLine().Split("=>");
            var secondDictionary = new Dictionary<string, Dictionary<string, int>>();
            while (secondInput[0] != "end of submissions")
            {
                var contest = secondInput[0];
                var password = secondInput[1];
                var studentName = secondInput[2];
                var points = int.Parse(secondInput[3]);

                if (entryDictionary.ContainsKey(contest) && entryDictionary[contest] == password)
                {
                    if (!secondDictionary.ContainsKey(studentName))
                    {
                        secondDictionary.Add(studentName, new Dictionary<string, int>());
                    }
                    if (!secondDictionary[studentName].ContainsKey(contest))
                    {
                        secondDictionary[studentName].Add(contest, points);
                    }
                    else if (secondDictionary[studentName][contest] < points)
                    {

                        secondDictionary[studentName][contest] = points;

                    }
                }
                 
                secondInput = Console.ReadLine().Split("=>");
            }

            var maxPoints = 0;
            var bestCandidate = "";
            foreach (var candidate in secondDictionary)
            {
                var currentPoints = candidate.Value.Values.Sum();
                if (currentPoints > maxPoints)
                {
                    maxPoints = currentPoints;
                    bestCandidate = candidate.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var kvp in secondDictionary.OrderBy(x => x.Key))
            {
                
                Console.WriteLine($"{kvp.Key}");

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
