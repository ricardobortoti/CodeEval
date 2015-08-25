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

                for (int i = size - 2; i >= 0; i--)
                {
                    matrix[size - 1, i] += matrix[size - 1, i + 1];
                    matrix[i, size - 1] += matrix[i + 1, size - 1];
                }

                for (int i = size - 2; i >= 0; i--)
                {
                    for (int j = size - 2; j >= 0; j--)
                    {
                        matrix[i, j] += Math.Min(matrix[i + 1, j], matrix[i, j + 1]);
                    }
                }
                Console.WriteLine("{0}", matrix[0, 0]);   
            }
        }
    }
}
