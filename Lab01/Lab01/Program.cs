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
            Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
            Console.Write("Please enter your selection: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int cost = 0;
            switch (n)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost += 25;
                    goto case 1;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} Bath.", cost);
            }
            Console.WriteLine("Thank you for your business.");

            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
