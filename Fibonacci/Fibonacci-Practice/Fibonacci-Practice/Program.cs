using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //desired amount of Fibonacci numbers
            int length;

            //Starting Fibonacci numbers
            int f1 = 0, f2 = 1, f3;

            //User input
            Console.Write("Enter how many Fibonacci numbers you want:");
            length = int.Parse(Console.ReadLine());

            //Printing first two values
            Console.Write(f1 + " " + f2 + " ");

            //Fibonacci Sequence = Xn = Xn-1 + Xn-2
            for(int i = 2; i < length; ++i)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
