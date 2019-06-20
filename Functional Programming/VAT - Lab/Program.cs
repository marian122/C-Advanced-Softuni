using System;
using System.Linq;

namespace VAT___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbs = Console.ReadLine().
                Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var vat = 1.2;
            foreach (var item in numbs)
            {
                var sum = item * vat;
                Console.WriteLine(string.Join("", $"{sum:f2}"));
            }
            //Console.WriteLine(string.Join(Environment.NewLine, numbs.Select(p => $"{p * 1.20:F2}")));
        }
    }
}
