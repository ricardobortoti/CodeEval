using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplications
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                    Console.Write("{0,4}", Convert.ToInt32(i * j));
                Console.WriteLine();
            }
        }
    }
}
