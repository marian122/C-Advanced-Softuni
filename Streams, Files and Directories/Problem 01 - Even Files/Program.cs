using System;
using System.IO;
using System.Text;

namespace Problem_01___Even_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int counter = 0;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (line != null)
                    {
                        var output = line.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?','@');
                        string[] words = output.Split(' ');
                        Array.Reverse(words);
                        output = String.Join(" ", words);
                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(output);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }       
    }
}
