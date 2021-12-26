using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] walk = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };
            int x = 0;
            int y = 0;
            int count = 0;

            if (walk.Length != 10)
            {
                Console.WriteLine("false");
                Console.ReadKey();
            }

            for (count = 0; count < 10; count++)
            {
                if(count < walk.Length)
                {
                    switch (walk[count])
                    {
                        case "n": 
                            y += 1;
                            Console.WriteLine("north 1");
                            break;
                        case "s": 
                            y -= 1;
                            Console.WriteLine("south 1");
                            break;
                        case "e":
                            x += 1;
                            Console.WriteLine("east 1");
                            break;
                        case "w": 
                            x -= 1;
                            Console.WriteLine("west 1");
                            break;
                    }
                }
                else
                {
                    count += 0;
                }
                Console.WriteLine($"Count is currently {count}.");
                Console.WriteLine($"Current Coordinates: ({x}, {y})");
                Console.WriteLine(" ");
            }
            if( x == 0 && y == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}