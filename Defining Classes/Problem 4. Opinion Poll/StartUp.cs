using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int memberCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < memberCount; i++)
            {
                string[] members = Console.ReadLine().Split();

                string name = members[0];
                int age = int.Parse(members[1]);
                Person person = new Person(name, age);

                family.AddMember(person);

            }

            List<Person> membs = family.OverThirty().OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, membs));
        }
    }
}
