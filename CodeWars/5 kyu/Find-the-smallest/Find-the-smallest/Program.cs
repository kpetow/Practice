using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine($"[{Smallest(n)[0]}, {Smallest(n)[1]}, {Smallest(n)[2]}]");
        }

        public static long[] Smallest(long n)
        {
            var smallest = new long[] {n, 0, 0}; //setting up the output array
            var str = n.ToString(); //converting the input long to a string

            for (int i = 0; i < str.Length; i++) //loops through each char of the str
            {
                var digit = str.Substring(i, 1); //retrieves individual char(digit) from the string (at index i)
                var s = str.Remove(i, 1); //removes

                for (int j = 0; j < str.Length; j++)
                {
                    var m = Convert.ToInt64(s.Insert(j, digit));
                    if (m < smallest[0])
                    {
                        smallest[0] = m;
                        smallest[1] = i;
                        smallest[2] = j;
                    }
                }
            }
            return smallest;
        }
    }
}
