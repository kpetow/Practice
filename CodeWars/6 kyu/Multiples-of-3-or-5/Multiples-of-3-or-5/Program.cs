using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.Write("Enter a number: ");
                int value = int.Parse(Console.ReadLine());
                int sum = 0;
                int check;

                for (check = 1; check < value; check++)
                {
                    if (check % 5 == 0 || check % 3 == 0)
                    {
                        Console.WriteLine(check);
                        sum = sum + check;
                    }
                }
                Console.WriteLine($"The total sum is {sum}.\n");
                Console.WriteLine("Press enter to go again.\n");
                Console.ReadKey();
            }
            while (flag);
        }
    }
}
