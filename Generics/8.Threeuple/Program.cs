using System;

namespace _8.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Threeuple<string, string, string> coolThreeuple = new Threeuple<string, string, string>(input[0] + " " + input[1], input[2], input[3]);
            Console.WriteLine(coolThreeuple);

            input = Console.ReadLine().Split();
            bool isDrunk = input[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> secondCoolThreeuple = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), isDrunk);
            Console.WriteLine(secondCoolThreeuple);

            input = Console.ReadLine().Split();
            Threeuple<string, double, string> thirdCoolThreeuple = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
            Console.WriteLine(thirdCoolThreeuple);
        }
    }
}
