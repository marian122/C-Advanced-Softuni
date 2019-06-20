using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToList();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToList();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            var counter = 0;

            Stack<int> bulletStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
            var originalBarrelSize = gunBarrelSize;
            while (bulletStack.Count > 0 || locksQueue.Count > 0)
            {
                if (originalBarrelSize > 0)
                {
                    counter++;
                    originalBarrelSize--;
                    if (bulletStack.Peek() <= locksQueue.Peek())
                    {
                        Console.WriteLine("Bang!");
                        locksQueue.Dequeue();
                        bulletStack.Pop();

                    }

                    else if (bulletStack.Peek() > locksQueue.Peek())
                    {
                        Console.WriteLine("Ping!");
                        bulletStack.Pop();

                    }

                }

                if (originalBarrelSize == 0 && bulletStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    originalBarrelSize += gunBarrelSize;
                }

                if (locksQueue.Count <= 0)
                {
                    var bulletsLeft = bulletStack.Count;
                    var moneyEarned = counter * priceOfBullet;
                    Console.WriteLine($"{bulletsLeft} bullets left. Earned ${valueOfIntelligence - moneyEarned}");
                    break;
                }
                else if (bulletStack.Count <= 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
                    break;
                }

            }

        }
    }
}
