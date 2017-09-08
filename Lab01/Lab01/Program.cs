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
            int a = 10;
            int b = 20;
            int c;
            try
            {
                c = div(a, b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException");
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(e.Message);
            }
        }
        private static int div(int a, int b)
        {
            throw new FileNotFoundException();

        }
    }
}
