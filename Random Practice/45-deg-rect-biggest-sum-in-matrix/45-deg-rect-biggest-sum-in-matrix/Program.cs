using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_deg_rect_biggest_sum_in_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desired amount of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Desired amount of columns:");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[rows, columns];
            Random num = new Random();

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {                    
                    matrix[i, j] = num.Next(0, 10);
                    Console.Write(matrix[i, j] + " ");
                }              
                Console.WriteLine();
            }

            //Console.WriteLine("Dimension 1:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dimension 2:");
            //int b = int.Parse(Console.ReadLine());
            //checkSum(a ,b);
        }

        //static int checkSum(int a, int b)
        //{
        //    int sum;




        //    return sum;
        //}
    }
}
