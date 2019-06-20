using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLightDuration = int.Parse(Console.ReadLine());
            var freeWindowDuration = int.Parse(Console.ReadLine());

            var totalPassedCars = 0;

            Queue<string> cars = new Queue<string>();

            string passingCar = null;

            string carsCommand;

            while ((carsCommand = Console.ReadLine()) != "END")
            {
                if (carsCommand != "green")
                {
                    cars.Enqueue(carsCommand);
                    continue;
                }

                int currentGreenLight = greenLightDuration;

                while (currentGreenLight > 0 && cars.Any())
                {
                    passingCar = cars.Dequeue();
                    currentGreenLight -= passingCar.Length;
                    totalPassedCars++;
                }

                int freeWindowLeft = freeWindowDuration + currentGreenLight ;

                if (freeWindowLeft < 0)
                {
                    int symbolsThatDidntPass = Math.Abs(freeWindowLeft);
                    int indexOfHitSymbol = passingCar.Length - symbolsThatDidntPass;
                    char symbolHit = passingCar[indexOfHitSymbol];
                    Crash(passingCar, symbolHit);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalPassedCars} total cars passed the crossroads.");
        }

        private static void Crash(string passingCar, char symbolHit)
        {
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{passingCar} was hit at {symbolHit}.");
            Environment.Exit(0);
        }
    }
}
