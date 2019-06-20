using System;

namespace DefiningClasses
{
   public class StartUp 
    {
       public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDifferenceBetweenTwoDates(firstDate, secondDate));
        }
    }
}
