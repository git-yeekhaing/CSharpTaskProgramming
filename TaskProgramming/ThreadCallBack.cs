using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static TaskProgramming.ThreadCallBackMain;

namespace TaskProgramming
{
    class ThreadCallBackMain
    {
        public delegate void PrintCallback(int result);

        public static void main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            PrintCallback objcall = new PrintCallback(PrintResult);
            Compute objNum = new Compute(input, objcall);
            Thread thread = new Thread(new ThreadStart(objNum.ComputeNumber));
            thread.Start();
        }

        public static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }

    class Compute
    {
        int InputNum;

        PrintCallback _callback;

        public Compute(int num, PrintCallback obj)
        {
            InputNum = num;
            _callback = obj;
        }


        public void ComputeNumber()
        {
            InputNum += 10;
            if (_callback != null)
            {
                _callback(InputNum);
            }
        }
    }
}
