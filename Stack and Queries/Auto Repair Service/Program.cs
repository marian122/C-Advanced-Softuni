using System;
using System.Collections.Generic;

namespace Auto_Repair_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var vehicles = Console.ReadLine().Split();
            Queue<string> carList = new Queue<string>(vehicles);
            Stack<string> servedCars = new Stack<string>();

            while (true)
            {
                var command = Console.ReadLine().Split('-');
                if (command[0] == "Service")
                {
                    if (carList.Count > 0)
                    {
                        servedCars.Push(carList.Peek());
                        Console.WriteLine($"Vehicle {carList.Dequeue()} got served.");
                    }
                   
                }
                else if (command[0] == "CarInfo")
                {
                    var currentCar = command[1];
                    if (carList.Contains(currentCar))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command[0] == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));

                }
                else if (command[0] == "End")
                {
                    if (carList.Count > 0)
                    {
                        Console.WriteLine($"Vehicles for service: {string.Join(", ", carList)}");
                    }
                    Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
                    return;
                }


            }
        }
    }
}
