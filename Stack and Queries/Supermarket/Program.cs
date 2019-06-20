using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Queue<string> people = new Queue<string>();
            
            while (input != "End")
            {
                
                if (input != "Paid")
                {
                    people.Enqueue(input);
                   
                }
                else
                {
                    var counter = people.Count;
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                
                input = Console.ReadLine();

            }
            
            Console.WriteLine($"{people.Count} people remaining.");

           
        }
    }
}
