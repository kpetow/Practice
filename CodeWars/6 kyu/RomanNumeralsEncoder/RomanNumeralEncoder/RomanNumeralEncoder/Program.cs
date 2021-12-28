using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            int n = 1990;

            SortedDictionary<int, string> numerals = new SortedDictionary<int, string>();
            numerals.Add(1, "I");
            numerals.Add(4, "IV");
            numerals.Add(5, "V");
            numerals.Add(9, "IX");
            numerals.Add(10, "X");
            numerals.Add(40, "XL");
            numerals.Add(50, "L");
            numerals.Add(90, "XC");
            numerals.Add(100, "C");
            numerals.Add(400, "CD");
            numerals.Add(500, "D");
            numerals.Add(900, "CM");
            numerals.Add(1000, "M");

            foreach (var k in numerals.Reverse())
            {
                while (n >= k.Key)
                {
                    n -= k.Key;
                    output += k.Value;
                }
            }
            Console.WriteLine(output);
        }
    }
}
