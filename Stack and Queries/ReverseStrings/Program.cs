using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var someStack = new Stack<char>();
            
            foreach (var item in input)
            {
                someStack.Push(item);

            }

            while (someStack.Count != 0)
            {
                Console.Write(someStack.Pop());

            }
            Console.WriteLine();
        }
    }
}
