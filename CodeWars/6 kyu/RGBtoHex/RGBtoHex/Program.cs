using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBtoHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 148;
            int g = 0;
            int b = 211;

            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            string output =  String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
            Console.WriteLine(output);


            //string Hex = "";

            //Dictionary<int, char> hex = new Dictionary<int, char>();
            //#region
            //hex.Add(0, '0');
            //hex.Add(1, '1');
            //hex.Add(2, '2');
            //hex.Add(3, '3');
            //hex.Add(4, '4');
            //hex.Add(5, '5');
            //hex.Add(6, '6');
            //hex.Add(7, '7');
            //hex.Add(8, '8');
            //hex.Add(9, '9');
            //hex.Add(10, 'A');
            //hex.Add(11, 'B');
            //hex.Add(12, 'C');
            //hex.Add(13, 'D');
            //hex.Add(14, 'E');
            //hex.Add(15, 'F');
            //#endregion

            //int[] input = { r, g, b };

            //for(int i = 0; i < input.Length; i++)
            //{
            //    int hold = input[i];
            //    if (hold < 0) {hold = 0;}
            //    if (hold > 255) {hold = 255;}

            //    int aux1 = hold / 16;
            //    int aux2 = hold % 16;

            //    Hex += hex[aux1].ToString() + hex[aux2].ToString();

            //}
            //Console.WriteLine(Hex);
        }
    }
}
