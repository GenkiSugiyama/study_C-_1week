using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample208
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);
            if (a > 0)
            {
                Console.WriteLine(a + "は正の整数です。");
            } else
            {
                Console.WriteLine(a + "は正の整数ではありません。");
            }
        }
    }
}
