using System;
using System.Linq;

namespace Problem_6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var divisible = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % divisible != 0;
            var remaining = listNumbers.Reverse().Where(filter);
            
            Console.WriteLine(string.Join(" ", remaining));
        }
    }
}
