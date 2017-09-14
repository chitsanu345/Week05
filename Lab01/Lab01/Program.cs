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
            int point = 68;
            if (point < 50)
                Console.WriteLine("Grade F");
            else if (point < 60)
                Console.WriteLine("Grade D");
            else if (point < 70)
                Console.WriteLine("Grade C");
            else if (point < 80)
                Console.WriteLine("Grade B");
            else
                Console.WriteLine("Grade A");
        }
    }
}
