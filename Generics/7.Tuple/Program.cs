using System;

namespace _7.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Tuple<string, string> coolTuple = new Tuple<string, string>(input[0] + " " + input[1], input[2]);
            Console.WriteLine(coolTuple);

            input = Console.ReadLine().Split();
            Tuple<string, int> secondCoolTuple = new Tuple<string, int>(input[0], int.Parse(input[1]));
            Console.WriteLine(secondCoolTuple);

            input = Console.ReadLine().Split();
            Tuple<int, double> thirdCoolTuple = new Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));
            Console.WriteLine(thirdCoolTuple);
        }
    }
}
