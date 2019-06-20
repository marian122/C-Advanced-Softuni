using System;
using System.Collections.Generic;
using System.Linq;

namespace Exel_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var namesCol = Console.ReadLine()
                 .Split(", ")
                 .ToList();

            List<List<string>> matrix = new List<List<string>>();

            for (int i = 1; i < n; i++)
            {
                matrix.Add(Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList());
            }

            List<List<string>> filtered = new List<List<string>>();

            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            switch (command[0])
            {

                case "filter":
                    {
                        int index = namesCol.IndexOf(command[1]);

                        foreach (var col in matrix)
                        {

                            if (col[index] == command[2])
                            {

                                filtered.Add(col);
                            }

                        }

                    }
                    break;
                case "sort":
                    {

                        int index = namesCol.IndexOf(command[1]);

                        for (int i = 0; i < matrix.Count; i++)
                        {

                            if (i < matrix.Count - 1)
                            {
                                if (string.Compare(matrix[i][index], matrix[i + 1][index]) > 0)
                                {

                                    var temp = matrix[i];
                                    matrix[i] = matrix[i + 1];
                                    matrix[i + 1] = temp;


                                }

                            }

                        }


                    }
                    break;
                case "hide":
                    {
                        int index = namesCol.IndexOf(command[1]);

                        namesCol.RemoveAt(index);

                        foreach (var list in matrix)
                        {
                            list.RemoveAt(index);

                        }

                    }
                    break;

            }


            Console.WriteLine(string.Join(" | ", namesCol));


            if (command[0] == "filter")
            {
                foreach (var item in filtered)
                {

                    Console.WriteLine(string.Join(" | ", item));
                }

            }
            else
            {

                foreach (var item in matrix)
                {

                    Console.WriteLine(string.Join(" | ", item));
                }

            }
            }
    }
}
