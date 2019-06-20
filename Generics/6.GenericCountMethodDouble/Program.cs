namespace _6.GenericCountMethodDouble
{
    using _1._Generic_Box_of_String;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> boxList = new List<Box<double>>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var value = double.Parse(Console.ReadLine());

                boxList.Add(new Box<double>(value));
            }
            var element = double.Parse(Console.ReadLine());
            Console.WriteLine(CountGreater(boxList, element));
        }

        static double CountGreater<T>(IEnumerable<Box<T>> collection, T element)
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
