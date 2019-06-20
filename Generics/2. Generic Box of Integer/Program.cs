using _1._Generic_Box_of_String;
using System;

namespace _2._Generic_Box_of_Integer
{
    public class Program
    { 
        static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                var value = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(value);

                Console.WriteLine(box);

            }
        }
    }
}
 