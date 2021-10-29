using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem205_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力：");
            string str = Console.ReadLine();
            if ( str == "Hello")
            {
                Console.WriteLine("Helloが入力されました");
            }
            else
            {
                Console.WriteLine("Helloと入力してください");
            }

            // 比較演算子==や通常のEquals()メソッドだと大文字小文字を区別して比較を行う
            if (str.Equals("Hello"))
            {
                Console.WriteLine("Helloが入力されました");
            }
            else
            {
                Console.WriteLine("Helloと入力してください");
            }
            // EqualsメソッドにStringComparison.OrdinalIgnoreCaseオプションを使用すると大文字小文字の区別なく比較を行うことができる
            if (str.Equals("Hello", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Helloが入力されました");
            }
            else
            {
                Console.WriteLine("Helloと入力してください");
            }
        }
    }
}
