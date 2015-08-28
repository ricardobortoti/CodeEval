using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        const int griddimension = 10;

        static void Main(string[] args)
        {
            int[,] grid = new int[griddimension, griddimension];
            int[,] newgrid = new int[griddimension, griddimension];

            using (StreamReader reader = File.OpenText("C:\\TESTE.TXT"))
            {
                int line = 0;

                string linetext;

                while (!reader.EndOfStream)
                {
                    linetext = reader.ReadLine();

                    for (int col = 0; col < griddimension; col++)
                    {
                        grid[line, col] = linetext[col] == '.' ? 0 : 1;
                    }

                    line++;
                }

            }
            Console.ReadKey();
        }
    }
}
