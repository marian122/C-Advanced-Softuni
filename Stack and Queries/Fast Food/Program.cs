using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(sequence.Reverse());
           
            var biggestOrder = stack.Max();

            while (stack.Any())
            {
                if (input <= 0)
                {
                    break;
                }
                if (input - stack.Peek() >= 0)
                {
                    input -= stack.Pop();
                }
                else
                {
                    break;
                }
                 

            }
                if (stack.Count == 0)
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine("Orders complete");
                    
                }
                else
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine($"Orders left: {string.Join(" ", stack)}");
                }
            
        }
    }
}
