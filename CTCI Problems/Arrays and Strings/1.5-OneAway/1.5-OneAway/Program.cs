using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * There are 3 types of edits that can be performed on strings: insert a character, remove a character, or replace a character.
 * Given 2 strings, write a function to check if they are one edit (or zero edits) away.
 * 
 * Example:
    pale, ple => true
    pales, pale => true
    pale, bale => true
    pale, bake => false
 */

namespace _1._5_OneAway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First string: ");
            string s1 = Console.ReadLine();
            Console.Write("Second string: ");
            string s2 = Console.ReadLine();

            //Length check
            int diff = Math.Abs(s1.Length - s2.Length);

            if (diff > 1) { Console.WriteLine(false + ": failed on length"); }
            if (diff == 1) { Console.WriteLine(insertCheck(s1, s2) + ": used insert check"); }
            if (diff == 0) { Console.WriteLine(replaceCheck(s1, s2) + ": used replace check"); }
        }        

        //Method to test insertion of characters (strings are different lengths)
        static bool insertCheck(string a, string b)
        {
            string c = string.Empty;
            string d = string.Empty;
            if(a.Length > b.Length){c = b; d = a; }
            else {c = a; d = b;}

            for (int i = 0; i < c.Length; i++)
            {
                if(c[i] != d[i] && c[i] != d[i+1])
                {
                    return false;
                }
            }
            return true;    
        }

        //Strings are same length, testing for identical characters
        static bool replaceCheck(string a, string b)
        {
            int count = 0;
            for (int i = 0;i < a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    count++;
                }
                if(count > 1)
                {
                    return false;
                }
            }
            return true ;
        }
       
    }
}
