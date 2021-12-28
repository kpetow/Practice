using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_Tower___6_kyu
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFloors = 3;
            string[] result = new string[nFloors];

            int starsN = 0;
            int spacesN = 0;
            string stars = "";
            string spaces = "";

            for (int f = 1; f <= nFloors; f++)
            {
                starsN = f * 2 - 1;
                spacesN = (nFloors * 2 - 1 - starsN) / 2;
                Console.WriteLine(starsN);
                Console.WriteLine(spacesN);

                for (int j = 1; j <= starsN; j++)
                {
                    stars += "*";                    
                }
                for (int k = 1; k <= spacesN; k++)
                {
                    spaces += " ";
                }
                result[f - 1] = spaces + stars + spaces;
                stars = "";
                spaces = "";
            }
            foreach (string s in result)
            {
                Console.Write("|");
                Console.Write(s);
                Console.Write("|\n");

            }
        }
    }
}
