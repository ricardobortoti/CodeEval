using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moderate.NumberPairs
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;

                    int[] numbers = line.Split(';')[0].Split(',').Select(s => (int)Convert.ToInt32(s, 10)).ToArray();
                    int size = Convert.ToInt32(line.Split(';')[1]);
                    int semicolon = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int numbersi = numbers[i];

                        for (int j = i + 1; j < numbers.Length; j++)
                        {

                            if (numbersi + numbers[j] == size)
                            {
                                Console.Write("{0}{1},{2}", semicolon == 0 ? "" : ";", numbersi, numbers[j]);
                                semicolon = 1;
                                break;
                            }
                        }
                        if ((semicolon == 0) && (i == numbers.Length - 1))
                        {
                            Console.Write("NULL");
                        }
                    }
                    Console.WriteLine("");

                }
        }
    }
}
