using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/* The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8. It's easy to see that the sum of the perimeters of these squares is : 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80

    Could you give the sum of the perimeters of all the squares in a rectangle when there are n + 1 squares disposed in the same manner as in the drawing:
        http://i.imgur.com/EYcuB1wm.jpg

    Hint:
        See Fibonacci sequence

    Ref:
        http://oeis.org/A000045

    The function perimeter has for parameter n where n + 1 is the number of squares (they are numbered from 0 to n) and returns the total perimeter of all the squares.

        perimeter(5)  should return 80
        perimeter(7)  should return 216

*/

namespace PerimeterOfSquaresInARectangle
{
    public class Program
    {
        static void Main(string[] args)
        {

            BigInteger n = 5;
            BigInteger result;


            BigInteger s1 = 1, s2 = 1, s3;
            BigInteger sum = s1 + s2;

            for (int i = 1; i < n; ++i)
            {
                s3 = s1 + s2;
                s1 = s2;
                s2 = s3;
                sum += s3;
                //Console.WriteLine(sum);
            }
            result = 4 * sum;
            Console.WriteLine($"Result is {result}\n");
        }
    }
}
