using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a function toWeirdCase (weirdcase in Ruby) that accepts a string, and returns the same string with all even indexed characters in each word upper cased, 
 * and all odd indexed characters in each word lower cased. The indexing just explained is zero based, so the zero-ith index is even, therefore that character
 * should be upper cased and you need to start over for each word.

The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words. Words will be separated by a single space(' ').
*/

namespace WeirdStringCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Weird string case";
            string final = "";
            int index = 0;

            char[] c = s.ToCharArray();
 
            for(int i = 0; i < c.Length; i++)
            {
                Console.Write($"Position {index}: ");
                Console.Write(c[i]);
                
                if (c[i] == ' ') 
                { 
                    final += c[i].ToString();
                    if(index % 2 == 0) { index += 0; }
                    if(index % 2 != 0) { index++; }
                }
                else
                {
                    if (index % 2 == 0) { final += c[i].ToString().ToUpper(); }
                    if (index % 2 != 0) { final += c[i].ToString().ToLower(); }
                    index++;
                }
                Console.WriteLine($" => {final}");
            }
            Console.WriteLine(final);
        }
    }
}
