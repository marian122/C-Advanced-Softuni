using System;
using System.Linq;

namespace RecursiveReversingArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            PrintInReverseOrder(arr, arr.Length - 1);
            Console.WriteLine();
        }

        private static void PrintInReverseOrder(int[] arr, int index)
        {
            if (index == -1)
            {
                return;
            }

            Console.Write(arr[index] + " ");

            PrintInReverseOrder(arr, index - 1);
        }

    }
}
