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
            Task task = Task.Run(() =>
            {
                HeavyMethod1();
            });
                        
            HeavyMethod2();
            Console.ReadLine();
        }

        static void HeavyMethod1()
        {
            Console.WriteLine("すごく重い処理その1(´・ω・｀)はじまり");
            Thread.Sleep(5000);
            Console.WriteLine("すごく重い処理その1(´・ω・｀)おわり");
        }

        static void HeavyMethod2()
        {
            Console.WriteLine("すごく重い処理その2(´・ω・｀)はじまり");
            Thread.Sleep(3000);
            Console.WriteLine("すごく重い処理その2(´・ω・｀)おわり");
        }
    }
}
