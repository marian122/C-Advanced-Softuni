using System;
using System.Linq;

namespace Problem_7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfNames = int.Parse(Console.ReadLine());

            var listOfNames = Console.ReadLine().Split();

            Func<string, bool> filter = n => n.Length <= numberOfNames;
            var left = listOfNames.Where(filter);
            Console.WriteLine(string.Join(Environment.NewLine, left));
            

        }
    }
}
