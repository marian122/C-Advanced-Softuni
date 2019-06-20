using System;

namespace Problem_1._Action_Point
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
            Console.WriteLine(string.Join(Environment.NewLine, printNamesFromConsole));
        }
    }
}
