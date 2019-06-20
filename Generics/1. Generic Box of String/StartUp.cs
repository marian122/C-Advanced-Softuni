using System;

namespace _1._Generic_Box_of_String
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                var value = Console.ReadLine();
                Box<string> box = new Box<string>(value);

                Console.WriteLine(box);

            }
        }        
    }
}
