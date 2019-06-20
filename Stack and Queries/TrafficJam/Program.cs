using System;
using System.Collections.Generic;


namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCarPasses = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            var totalPassed = 0;
            while (input != "end")
            {

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    var carPassing = Math.Min(numCarPasses, cars.Count);
                    for (int i = 0; i < carPassing; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalPassed++;
                    }
                }
                input = Console.ReadLine();
            }
                Console.WriteLine($"{totalPassed} cars passed the crossroads.");
        }
    }
}
