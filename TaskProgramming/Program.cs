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
            // Prompt the user for the target number
            Console.WriteLine("Please enter the target number");
            // Read from the console and store it in target variable
            int target = Convert.ToInt32(Console.ReadLine());
            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            Number number = new Number(target);
            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();

            Console.ReadLine();
        }     
    }

    class Number
    {
        int _target;
        // When an instance is created, the target number needs to be specified
        public Number(int target)
        {
            // The targer number is then stored in the class private variable _target
            this._target = target;
        }
        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
