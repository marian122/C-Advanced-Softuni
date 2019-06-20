using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var setOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Console.WriteLine(setOfNumbers.Min());
            

        }
    }
}
