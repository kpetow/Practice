using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

  Notes:
    - Only lower case letters will be used (a-z). No punctuation or digits will be included.
    - Performance needs to be considered

        Input strings s1 and s2 are null terminated.

  Examples:

    scramble('rkqodlw', 'world') ==> True
    scramble('cedewaraaossoqqyt', 'codewars') ==> True
    scramble('katas', 'steak') ==> False
*/

namespace Scramblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string str1 = "rkqodlw";
            string str2 = "world";
            string output = "";

            

            Console.WriteLine("inputs:");
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("alphabetize:");
            str1 = String.Concat(str1.OrderBy(x => x));
            str2 = String.Concat(str2.OrderBy(x => x));

            string s1 = str1;
            string s2 = str2;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("----------------------------------------------------");
            
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] == s2[0])
                {
                    output += s2[0];
                    s2 = s2.Remove(0, 1);
                    Console.WriteLine($"s2 currently is {s2}");
                    Console.WriteLine($"Output is {output}");

                    if (output == str2)
                    {
                        Console.WriteLine(true);
                    }
                }

            }
            Console.WriteLine($"\nStr2 = {str2}");
            Console.WriteLine($"Output = {output}");
            if (output == str2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
