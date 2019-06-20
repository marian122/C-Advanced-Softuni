using System;
using System.IO;

namespace Problem_02___Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int counter = 1;
                
                string line = reader.ReadLine();
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    
                    while (line != null)
                    {
                        var charCount = 0;
                        int signCount = 0;
                        foreach (var @char in line)
                        {
                            if (char.IsLetter(@char))
                            {
                                charCount++;
                            }
                            else if (char.IsPunctuation(@char))
                            {
                                signCount++;
                            }
                        }
                        
                        writer.WriteLine($"Line {counter}: {line} ({charCount})({signCount})");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
