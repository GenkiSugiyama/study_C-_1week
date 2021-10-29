using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample204
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, d;
            int c;

            a = 1.23;
            b = (double)12;
            c = (int)1.23;
            d = 10;

            Console.WriteLine("a={0} b={1} c={2} d={3}", a, b, c, d);
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} + {1} = {2}", a, c, a + c);

        }
    }
}
