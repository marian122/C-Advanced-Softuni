using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(inputValues);

            int racks = 1;
            int sum = 0;

            while (stack.Any())
            {
                if (sum + stack.Peek() <= rackCapacity)
                {
                    sum += stack.Pop();

                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
