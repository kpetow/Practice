using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncing_Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 3.0;
            double bounce = 0.66;
            double window = 1.5;

            int count = 0;

            if (h > 0 && bounce > 0 && bounce < 1 && window < h)
            {
                while (h > window)
                {
                    count++;
                    h = bounce * h;

                    if (h > window)
                    {
                        count++;
                    }

                    Console.WriteLine($"Count is {count}");
                    Console.WriteLine($"Height is {h}");
                }
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
