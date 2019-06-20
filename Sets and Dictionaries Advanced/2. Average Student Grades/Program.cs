using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<string, List<double>>();
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);

            }
            foreach (var pair in grades)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;
                var avg = studentGrades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {avg:f2})");
            }
            
        }
    }
}
