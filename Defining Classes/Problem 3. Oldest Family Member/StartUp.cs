using System;

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
            Person oldestMemer = family.GetOldestMember();
            Console.WriteLine(oldestMemer);
        }
    }
}
