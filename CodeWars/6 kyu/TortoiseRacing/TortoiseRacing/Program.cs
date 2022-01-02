using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/55e2adece53b4cdcb900006c/train/csharp

namespace TortoiseRacing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write($"Enter v1: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write($"\nEnter v2: ");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write($"\nEnter g (starting distance for Turtle 1): ");
            int g = int.Parse(Console.ReadLine());

            foreach (int i in Race(v1, v2, g))
            {
                Console.Write(i + " ");
            }
        } 

        public static int[] Race(int v1, int v2, int g)
        {
            if (v1 >= v2)
            {
                return null;
            }
            int s = (int)((double)g / (v2 - v1)*3600);

            int[] time = { s / 3600, s % 3600 / 60, s % 60 };
            return time;    
        }
    }
}
