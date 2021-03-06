﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StepwiseWords
{
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

                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > words[longestwordindex].Length)
                    {
                        longestwordindex = i;
                    }
                }

                for (int i = 0; i < words[longestwordindex].Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(words[longestwordindex][i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
    }
}