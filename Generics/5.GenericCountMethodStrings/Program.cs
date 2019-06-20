using _1._Generic_Box_of_String;
using System;
using System.Collections.Generic;

namespace _5.GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxList = new List<Box<string>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string value = Console.ReadLine();

                boxList.Add(new Box<string>(value));
            }
            string element = Console.ReadLine();

            Console.WriteLine(CountGreater(boxList, element));
        }

        static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
        where T : IComparable<T>
        {
            int count = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
