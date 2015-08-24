using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Easy.ReverseWords
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] words = line.Split(' ');

                    for (int i = 1; i <= words.Length; i++)
                    {
                        Console.Write(words[words.Length - i] + " ");
                    }

                    if (null == line)
                        continue;

                    Console.WriteLine();
                }
        }
    }
}