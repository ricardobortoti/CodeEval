using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumPathSum
{
    class MinimumPathSum
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {

                int size =  Convert.ToInt32(reader.ReadLine());

                if (null == size)
                  continue;

                int[,] matrix = new int[size, size];

                for (int i = 0; i < size; i ++)
                {
                    string line = reader.ReadLine();
                    for(int j = 0; j < size; j++)
                    {
                        matrix[i,j] = Convert.ToInt32(line.Split(',')[j]);
                    }
                }

                int sum = 0;

                for(int i = 0; i < size; i++)
                {

                }
                
            }
            Console.ReadKey();
        }
    }
}
