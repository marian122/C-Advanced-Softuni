using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftSocks = Console.ReadLine().Split().Select(int.Parse).ToList();
            var rightSocks = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> socksLeft = new Stack<int>(leftSocks);
            Queue<int> socksRight = new Queue<int>(rightSocks);

            var pairs = new List<int>();

            while (socksLeft.Any() && socksRight.Any())
            {
                if (socksLeft.Peek() < socksRight.Peek())
                {
                    socksLeft.Pop();
                }

                else if (socksLeft.Peek() == socksRight.Peek())
                {
                    socksRight.Dequeue();
                    int currentLeftSock = socksLeft.Pop();
                    currentLeftSock++;
                    socksLeft.Push(currentLeftSock);
                }


                else if (socksLeft.Peek() > socksRight.Peek())
                {
                    int pair = socksLeft.Pop() + socksRight.Dequeue();
                    pairs.Add(pair);
                }
            }
            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
