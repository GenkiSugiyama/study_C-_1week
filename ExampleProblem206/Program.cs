using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("H2Oの温度：");
            double temp = int.Parse(Console.ReadLine());
            if (temp <= 0.0)
            {
                Console.WriteLine("個体");
            }
            else if (temp < 100)
            {
                Console.WriteLine("液体");
            }
            else
            {
                Console.WriteLine("気体");
            }
        }
    }
}
