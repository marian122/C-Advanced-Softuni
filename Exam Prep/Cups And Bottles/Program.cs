using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cups_And_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupCapacity = Console.ReadLine().Split().Select(int.Parse);
            var filledBottles = Console.ReadLine().Split().Select(int.Parse);

            var bottleStack = new Stack<int>(filledBottles);
            var cupStack = new Queue<int>(cupCapacity);

            var wastedWater = 0;
            while (bottleStack.Any() && cupStack.Any())
            {
                if (bottleStack.Peek() >= cupStack.Peek())
                {
                    wastedWater += bottleStack.Pop() - cupStack.Dequeue();
                }
                else
                {
                    var dequed = cupStack.Dequeue() - bottleStack.Pop();
                    cupStack = new Queue<int>(cupStack.Reverse());
                    cupStack.Enqueue(dequed);
                    cupStack = new Queue<int>(cupStack.Reverse());

                }

            }

            if (bottleStack.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottleStack)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (cupStack.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupStack)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }

        }
    }
}
