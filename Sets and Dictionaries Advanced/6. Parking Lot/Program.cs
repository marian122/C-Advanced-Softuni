using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carNum = new HashSet<string>();
            var line = Console.ReadLine().Split(", ").ToArray();
            while (line[0] != "END")
            {
                if (line[0] == "IN")
                {
                    carNum.Add(line[1]);
                }
                else if(line[0] == "OUT")
                {
                    carNum.Remove(line[1]);
                }
                line = Console.ReadLine().Split(", ").ToArray();
            }
            if (carNum.Any())
            {
                foreach (var item in carNum)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
