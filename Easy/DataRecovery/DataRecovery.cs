using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Easy.DataRecovery
{
    class DataRecovery
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;

                    Dictionary<int, int> indexes = new Dictionary<int, int>();

                    int index = 1;
                    int lostindex = 0;
                    string[] splittedline = line.Split(';');

                    string[] words = splittedline[0].Split(' ');
                    indexes = splittedline[1].Split(' ').ToDictionary(item => Int32.Parse(item), item => index++);
                    index = 1;
                    lostindex = words.Sum(x => index++) - indexes.Sum(x => x.Key);
                    indexes.Add(lostindex, indexes.Count + 1);

                    foreach (KeyValuePair<int, int> kv in indexes.OrderBy(i => i.Key))
                    {
                        Console.Write(words[kv.Value - 1] + " ");
                    }
                    //testing a commit
                    Console.WriteLine();
                }
        }
    }
}
