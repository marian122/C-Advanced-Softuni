using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age___Lab
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var currPeople = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var person = new Person
                {
                    Name = currPeople[0],
                    Age = int.Parse(currPeople[1])
                };

                people.Add(person);
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filtered;

            if (condition == "older")
            {
                filtered = x => x.Age >= age;
            }
            else
            {
                filtered = x => x.Age < age;
            }
            var format = Console.ReadLine();
            Func<Person, string> printFunc;

            if (format == "name age")
            {
                printFunc = x => $"{x.Name} - {x.Age}";
            }
            else
            {
                printFunc = x => $"{x.Name}";
            }

            people.Where(filtered)
                .Select(printFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
