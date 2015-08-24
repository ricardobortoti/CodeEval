using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StepwiseWordsRecursive
{
    static void StepwiseThis(string word, int index)
    {
        if (!(word.Length == index))
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write("*");
            }
            Console.Write(word[index]);
            Console.Write(" ");

            StepwiseThis(word, index + 1);
        }
        else
        {
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (null == line)
                    continue;

                string[] words = line.Split(' ');
                int longestwordindex = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > words[longestwordindex].Length)
                    {
                        longestwordindex = i;
                    }
                }

                /*Recursive Programming Just For Fun :] */
                StepwiseThis(words[longestwordindex], 0);
            }
        Console.Read();
    }
}