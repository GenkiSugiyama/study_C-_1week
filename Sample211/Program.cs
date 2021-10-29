using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample211
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample209の書き換え
            // C#のswitch文は原則フォロースルー（caseを跨いだ処理の実行）が禁止されている
            Console.Write("1から3の整数を入力：");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("不適切な値です");
                    break;
            }

            // 複数の条件に対して同じ処理を行いたい場合はつぎのように記述する。
            // 同じ処理を実行したいcaseを連続並べてで記述する。
            Console.Write("1から6のサイコロの目を入力：");
            int num2 = int.Parse(Console.ReadLine());
            switch (num2)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("半です");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("丁です");
                    break;
                default:
                    Console.WriteLine("範囲外の数値です");
                    break;
            }
        }
    }
}
