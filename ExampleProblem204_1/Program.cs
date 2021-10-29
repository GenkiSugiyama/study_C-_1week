using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem204_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("月（1～12）を入力してください：");
            int month = int.Parse(Console.ReadLine());
            string day = "";
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = "30";
                    break;
                case 2:
                    day = "28か29";
                    break;
                default:
                    Console.WriteLine("適切な値を入力してください");
                    return;
            }
            Console.WriteLine("{0}月の長さは{1}日です。", month, day);

        }
    }
}
