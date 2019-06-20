using _1._Generic_Box_of_String;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxList = new List<Box<string>>();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var namesAndCommand = Console.ReadLine();
                boxList.Add(new Box<string>(namesAndCommand));
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxList, indexes[0], indexes[1]);

            foreach (var box in boxList)
            {
                Console.WriteLine(box);
            }

        }
        static void Swap<T>(IList<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
