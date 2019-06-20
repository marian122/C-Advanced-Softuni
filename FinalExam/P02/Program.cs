namespace P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
        {
            static void Main(string[] args)
            {
                var firstInput = new Dictionary<string, List<int>>();
                int maxCapacity = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                input = input.Reverse().ToArray();
                foreach (var item in input)
                {

                    if (item.All(Char.IsLetter))
                    {
                        firstInput.Add(item, new List<int>());

                    }
                    else
                    {
                        int reservation = int.Parse(item);
                        if (firstInput.Any() && maxCapacity - firstInput[firstInput.First().Key].Sum() >= reservation)
                        {
                            firstInput[firstInput.First().Key].Add(reservation);
                        }
                        else if (firstInput.Any())
                        {
                            Console.WriteLine($"{firstInput.First().Key} -> {string.Join(", ", firstInput[firstInput.First().Key])}");
                            firstInput.Remove(firstInput.First().Key);
                            if (firstInput.Any() && maxCapacity - firstInput[firstInput.First().Key].Sum() >= reservation)
                            {
                                firstInput[firstInput.First().Key].Add(reservation);
                            }
                        }
                    }
                }
            }
        }
    }
    

