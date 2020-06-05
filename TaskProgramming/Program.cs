using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1の整数を返すHeavyMethod1のTaskを生成します。
            Task<int> task1 = Task.Run(() => {
                return HeavyMethod1();
            });

            // 2の整数を返すHeavyMethod2のTaskを生成します。
            Task<int> task2 = Task.Run(() => {
                return HeavyMethod2();
            });

            // WhenAllの引数に、先程生成したTaskを入れると、HeavyMethod1、HeavyMethod2が終了するまで
            // 次のコードに進みません。つまり待機します。
            Task.WhenAll(task1, task2);

            Console.WriteLine(task1.Result + task2.Result);

            Console.ReadLine();
        }

        static int HeavyMethod1()
        {
            Console.WriteLine("すごく重い処理その1(´・ω・｀)はじまり");
            Thread.Sleep(2000);
            Console.WriteLine("すごく重い処理その1(´・ω・｀)おわり");

            return 1;
        }

        static int HeavyMethod2()
        {
            Console.WriteLine("すごく重い処理その2(´・ω・｀)はじまり");
            Thread.Sleep(2000);
            Console.WriteLine("すごく重い処理その2(´・ω・｀)おわり");

            return 2;
        }
    }
}
