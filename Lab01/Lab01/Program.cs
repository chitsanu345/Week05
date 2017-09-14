using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0, 2} x 2 = {1, 2}", i, i * 2);
            }

        }
    }
}
