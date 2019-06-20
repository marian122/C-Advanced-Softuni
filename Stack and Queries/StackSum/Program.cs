using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(input);
            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                
                var tokens = commandInfo.Split();
                var command = tokens[0].ToLower();
                
                if (command == "add")
                {
                    
                    var countOfAddedNums = int.Parse(tokens[1]);

                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }

                else if (command == "remove")
                {
                    var countOfRemovedNums = int.Parse(tokens[1]);
                    if (numbers.Count >= countOfRemovedNums)
                    {
                        for (int i = 0; i < countOfRemovedNums; i++)
                        {
                            numbers.Pop();
                        }
                        
                    }
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}

