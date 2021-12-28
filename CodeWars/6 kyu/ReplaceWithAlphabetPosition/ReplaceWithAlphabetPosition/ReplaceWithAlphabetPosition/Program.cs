using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Welcome.

//In this kata you are required to, given a string, replace every letter with its position in the alphabet.

//If anything in the text isn't a letter, ignore it and don't return it.

//"a" = 1, "b" = 2, etc.

//Example
//Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
//Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"(as a string)

namespace ReplaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var alphabet = new Dictionary<char, int>();
            #region alphabet
            alphabet.Add('a', 1);
            alphabet.Add('b', 2);
            alphabet.Add('c', 3);   
            alphabet.Add('d', 4);
            alphabet.Add('e', 5);
            alphabet.Add('f', 6);
            alphabet.Add('g', 7);
            alphabet.Add('h', 8);
            alphabet.Add('i', 9);
            alphabet.Add('j', 10);
            alphabet.Add('k', 11);
            alphabet.Add('l', 12);
            alphabet.Add('m', 13);
            alphabet.Add('n', 14);
            alphabet.Add('o', 15);
            alphabet.Add('p', 16);
            alphabet.Add('q', 17);
            alphabet.Add('r', 18);
            alphabet.Add('s', 19);
            alphabet.Add('t', 20);
            alphabet.Add('u', 21);
            alphabet.Add('v', 22);
            alphabet.Add('w', 23);
            alphabet.Add('x', 24);
            alphabet.Add('y', 25);
            alphabet.Add('z', 26);
            #endregion

            Console.Write("Enter a string of anything: ");            
            string text = Console.ReadLine();
            Console.WriteLine("");

            char[] input = text.ToCharArray();

            foreach (char c in input)
            {
                if(c >= 'a' && c <= 'z' || c >= 'A' && c<= 'Z')
                {
                    sb.Append(c);                    
                }
            }

            char[] output = sb.ToString().ToLower().ToCharArray();
            text = alphabet[output[0]].ToString();

            for (int x = 1; x < output.Length; x++)
            {
                text += " " + alphabet[output[x]].ToString();
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
