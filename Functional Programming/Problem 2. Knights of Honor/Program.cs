    using System;
using System.Linq;

namespace Problem_2._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesFromTheConsole = Console.ReadLine().Split();
            Action<string[]> actionForGettingMethod = Print;
            actionForGettingMethod(namesFromTheConsole);

        }
        public static void Print(string[] printNamesFromConsole)
        {
            Console.WriteLine(string.Join(Environment.NewLine, printNamesFromConsole.Select(name => $"Sir {name}")));
        }
    }
}
