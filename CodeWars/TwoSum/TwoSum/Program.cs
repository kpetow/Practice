using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int target = 4;
            int[] result = new int[2];
            string output = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                    //else
                    //{
                    //    Console.WriteLine("False Check");
                    //}
                }

            }
            output = "(" + result[0] + ", " + result[1] + ")";
            Console.WriteLine(output);
        }
    }
}