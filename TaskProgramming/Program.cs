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
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();
            // Create an instance of ParameterizedThreadStart delegate
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            // Pass the traget number to the start function, which
            // will then be passed automatically to PrintNumbers() function
            //Thread thread = new Thread(Number.PrintNumbers); //★このようにも書けます。CompilerはConvertしてくれますから
            T1.Start(target);
        }     
    }

    class Number
    {
        public static void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
