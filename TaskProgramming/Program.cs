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
            string result = "";
            Thread thread = new Thread(new ThreadStart(() =>
            {
                result = HeavyMethod();
            }));

            thread.Start();
            thread.Join();

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static string HeavyMethod()
        {
            Console.WriteLine("すごく重い処理その1(´・ω・｀)はじまり");
            Thread.Sleep(3000);
            Console.WriteLine("すごく重い処理その1(´・ω・｀)おわり");

            return "hoge";
        }
    }
}
