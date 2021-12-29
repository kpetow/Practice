using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

        Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/

namespace MovingZerosToTheEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            int[] result = new int[arr.Length];
            List<int> list = new List<int>();
            foreach(int i in arr) { list.Add(i); }
            
            var current = list.OrderBy(x => x == 0).ToList();
            current.ForEach(Console.Write);
            Console.WriteLine(" \n");

            for (int j = 0; j < list.Count; j++)
            {
                result[j] = current[j];
                Console.Write(result[j]);
            }
            Console.WriteLine(" ");
        }
    }
}

//Best solution: 
/*
 * using System.Linq;
   public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
        return arr.OrderBy(x => x==0).ToArray();
        }
    }
*/