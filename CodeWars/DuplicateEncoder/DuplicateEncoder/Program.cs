using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateEncoder

    // Convert unique letters to: (
    // Convert duplicate letters to: )

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to convert: ");
            string word = Console.ReadLine();
            word = word.ToLower();

            char[] chars = word.ToArray();
            char[] newWord = new char[chars.Length];

            for(int i = 0; i < chars.Length; i++) // loops through each letter of the chars array
            {
                for(int j = 0; j < chars.Length; j++) //compares the next value in an array to the index "i" that is being checked
                {
                    if(chars[i] == chars[j] && i != j)
                    {
                        newWord[i] = ')';
                        break;
                    }
                    newWord[i] = '(';
                }
            }
            string convert = new string(newWord);
            
            Console.WriteLine(newWord);

            Console.WriteLine(convert);
         }
    }
}
